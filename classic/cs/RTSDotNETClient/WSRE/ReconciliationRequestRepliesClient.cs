using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace RTSDotNETClient.WSRE
{
    /// <summary>
    /// The ReconciliationRequestRepliesClient class allows to transmit reconciliation request replies to IRU 
    /// </summary>
    public class ReconciliationRequestRepliesClient : BaseWSClient
    {
        private const String InformationExchangeVersion = "2.0.0";

        /// <summary>
        /// Transmit the reconciliation request replies to IRU
        /// </summary>
        /// <param name="query">The query to be sent</param>
        /// <param name="messageId">The message id (required element allowing the IRU to report message processing failures back to the sender)</param>
        public void Send(Query query, string messageId, string subscriberID)
        {
            SanityChecks();

            query.CalculateHash();
            string queryStr = query.Serialize();

            Global.Trace("WSRE QUERY:\r\n" + queryStr + "\r\n");

            // Encryption
            EncryptionResult encrypted = EncryptionHelper.X509EncryptString(queryStr, this.PublicCertificate);

            BasicHttpBinding binding = new BasicHttpBinding();
            binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
            binding.ReaderQuotas.MaxDepth = int.MaxValue;
            binding.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
            binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            binding.MaxBufferSize = int.MaxValue;
            binding.MaxReceivedMessageSize = int.MaxValue;
            binding.OpenTimeout = TimeSpan.FromMinutes(3.0);
            binding.SendTimeout = TimeSpan.FromMinutes(5.0);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(5.0);
            binding.CloseTimeout = TimeSpan.FromMinutes(3.0);
            EndpointAddress remoteAddress = new EndpointAddress(this.WebServiceUrl);
            switch (remoteAddress.Uri.Scheme)
            {
                case "http":
                    binding.Security.Mode = BasicHttpSecurityMode.None;
                    break;
                case "https":
                    binding.Security.Mode = BasicHttpSecurityMode.Transport;
                    break;
                default:
                    binding.Security.Mode = BasicHttpSecurityMode.None;
                    break;
            }

            // Call the Web Service
            SafeTIRUploadWS.SafeTirUploadSoapClient ws = new SafeTIRUploadWS.SafeTirUploadSoapClient(binding, remoteAddress);
            SafeTIRUploadWS.SafeTIRReconParams request = new SafeTIRUploadWS.SafeTIRReconParams();
            request.SubscriberID = subscriberID;
            request.Sender_MessageID = messageId;
            request.MessageTag = encrypted.Thumbprint;
            request.ESessionKey = encrypted.SessionKey;
            request.SafeTIRReconData = encrypted.Encrypted;
            request.Information_Exchange_Version = InformationExchangeVersion;
            SafeTIRUploadWS.SafeTIRUploadAck ack = ws.WSRE(request);

            // Verify the Return Code => it should be 2 (OK)
            ReturnCode returnCode = (ReturnCode)ack.ReturnCode;
            if (returnCode != ReturnCode.SUCCESS)
                throw new RTSWebServiceException(String.Format("{0} ({1})", returnCode.ToString(), (int)returnCode), (int)returnCode);

            Global.Trace(string.Format("WSRE RESPONSE: RETURN_CODE={0} ({1})\r\n", (int)returnCode, returnCode));
        }
    }
}
