###Introduction (Intermediate)
You can have a pilot line that receives calls for you or your organization. When you receive sevearl calls
at once, you can determine how to route this calls as well as what to play tour users as they wait on line.

####Prerequisites
* We assume that you have gone through the Setup guide. If not, kindly take a look at it here [link!].
* You are registered on the sandbox[link!] and have access to either the web app or the android app.
* You have generated the API key here: https://account.sandbox.africastalking.com/settings/apikey.
* Login and navigate to https://account.sandbox.africastalking.com/voice/create to create a voice number.

We also expect that you either have a virtual machine online, or ar using a localhost tunneling service
like ngrok, to expose your local host to the web.

To set up on ngrok on your localhost, register for free and refer to the getting started documentation 
on https://dashboard.ngrok.com/get-started.

###Receiving a call
* When the Africa's Talking API receives an incoming call on your virtual number, a HTTP POST is sent to
your web address where your script is listening out for the post. This is your callback URL or webhook[link!]
* You receive the HTTP POST and respond to the Africa's Talking Voice Server with XML response in PLAIN TEXT after
running through your logic(saving to the database, classifying the caller, fetching the callers details).
* The Africa's Talking Voice Server executes the response action from your call back URL. 
For a list of accepted actions, please see the documentation here: http://docs.africastalking.com/voice/call

Here is the process for setting up your script to receive calls and response with the action of your choice.
Create a ruby file 'voicecall.rb' where your response code will live.

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > voicecall.rb

```

For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch voicecall.rb

```

* Once the is created, we can write the lines of code we need to receive an incoming call:
```ruby

require './AfricasTalkingGateway'

post '/voicecall' do
  @sessionId = params[:sessionId]
  @isActive  = params[:isActive]

  content_type 'text/plain'

  # Compose the response
  response  =  "<Response>" \
               "<Say voice='man'>\"Thank you for writing in ruby, it's so concise!}\"</Say>" \
               "</Response>"

  body response
  status 200
end

```

* Running the ruby server should allow the script to be accessible on the URL: http://youripaddress:port/voicecall