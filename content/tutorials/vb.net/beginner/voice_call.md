 ```vb

    Imports System.IO
    Imports System.Collections
    Imports System.Collections.Generic

    Public Class Application
        Public Shared Sub Main()

                ' Create a new instance of our awesome gateway class
                Dim gateway As New AfricasTalkingGateway("myAfricasTalkingUsername", "myAPIKey")
                
                ' Specify your AfricasTalking phone number in international format. eg +254711082XXX
                gateway.call("AfricasTalkingPhoneNumber", "+254711XXXYYY")
                
        End Sub
    End Class
    