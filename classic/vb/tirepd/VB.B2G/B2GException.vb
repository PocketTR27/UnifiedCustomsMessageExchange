Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace B2G
    Public Class B2GException
        Inherits ApplicationException

        Private _returnCode As AckReturnCode

        Public ReadOnly Property ReturnCode As AckReturnCode
            Get
                Return Me._returnCode
            End Get
        End Property

        Public Sub New(ByVal returnCode As AckReturnCode)
            MyBase.New("B2G Error")
            Me._returnCode = returnCode
        End Sub

        Public Sub New(ByVal returnCode As AckReturnCode, ByVal ex As Exception)
            MyBase.New("B2G Error", ex)
            Me._returnCode = returnCode
        End Sub

        Public Sub New(ByVal errorMessage As String, ByVal returnCode As AckReturnCode)
            MyBase.New(errorMessage)
            Me._returnCode = returnCode
        End Sub

        Public Sub New(ByVal errorMessage As String, ByVal returnCode As AckReturnCode, ByVal ex As Exception)
            MyBase.New(errorMessage, ex)
            Me._returnCode = returnCode
        End Sub
    End Class
End Namespace
