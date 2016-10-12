###Introduction
Setting up calls from your application is easy. Here is how to do it.

####Prerequisites
* We assume that you have gone through the Setup guide. If not, kindly take a look at it here [link!].
* You are registered on the sandbox[link!] and have access to either the web app or the android app.
* You have generated the API key here: https://account.sandbox.africastalking.com/settings/apikey.
* Login and navigate to https://account.sandbox.africastalking.com/voice/create to create a voice number.

###Making your first call
The virtual number that you just created is the default caller number when you make outgoing calls.
It is also the number that will be dialled when your clients want to make an incoming call. 

* To make an outgoing call, you need to create an AfricasTalkingGateway instance and pass your username, 
api key and the 'sandbox' flag as parameters. You will also need to require the gateway library.
* Create a new file 'voice.rb' in your project directory rubyapp.

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > voice.rb

```

For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch voice.rb

```

* Here are the three lines of code that you need.
```ruby

require './AfricasTalkingGateway'
gateway  = AfricasTalkingGateway.new("Youusername", "You-apikey->a2f1780b4bcd60323b9941675349cda487ba54109367f82532541636e9")
gateway.call('YourVirtualNo-0711082300', "YourPhoneNumber->0711XYZXYZ")

```
* With that you can run your ruby script to make the outgoing call.
For Ubuntu
```sh

$ cd
$ cd rubyapp
$ ruby voice.rb 

```

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>cd ruby voice.rb