Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Xml.Serialization
Imports System.IO

Imports IRU.Encryption
Imports TIREPD.Messages
Imports VB.B2G.B2G

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://www.iru.org")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class TIREPDB2GService
    Inherits System.Web.Services.WebService
    Implements ITIREPDB2GServiceClassSoap

    Public Function TIREPDB2G(su As TIREPDB2GUploadParams) As TIREPDB2GUploadAck Implements ITIREPDB2GServiceClassSoap.TIREPDB2G
        Try
            Dim messageContent As String = DecryptMessageContent(su)
            ProcessMessageContent(su.MessageName, messageContent)
            Return CreateTIREPDB2GUploadAck(AckReturnCode.Success, su.SubscriberMessageID)
        Catch ex As B2GException
            Log(String.Format("ReturnCode {0} : {1} - {2}" & vbCrLf & "{3}", CInt(ex.ReturnCode), ex.ReturnCode.ToString(), ex.Message, ex.StackTrace), EventLogEntryType.[Error])
            Return CreateTIREPDB2GUploadAck(ex.ReturnCode, su.SubscriberMessageID)
        Catch ex As Exception
            Log(ex.Message & vbCrLf & ex.StackTrace, EventLogEntryType.[Error])
            Return CreateTIREPDB2GUploadAck(AckReturnCode.AnyUnclassifiedError, su.SubscriberMessageID)
        End Try
    End Function

    Private Sub Log(ByVal message As String, ByVal entryType As EventLogEntryType)
        If entryType = EventLogEntryType.[Error] Then
            Trace.WriteLine("[TIREPDB2GDotNET] ERROR: " & message & vbCrLf)
        Else
            Trace.WriteLine("[TIREPDB2GDotNET] " & message & vbCrLf)
        End If
    End Sub

    Private Function DecryptMessageContent(ByVal su As TIREPDB2GUploadParams) As String
        Dim file As String = Server.MapPath(My.Settings.B2GCertificateWithPrivateKeyPath)
        Dim password As String = My.Settings.B2GCertificateWithPrivateKeyPassword
        If String.IsNullOrEmpty(password) Then password = Nothing
        Dim cert As X509Certificate2 = EncryptionHelper.GetCertificateFromFile(file, password)

        Try
            ValidateParams(su, cert.PublicKey.Key.KeySize)
            Return EncryptionHelper.X509DecryptString(su.ESessionKey, su.MessageContent, su.CertificateID, cert)
        Catch ex As Exception
            Log(ex.Message, EventLogEntryType.[Error])
            Throw New B2GException(AckReturnCode.EncryptionDecryptionFailure, ex)
        End Try
    End Function

    Private Sub ValidateParams(ByVal su As TIREPDB2GUploadParams, ByVal keyLength As Integer)
        If String.IsNullOrEmpty(su.SubscriberID) OrElse su.SubscriberID <> My.Settings.SubscriberID Then Throw New B2GException(AckReturnCode.MissingOrInvalidSubscriberID)
        If String.IsNullOrEmpty(su.CertificateID) Then Throw New B2GException(AckReturnCode.MissingOrInvalidCertificateID)
        If su.ESessionKey Is Nothing OrElse (keyLength > 0 AndAlso su.ESessionKey.Length * 8 <> keyLength) Then Throw New B2GException(AckReturnCode.MissingOrInvalidESessionKey)
        If String.IsNullOrEmpty(su.SubscriberMessageID) Then Throw New B2GException(AckReturnCode.MissingOrInvalidSubscriberMessageID)
        If String.IsNullOrEmpty(su.InformationExchangeVersion) OrElse su.InformationExchangeVersion <> "1.0.0" Then Throw New B2GException(AckReturnCode.MissingOrInvalidInformationExchangeVersion)
        If String.IsNullOrEmpty(su.MessageName) Then Throw New B2GException(AckReturnCode.MissingOrInvalidMessageName)
        Dim dateValue As DateTime
        If Not DateTime.TryParse(su.TimeSent, dateValue) Then Throw New B2GException(AckReturnCode.MissingOrInvalidTimeSent)
        If su.MessageContent Is Nothing OrElse su.MessageContent.Length <= 0 Then Throw New B2GException(AckReturnCode.MissingOrInvalidMessageContents)
    End Sub

    Private Sub ProcessMessageContent(ByVal messageName As String, ByVal messageContent As String)
        Log("Message Content : " & messageContent, EventLogEntryType.Information)

        If messageName = "TIRPreDeclaration" Then
            Dim epd015 As EPD015 = CType(Deserialize(messageContent, GetType(EPD015)), EPD015)
            Log(String.Format("TIR Pre-Declaration received LRN = {0}", epd015.HEAHEA.RefNumHEA4), EventLogEntryType.Information)
            Dim thread As Thread = New Thread(New ParameterizedThreadStart(AddressOf ProcessResponseAsynchronously))
            thread.Start(epd015)
        ElseIf messageName = "TIRPreDeclarationCancellationNotice" Then
            Dim epd014 As EPD014 = CType(Deserialize(messageContent, GetType(EPD014)), EPD014)
            Log(String.Format("TIR Cancellation Request received MRN = {0}", epd014.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
            Dim thread As Thread = New Thread(New ParameterizedThreadStart(AddressOf ProcessResponseAsynchronously))
            thread.Start(epd014)
        ElseIf messageName = "TIRPreDeclarationAmendment" Then
            Dim epd013 As EPD013 = CType(Deserialize(messageContent, GetType(EPD013)), EPD013)
            Log(String.Format("TIR Amendment received MRN = {0}", epd013.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
            Dim thread As Thread = New Thread(New ParameterizedThreadStart(AddressOf ProcessResponseAsynchronously))
            thread.Start(epd013)
        ElseIf messageName = "TIRPreDeclarationInfOnNonArrMov" Then
            Dim epd141 As EPD141 = CType(Deserialize(messageContent, GetType(EPD141)), EPD141)
            Log(String.Format("TIR Information on non-arrived movement received MRN = {0}", epd141.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
            Dim thread As Thread = New Thread(New ParameterizedThreadStart(AddressOf ProcessResponseAsynchronously))
            thread.Start(epd141)
        Else
            Throw New B2GException(String.Format("Incorrect value for MessageName {0}", messageName), AckReturnCode.AnyUnclassifiedError)
        End If
    End Sub

    Private Sub ProcessResponseAsynchronously(ByVal epd As Object)
        Try

            If TypeOf epd Is EPD015 Then
                Dim epd015 As EPD015 = CType(epd, EPD015)

                Thread.Sleep(2000) ' Please write/call your code to validate the structure of the message and to persist it in DB here instead of doing a simple wait
                Dim success As Boolean = True

                If success Then
                    Dim epd928 As EPD928 = BuildEPD928(epd015)
                    Dim response As String = Serialize(epd928)
                    Log("Response Content : " & response, EventLogEntryType.Information)
                    Dim result As TIREPDG2BUploadAck = SendG2BResponse("TIRPreDeclarationReceived", response)

                    If result.ReturnCode = CInt(AckReturnCode.Success) Then
                        Log(String.Format("EPD928 transmitted with success for TIR Pre-Declaration {0}", epd928.HEAHEA.RefNumHEA4), EventLogEntryType.Information)
                    Else
                        Log(String.Format("G2B error returned for TIR Pre-Declaration {0} : return code {1}", epd928.HEAHEA.RefNumHEA4, result.ReturnCode), EventLogEntryType.Information)
                    End If
                Else
                    Dim epd917 As EPD917 = BuildEPD917(epd015)
                    Dim response As String = Serialize(epd917)
                    Log("Response Content : " & response, EventLogEntryType.Information)
                    Dim result As TIREPDG2BUploadAck = SendG2BResponse("TIRPreDeclarationError", response)

                    If result.ReturnCode = CInt(AckReturnCode.Success) Then
                        Log(String.Format("EPD917 transmitted with success for TIR Pre-Declaration {0}", epd917.HEAHEA.RefNumHEA4), EventLogEntryType.Information)
                    Else
                        Log(String.Format("G2B error returned for TIR Pre-Declaration {0} : return code {1}", epd917.HEAHEA.RefNumHEA4, result.ReturnCode), EventLogEntryType.Information)
                    End If
                End If
            ElseIf TypeOf epd Is EPD014 Then
                Dim epd014 As EPD014 = CType(epd, EPD014)

                Thread.Sleep(10000) ' Please write/call your code to validate the structure of the message and to persist it in DB here instead of doing a simple wait
                Dim success As Boolean = True

                Dim epd009 As EPD009 = BuildEPD009(epd014, success)
                Dim response As String = Serialize(epd009)
                Log("Response Content : " & response, EventLogEntryType.Information)
                Dim result As TIREPDG2BUploadAck = SendG2BResponse("TIRPreDeclarationCancellationReply", response)

                If result.ReturnCode = CInt(AckReturnCode.Success) Then
                    Log(String.Format("EPD009 transmitted with success for TIR Cancellation Request {0}", epd009.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
                Else
                    Log(String.Format("G2B error returned for TIR Cancellation Request {0} : return code {1}", epd009.HEAHEA.DocNumHEA5, result.ReturnCode), EventLogEntryType.Information)
                End If
            ElseIf TypeOf epd Is EPD013 Then
                Dim epd013 As EPD013 = CType(epd, EPD013)

                Thread.Sleep(10000) ' Please write/call your code to validate the structure of the message and to persist it in DB here instead of doing a simple wait
                Dim success As Boolean = True

                If success Then
                    Dim epd004 As EPD004 = BuildEPD004(epd013)
                    Dim response As String = Serialize(epd004)
                    Log("Response Content : " & response, EventLogEntryType.Information)
                    Dim result As TIREPDG2BUploadAck = SendG2BResponse("TIRPreDeclarationAmendmentAccepted", response)

                    If result.ReturnCode = CInt(AckReturnCode.Success) Then
                        Log(String.Format("EPD004 transmitted with success for TIR Amendment {0}", epd004.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
                    Else
                        Log(String.Format("G2B error returned for TIR Amendment {0} : return code {1}", epd004.HEAHEA.DocNumHEA5, result.ReturnCode), EventLogEntryType.Information)
                    End If
                Else
                    Dim epd005 As EPD005 = BuildEPD005(epd013)
                    Dim response As String = Serialize(epd005)
                    Log("Response Content : " & response, EventLogEntryType.Information)
                    Dim result As TIREPDG2BUploadAck = SendG2BResponse("TIRPreDeclarationAmendmentRejected", response)

                    If result.ReturnCode = CInt(AckReturnCode.Success) Then
                        Log(String.Format("EPD005 transmitted with success for TIR Amendment {0}", epd005.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
                    Else
                        Log(String.Format("G2B error returned for TIR Amendment {0} : return code {1}", epd005.HEAHEA.DocNumHEA5, result.ReturnCode), EventLogEntryType.Information)
                    End If
                End If
            ElseIf TypeOf epd Is EPD141 Then
                Dim epd141 As EPD141 = CType(epd, EPD141)

                Thread.Sleep(10000) ' Please write/call your code to validate the structure of the message and to persist it in DB here instead of doing a simple wait

                Log(String.Format("TIR Information on non-arrived movement processed {0}", epd141.HEAHEA.DocNumHEA5), EventLogEntryType.Information)
            End If

        Catch ex As Exception
            Log(ex.Message & vbCrLf & ex.StackTrace, EventLogEntryType.[Error])
            Throw New B2GException("An exception occured: " & ex.Message, AckReturnCode.AnyUnclassifiedError)
        End Try
    End Sub

    Private Function BuildEPD928(ByVal epd015 As EPD015) As EPD928
        Dim epd928 As EPD928 = New EPD928()
        epd928.HEAHEA = New EPD928HEAHEA()
        epd928.CUSOFFDEPEPT = New CUSOFFDEPEPTType()
        epd928.TRAPRIPC1 = New TRAPRIPC1Type()
        epd928.HEAHEA.RefNumHEA4 = epd015.HEAHEA.RefNumHEA4
        epd928.CUSOFFDEPEPT.RefNumEPT1 = epd015.CUSOFFDEPEPT.RefNumEPT1
        epd928.TRAPRIPC1.CitPC124 = epd015.TRAPRIPC1.CitPC124
        epd928.TRAPRIPC1.CouPC125 = epd015.TRAPRIPC1.CouPC125
        epd928.TRAPRIPC1.NADLNGPC = epd015.TRAPRIPC1.NADLNGPC
        epd928.TRAPRIPC1.NamPC17 = epd015.TRAPRIPC1.NamPC17
        epd928.TRAPRIPC1.PosCodPC123 = epd015.TRAPRIPC1.PosCodPC123
        epd928.TRAPRIPC1.StrAndNumPC122 = epd015.TRAPRIPC1.StrAndNumPC122
        epd928.TRAPRIPC1.TINPC159 = epd015.TRAPRIPC1.TINPC159
        epd928.TRAPRIPC1.HITPC126 = epd015.TRAPRIPC1.HITPC126
        Return epd928
    End Function

    Private Function BuildEPD917(ByVal epd015 As EPD015) As EPD917
        Dim epd917 As EPD917 = New EPD917()
        epd917.HEAHEA = New EPD917HEAHEA()
        epd917.FUNERRER1 = New FUNERRER1Type()
        epd917.HEAHEA.RefNumHEA4 = epd015.HEAHEA.RefNumHEA4
        epd917.FUNERRER1.ErrPoiER12 = "/EPD015/HEAHEA/RefNUMHEA4"
        epd917.FUNERRER1.OriAttValER14 = epd015.HEAHEA.RefNumHEA4
        epd917.FUNERRER1.ErrTypER11 = "12"
        epd917.FUNERRER1.ErrReaER13 = "Duplicate LRN"
        Return epd917
    End Function

    Private Function BuildEPD009(ByVal epd014 As EPD014, ByVal acceptIt As Boolean) As EPD009
        Dim epd009 As EPD009 = New EPD009()
        epd009.HEAHEA = New EPD009HEAHEA()
        epd009.CUSOFFDEPEPT = New CUSOFFDEPEPTType()
        epd009.TRAPRIPC1 = New TRAPRIPC1Type()
        epd009.HEAHEA.DocNumHEA5 = epd014.HEAHEA.DocNumHEA5
        epd009.HEAHEA.CanDecHEA93 = If(acceptIt, EPD009HEAHEACanDecHEA93.Item1, EPD009HEAHEACanDecHEA93.Item0)
        epd009.HEAHEA.CanDecHEA93Specified = True

        If epd014.HEAHEA.CancellationRequestDateSpecified Then
            epd009.HEAHEA.CancellationRequestDateSpecified = True
            epd009.HEAHEA.CancellationRequestDate = epd014.HEAHEA.CancellationRequestDate
            epd009.HEAHEA.CancellationDecisionDate = DateTime.Now.Date
            epd009.HEAHEA.CancellationDecisionDateSpecified = True
        End If

        If Not String.IsNullOrEmpty(epd014.HEAHEA.DatOfCanReqHEA147) Then
            epd009.HEAHEA.DatOfCanReqHEA147 = epd014.HEAHEA.DatOfCanReqHEA147
            epd009.HEAHEA.DatOfCanDecHEA146 = DateTime.Now.ToString("yyyyMMdd")
        End If

        epd009.CUSOFFDEPEPT.RefNumEPT1 = epd014.CUSOFFDEPEPT.RefNumEPT1
        epd009.TRAPRIPC1.CitPC124 = epd014.TRAPRIPC1.CitPC124
        epd009.TRAPRIPC1.CouPC125 = epd014.TRAPRIPC1.CouPC125
        epd009.TRAPRIPC1.NADLNGPC = epd014.TRAPRIPC1.NADLNGPC
        epd009.TRAPRIPC1.NamPC17 = epd014.TRAPRIPC1.NamPC17
        epd009.TRAPRIPC1.PosCodPC123 = epd014.TRAPRIPC1.PosCodPC123
        epd009.TRAPRIPC1.StrAndNumPC122 = epd014.TRAPRIPC1.StrAndNumPC122
        epd009.TRAPRIPC1.TINPC159 = epd014.TRAPRIPC1.TINPC159
        epd009.TRAPRIPC1.HITPC126 = epd014.TRAPRIPC1.HITPC126
        Return epd009
    End Function

    Private Function BuildEPD004(ByVal epd013 As EPD013) As EPD004
        Dim epd004 As EPD004 = New EPD004()
        epd004.HEAHEA = New EPD004HEAHEA()
        epd004.HEAHEA.DocNumHEA5 = epd013.HEAHEA.DocNumHEA5
        epd004.HEAHEA.GuaranteeNumber = epd013.HEAHEA.GuaranteeNumber

        If epd013.HEAHEA.AmendmentDateSpecified Then
            epd004.HEAHEA.AmendmentDate = epd013.HEAHEA.AmendmentDate
            epd004.HEAHEA.AmendmentDateSpecified = True
        End If

        epd004.HEAHEA.AmendmentAcceptanceDate = DateTime.UtcNow.Date
        epd004.HEAHEA.AmendmentAcceptanceDateSpecified = True

        If epd013.TRAPRIPC1 IsNot Nothing Then
            epd004.TRAPRIPC1 = New TRAPRIPC1Type()
            epd004.TRAPRIPC1.NamPC17 = epd013.TRAPRIPC1.NamPC17
            epd004.TRAPRIPC1.StrAndNumPC122 = epd013.TRAPRIPC1.StrAndNumPC122
            epd004.TRAPRIPC1.PosCodPC123 = epd013.TRAPRIPC1.PosCodPC123
            epd004.TRAPRIPC1.CitPC124 = epd013.TRAPRIPC1.CitPC124
            epd004.TRAPRIPC1.CouPC125 = epd013.TRAPRIPC1.CouPC125
            epd004.TRAPRIPC1.NADLNGPC = epd013.TRAPRIPC1.NADLNGPC
            epd004.TRAPRIPC1.TINPC159 = epd013.TRAPRIPC1.TINPC159
            epd004.TRAPRIPC1.HITPC126 = epd013.TRAPRIPC1.HITPC126
            epd004.TRAPRIPC1.TAXPC159 = epd013.TRAPRIPC1.TAXPC159
        End If

        If epd013.CUSOFFDEPEPT IsNot Nothing Then
            epd004.CUSOFFDEPEPT = New CUSOFFDEPEPTType()

            If Not String.IsNullOrEmpty(epd013.CUSOFFDEPEPT.CouRefNumEPT1) Then
                epd004.CUSOFFDEPEPT.CouRefNumEPT1 = epd013.CUSOFFDEPEPT.CouRefNumEPT1
            End If

            epd004.CUSOFFDEPEPT.RefNumEPT1 = epd013.CUSOFFDEPEPT.RefNumEPT1
        End If

        Return epd004
    End Function

    Private Function BuildEPD005(ByVal epd013 As EPD013) As EPD005
        Dim epd005 As EPD005 = New EPD005()
        epd005.HEAHEA = New EPD005HEAHEA()
        epd005.HEAHEA.DocNumHEA5 = epd013.HEAHEA.DocNumHEA5
        epd005.HEAHEA.GuaranteeNumber = epd013.HEAHEA.GuaranteeNumber

        If epd013.HEAHEA.AmendmentDateSpecified Then
            epd005.HEAHEA.AmendmentDate = epd013.HEAHEA.AmendmentDate
            epd005.HEAHEA.AmendmentDateSpecified = True
        End If

        epd005.HEAHEA.AmendmentRejectionDate = DateTime.UtcNow.Date
        epd005.HEAHEA.AmendmentRejectionDateSpecified = True

        Dim funerrer1 As FUNERRER1Type = New FUNERRER1Type
        funerrer1.ErrPoiER12 = "EPD013/HEAHEA/DocNumHEA5"
        funerrer1.OriAttValER14 = epd013.HEAHEA.DocNumHEA5
        funerrer1.ErrTypER11 = "12"
        funerrer1.ErrReaER13 = "MRN has been already use for Transit"
        epd005.FUNERRER1 = New List(Of FUNERRER1Type)
        epd005.FUNERRER1.Add(funerrer1)

        If epd013.TRAPRIPC1 IsNot Nothing Then
            epd005.TRAPRIPC1 = New TRAPRIPC1Type()
            epd005.TRAPRIPC1.NamPC17 = epd013.TRAPRIPC1.NamPC17
            epd005.TRAPRIPC1.StrAndNumPC122 = epd013.TRAPRIPC1.StrAndNumPC122
            epd005.TRAPRIPC1.PosCodPC123 = epd013.TRAPRIPC1.PosCodPC123
            epd005.TRAPRIPC1.CitPC124 = epd013.TRAPRIPC1.CitPC124
            epd005.TRAPRIPC1.CouPC125 = epd013.TRAPRIPC1.CouPC125
            epd005.TRAPRIPC1.NADLNGPC = epd013.TRAPRIPC1.NADLNGPC
            epd005.TRAPRIPC1.TINPC159 = epd013.TRAPRIPC1.TINPC159
            epd005.TRAPRIPC1.HITPC126 = epd013.TRAPRIPC1.HITPC126
            epd005.TRAPRIPC1.TAXPC159 = epd013.TRAPRIPC1.TAXPC159
        End If

        If epd013.CUSOFFDEPEPT IsNot Nothing Then
            epd005.CUSOFFDEPEPT = New CUSOFFDEPEPTType()

            If Not String.IsNullOrEmpty(epd013.CUSOFFDEPEPT.CouRefNumEPT1) Then
                epd005.CUSOFFDEPEPT.CouRefNumEPT1 = epd013.CUSOFFDEPEPT.CouRefNumEPT1
            End If

            epd005.CUSOFFDEPEPT.RefNumEPT1 = epd013.CUSOFFDEPEPT.RefNumEPT1
        End If

        Return epd005
    End Function

    Private Function SendG2BResponse(ByVal messageName As String, ByVal messageContent As String) As TIREPDG2BUploadAck
        Dim G2BUrl As String = My.Settings.G2BWebServiceURL
        Dim certFile As String = Server.MapPath(My.Settings.G2BCertificatePath)
        Dim cert As X509Certificate2 = EncryptionHelper.GetCertificateFromFile(certFile)
        Dim encryptionResult As EncryptionResult = EncryptionHelper.X509EncryptString(messageContent, cert)
        Dim cli As TIREPDG2BService = New TIREPDG2BService()
        cli.Url = G2BUrl
        Dim parameters As TIREPDG2BUploadParams = New TIREPDG2BUploadParams()
        parameters.MessageName = messageName
        parameters.SubscriberID = My.Settings.SubscriberID
        parameters.InformationExchangeVersion = "1.0.0"
        parameters.CertificateID = encryptionResult.Thumbprint
        parameters.ESessionKey = encryptionResult.SessionKey
        parameters.MessageContent = encryptionResult.Encrypted
        parameters.SubscriberMessageID = Guid.NewGuid().ToString()
        parameters.TimeSent = DateTime.Now
        Return cli.TIREPDG2B(parameters)
    End Function

    Private Function Serialize(ByVal obj As Object) As String
        Dim ser As XmlSerializer = New XmlSerializer(obj.[GetType]())
        Dim writer As StringWriter = New StringWriter()
        ser.Serialize(writer, obj)
        Return writer.ToString()
    End Function

    Private Function Deserialize(ByVal messageContent As String, ByVal t As Type) As Object
        Try
            Dim ser As XmlSerializer = New XmlSerializer(t)
            Dim reader As StringReader = New StringReader(messageContent)
            Return ser.Deserialize(reader)
        Catch ex As Exception
            Log(ex.Message, EventLogEntryType.[Error])
            If ex.InnerException IsNot Nothing Then Log(ex.InnerException.Message, EventLogEntryType.[Error])
            Throw New B2GException(AckReturnCode.SchemaValidation, ex)
        End Try
    End Function

    Private Function CreateTIREPDB2GUploadAck(ByVal returnCode As AckReturnCode, ByVal subscriberMessageID As String) As TIREPDB2GUploadAck
        Dim uploadAck As TIREPDB2GUploadAck = New TIREPDB2GUploadAck()
        uploadAck.ReturnCode = CType(returnCode, Integer)
        uploadAck.SubscriberMessageID = subscriberMessageID
        Return uploadAck
    End Function
End Class