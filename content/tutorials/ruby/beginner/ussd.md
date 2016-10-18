###Introduction (Intermediate)
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

Here is the process for setting up your script to receive USSD calls and response with the chosen menus.
Create a ruby file 'ussd.rb' where your response code will live.

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > ussd.rb

```

For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch ussd.rb

```

* Once the file is created, we can write the lines of code we need to serve a ussd menu:
```ruby

require './AfricasTalkingGateway'

post '/ussd' do
  @sessionId   = params[:sessionId]
  @serviceCode = params[:serviceCode]
  @phoneNumber = params[:phoneNumber]
  @text        = params[:text]

  response = "END Good Morning!" +@phoneNumber+ " Let us all thank the origins of ruby."

  body response
  status 200
end

```

* Running the ruby server should allow the script to be accessible on the URL: http://youripaddress:port/ussd