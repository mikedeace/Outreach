- This is also another way to send Sms

``` vb

        Imports System.IO
        Imports System.Collections
        Imports System.Collections.Generic

        Module Module1
            Public Sub Main()

                ' Create a new instance of our awesome gateway class
                Dim gateway As New AfricasTalkingGateway("myAfricasTalkingUsername", "myAPIKey")

                ' Please ensure you include the country code (+254 for Kenya in this case)
                gateway.sendMessage("+254716XXYYZZ", "Hi you")

            End Sub
        End Module

