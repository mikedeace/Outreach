###Introduction 
We will create a simple ruby script that listens to the status of airtime requests rent to the Africa’s Talking Airtime API.

####Prerequisites
* We assume that you have gone through the Setup guide. If not, kindly take a look at it here [link!].
* You are registered on the sandbox[link!] and have access to either the web app or the android app.
* You have generated the API key here: https://account.sandbox.africastalking.com/settings/apikey.

We also expect that you either have a virtual machine online, or ar using a localhost tunneling service
like ngrok, to expose your local host to the web.

To set up on ngrok on your localhost, register for free and refer to the getting started documentation 
on https://dashboard.ngrok.com/get-started.

###Accessing a USSD Menu
* When the Africa's Talking API receives an Airtime sending request, The API pushes the request to the telco for the number to be topped up.
Immediately, a HTTP POST is sent to your web address where your script is listening out for the post. This is your callback URL or webhook[link!]

*This Post indicates the state of your request for the sent airtime, as received from the Telco.

*Create the call back URL/ruby script 'airtimestatus.rb'

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > airtimestatus.rb

```

For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch airtimestatus.rb

```

* Once the file is created, we can write the lines of code we need to listen for HTTP POSTS from the API:
```ruby

require './AfricasTalkingGateway'

post '/airtimestatus' do
  @status  = params[:status]
  @requestId = params[:requestId]

  #write the data to db
  
end

```

* Running the ruby server should allow the script to be accessible on the URL: http://youripaddress:port/airtimestatus