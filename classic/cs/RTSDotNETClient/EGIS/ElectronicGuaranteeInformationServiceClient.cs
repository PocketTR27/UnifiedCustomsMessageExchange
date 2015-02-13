using System;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;

namespace RTSDotNETClient.EGIS
{

    /// <summary>
    /// The ElectronicGuaranteeInformationServiceClient class allows to query the EGIS Web Service
    /// in order to retrieve some information related to a TIR Carnet (status, holder, association, etc)
    /// </summary>
    public class ElectronicGuaranteeInformationServiceClient : BaseWSClient
    {
        /// <summary>
        /// The private certificate used for decryption of the response
        /// </summary>
        public X509Certificate2 PrivateCertificate { get; set; }        
        
        /// <summary>
        /// Send a query to the EGIS Web Service to retrieve some information related to a TIR Carnet (status, holder, association, etc),
        /// the EPD messages needed for eTIR (Releases for transit, Write-offs, ...) and the SafeTIR messages (Terminations, Exit, ...)
        /// </summary>
        /// <param name="query">The query object</param>
        /// <param name="queryId">The query id (optional value the sender may use to track this message)</param>
        /// <returns>The response returned by the EGIS Web Service</returns>
        public EGISResponse EGISQuery(EGISQuery query, string queryId)
        {
            SanityChecks();
            if (this.PrivateCertificate == null)
                throw new Exception("The private certificate is missing.");

            query.CalculateHash();
            string queryStr = query.Serialize();

            Global.Trace("EGIS QUERY:\r\n" + queryStr + "\r\n");

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
            ElectronicGuaranteeInformationServiceWS.EGISClassSoap ws = new ElectronicGuaranteeInformationServiceWS.EGISClassSoapClient(binding, remoteAddress);

            ElectronicGuaranteeInformationServiceWS.EGISQueryRequest request = new ElectronicGuaranteeInformationServiceWS.EGISQueryRequest();
            request.su = new ElectronicGuaranteeInformationServiceWS.EGISQueryType();
            request.su.SubscriberID = query.Body.Sender;
            request.su.Query_ID = queryId;
            request.su.MessageTag = encrypted.Thumbprint;
            request.su.ESessionKey = encrypted.SessionKey;
            request.su.EGISQueryParams = encrypted.Encrypted;

            ElectronicGuaranteeInformationServiceWS.EGISQueryResponse response = ws.EGISQuery(request);

            // Verify the Return Code => it should be 2 (OK)
            ReturnCode returnCode = (ReturnCode)response.EGISResult.ReturnCode;
            if (returnCode != ReturnCode.SUCCESS)
                throw new RTSWebServiceException(String.Format("{0} ({1})", returnCode.ToString(), (int)returnCode),(int)returnCode);

            string respStr = EncryptionHelper.X509DecryptString(response.EGISResult.ESessionKey,
                    response.EGISResult.EGISResponseParams, response.EGISResult.MessageTag, this.PrivateCertificate);

            Global.Trace(string.Format("EGIS RESPONSE: RETURN_CODE={0} ({1})\r\n{2}\r\n", (int)returnCode, returnCode, respStr));

            return QueryResponseFactory.Deserialize<EGISResponse>(respStr, EGISResponse.Xsd);
        }
    }
}
