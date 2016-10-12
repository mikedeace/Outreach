## Setting up on Windows
To install Ruby on windows, there is a great library at www.rubyinstaller.org. 
The library gives you everything you need to get started on windows including: 
* important documentation to get started
 * the execution environment
 * the Ruby language
 

Choose the version and them Download the installer. If you don't know which version to use, you can start with Ruby 2.2.X. Once the download is complete, click on the .exe file accept the terms and follow the prompts. 
When presented with the option to make all .rb files associated with this installation as well as whether to include this installation on the path, choose all.
To check that you have the right version installed on your machine:

```sh
C:\Users\YourUsername>ruby -v
```

## Setting up on Linux(Ubuntu)
We assume that you are on an Ubuntu/Debian system as this is the most downloaded linux flavor. A quick guide on how to install Ruby on linux distros is available on the official Ruby language website: https://www.ruby-lang.org/en/documentation/installation/.
You can follow the steps below for Ubuntu.

```sh
$ sudo apt-get update
$ sudo apt-get install ruby-full
```
To check that you have the right Ruby version installed:
```sh
$ruby -v
```

## Sign Up and create API Key. Get the Library.
To interact with the Africastalking API using Ruby, follow the instructions below:
* Visit https://www.africastalking.com/ and register a live account. (for the sandbox, which is recommended as the first place to start, visit  https://account.sandbox.africastalking.com/login?page=/ )
* Take note of your africastalking account username. The username is distinct and different for both platforms (live/sandbox) and should not be confused.
* For purposes of this walkthrough, we propose that you use the sandbox environment.
* Next, generate your api key. This should be done at the following url: https://account.sandbox.africastalking.com/settings/apikey, once you are logged into your sandbox account.
* Make sure you store this API key somewhere safe. You could also just email it into your inbox. We don't store this for security reasons and if you loose it, you will have to generate a new one.
* We provide a Ruby library that you can use to interact with the API. This saves you the effort of writing an API wrapper to talk to the endpoints directly.
*The Ruby library is found at: http://docs.africastalking.com/smslibraries/ruby

##Test that you have everything.
Now that we have all the tools to help you get started, we need to test to make sure everything is ok. 
We do that using the sandbox environment, available for both android and web.
* Download the Sandbox App from google store here: http://www.apk16.com/download/africastalking.nerdbox.activity.html or
* Visit the web application here: https://sandbox.africastalking.com
* Register with your phone number on the application to begin using the sandbox.
* Create a folder where your application will live. You can do this in the downloads folder.

For windows
```sh

C:\Users\YourUsername>mkdir rubyapp

```
For linux(Ubuntu)
```sh

$ mkdir rubyapp

```
* Copy the AfricasTalkingGateway.rb library to the rubyapp folder.
For windows, copy from the Downloads folder to the rubyapp folder:
```sh

C:\Users\YourUsername\Downloads>xcopy AfricasTalkingGateway.rb C:\User\YourUsername\rubyapp

```
For Ubuntu:
```sh

$ cp /home/YourUsername/Downloads/AfricasTalkingGateway.rb /home/YourUsername/rubyapp

```
* Create a ruby file and paste the following lines in it to send your first SMS on the sandbox:
For Ubuntu
```sh

$ cd
$ cd rubyapp
$ touch sms.rb

```
* Write the three lines of code to your sms.rb file

```ruby

require './AfricasTalkingGateway'

gateway = AfricasTalkingGateway.new("jani", "YourAPIKeyLikeThis->a2f1780b4bcd60323b9941675349cda487ba54109367f82532541636e9","sandbox")

gateway.sendMessage("+254711XYZXYZ", "Hello from Ruby!")


```

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd  rubyapp
>echo "require './AfricasTalkingGateway' " > sms.rb
>echo "gateway = AfricasTalkingGateway.new("jani", "YourAPIKeyLikeThis->a2f1780b4bcd60323b9941675349cda487ba54109367f82532541636e9","sandbox")" >> sms.rb
>echo "gateway.sendMessage("+254711XYZXYZ", "Hello from Ruby!")" >> sms.rb

```

* To run the application, change directory to your project folder and run the command ruby <'script name'>
For Ubuntu
```sh

$ cd
$ cd rubyapp
$ ruby sms.rb 

```

For Windows
```sh

>cd\
>cd User
>cd YourUsername
>cd rubyapp
>cd ruby sms.rb

```
* If everything is set up fine, you should receive an SMS on the number +254711XYZXYZ which you registered with on your sandbox app. :-)
