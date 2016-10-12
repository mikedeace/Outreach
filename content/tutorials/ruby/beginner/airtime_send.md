###Introduction 
We will create a simple ruby script that can send airtime to phone numbers using the Africa’s Talking API.

####Prerequisites
* We assume that you have gone through the Setup guide. If not, kindly take a look at it here [link!].
* You are registered on the sandbox[link!] and have access to either the web app or the android app.
* You have generated the API key here: https://account.sandbox.africastalking.com/settings/apikey.

###Accessing a USSD Menu
* When the Africa's Talking API receives an Airtime sending request, The API pushes the request to the telco for the number to be topped up.
Immediately, a HTTP POST is sent to your web address where your script is listening out for the post. This is your callback URL or webhook[link!]

*This Post indicates the state of your request for the sent airtime, as received from the Telco.

Here is the process for sending your airtime in a few lines of code. 
* Create a ruby file 'airtime.rb' and paste the following lines in it to send your first SMS on the sandbox:
For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch airtime.rb

```

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > airtime.rb

```

* Write the three lines of code to your airtime.rb file

```ruby

require './AfricasTalkingGateway'

gateway = AfricasTalkingGateway.new("jani", "YourAPIKeyLikeThis->a2f1780b4bcd60323b9941675349cda487ba54109367f82532541636e9","sandbox")

gateway.sendAirtime( [{:phoneNumber => "+254711AAABBB", :amount => "KES CC"},{:phoneNumber => "+254711XXXYYY", :amount => "KES XX"}] )


```
* To send airtime, change directory to your project folder and run the command ruby <'script name'>
For Ubuntu
```sh

$ cd
$ cd rubyapp
$ ruby airtime.rb 

```

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd rubyapp
>cd ruby airtime.rb

```
* If everything is set up fine, you should receive an SMS on the number +254711XYZXYZ which you registered with on your sandbox app. :-)