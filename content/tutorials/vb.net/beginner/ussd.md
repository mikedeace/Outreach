###Introduction
The USSD channel allows you to serve two way interactive content via a USSD call channel.
Users get a menu everytime they dial/interact with the USSD channel.

####Prerequisites
* We assume that you have gone through the Setup guide. If not, kindly take a look at it here [link!].
* You are registered on the sandbox[link!] and have access to either the web app or the android app.
* You have generated the API key here: https://account.sandbox.africastalking.com/settings/apikey.
* Login and navigate to https://account.sandbox.africastalking.com/ussd/createchannel to create a ussd channel.

We also expect that you either have a virtual machine online, or ar using a localhost tunneling service
like ngrok, to expose your local host to the web.

To set up on ngrok on your localhost, register for free and refer to the getting started documentation 
on https://dashboard.ngrok.com/get-started.

###Accessing a USSD Menu
* When the Africa's Talking API receives an incoming call on your USSD channel, a HTTP POST is sent to
your web address where your script is listening out for the post. This is your callback URL or webhook[link!]
* You receive the HTTP POST and respond to the Africa's Talking USSD server with a plain text response after
running through your logic(saving to the database, classifying the caller, fetching the callers details).
* The Africa's Talking USSD server executes the grabs the first menu from your call back URL and presents it to the user. 
Once the user chooses an option, the whole process is repeated and the user served with the menus they chose until they cancel 
the session.



## using visual studio 2013 >
> The full project is on [github](https://github.com/patrick-AT/VisualBasic-USSD-Sample)

* go to file > new > project
* in the projects window choose web under visual basic
* select *ASP.NET Web Application* and name your project as you like
* click next
* in the template window select *Empty* and ensure the *web api* check box is selected and click ok
* after your project has ben set up, locate the *Controllers* folder in your solution explorer
* right click on the *Conrolers* folder, select *Add* > *Controller*
* in the *Add Scaffold* window, select *Web API 2 Controller - Empty* and click add
* Give it a name, we will call it *MobileController*
* paste this code in the *MobileController.vb* file.

```
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace Controllers

    ' you need to explicitly declare the parameters that the server will send to your app
    ' the server returns phoneNumber, text, sessionId and serviceCode 
    ' this class acts as complex type to facilitate parameter binding
    ' make getters and setters for the values you expect from the server
    Public Class ServerResponse
        Public Property text() As String
            Get
                Return m_text
            End Get
            Set
                m_text = Value
            End Set
        End Property
        Private m_text As String
        Public Property phoneNumber() As String
            Get
                Return m_phoneNumber
            End Get
            Set
                m_phoneNumber = Value
            End Set
        End Property
        Private m_phoneNumber As String
        Public Property sessionId() As String
            Get
                Return m_sessionId
            End Get
            Set
                m_sessionId = Value
            End Set
        End Property
        Private m_sessionId As String
        Public Property serviceCode() As String
            Get
                Return m_serviceCode
            End Get
            Set
                m_serviceCode = Value
            End Set
        End Property
        Private m_serviceCode As String
    End Class



    <RoutePrefix("api/mobile")>  ' specify the route prefix so that your route can look like...  localhost:8080/api/mobile...
    Public Class MobileController
        Inherits ApiController 'the controller should inherit from the ApiController class

        <Route("ussd")>         ' specify the actual route, your url will look like... localhost:8080/api/mobile/ussd...
        <HttpPost, ActionName("ussd")> ' state that the method you intend to create is a POST 
        Public Function ussd(<FromBody> ServerResponse As ServerResponse) As HttpResponseMessage ' declare a complex type as input parameter
            Dim rs As HttpResponseMessage
            Dim response As String

            ' the server may return text parameter as null and hence the need to initialize it to an empty string
            If ServerResponse.text Is Nothing Then
                ServerResponse.text = ""
            End If

            ' loop through the server's text value to determine the next cause of action
            If ServerResponse.text.Equals("", StringComparison.Ordinal) Then
                response = "CON This is AfricasTalking \n" + ' always include a 'CON' in your first statements
                    "1. Get you phone number"
            ElseIf ServerResponse.text.Equals("1", StringComparison.Ordinal) Then
                response = "END Your phone number is " + ServerResponse.phoneNumber 'the last response starts with an 'END' so that the server understands that its the final response
            Else
                response = "END bad option"
            End If

            ' all 'POST' operations should return status code of 201 (HttpStatusCode.Created == 201) and a representation of the value
            rs = Request.CreateResponse(HttpStatusCode.Created, response)

            ' append your response to the HttpResponseMessage and set content type to text/plain, exactly what the server expects
            rs.Content = New StringContent(response, Encoding.UTF8, "text/plain")
            ' finally return your response to the server
            Return rs

        End Function
    End Class
End Namespace
```

* build and run the solution
* tunnel the allocated port using ngrok or any other tunneling tool
* register the resulting url from ngrok as a callback in the africastalking website, append the following route **/api/mobile/ussd** before you register

* dial your ussd code 

