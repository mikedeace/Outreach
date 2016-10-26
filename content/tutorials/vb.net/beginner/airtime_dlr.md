```vb


Imports System.IO
Imports System.Collections
Imports System.Collections.Generic

Public Class Application
    Public Shared Sub Main()
        
            ' Create a new instance of our awesome gateway class
            Dim gateway As New AfricasTalkingGateway("myAfricasTalkingUsername", "myAPIKey")

            Object userData = gateway.getUserData()
            Dim balance As String = userData("balance")
            System.Console.WriteLine("Balance: " + balance)
            
    End Sub
End Class