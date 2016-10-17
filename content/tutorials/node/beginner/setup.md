1. First install nodejs on your machine

    * ####Windows    
        * **32-bit**
		    https://nodejs.org/dist/v4.6.0/win-x86/node.exe
        * **64-bit**
		    https://nodejs.org/dist/v4.6.0/win-x64/node.exe

    * ###Linux
	    * **Ubuntu or Debian**
		    Paste these commands in your terminal
		    
		    ```
		    curl -sL https://deb.nodesource.com/setup_4.x | sudo -E bash -
		    sudo apt-get install -y nodejs
		    ```

2. Accure a ***username*** and ***api key***
    * Navigate to the Africastalking site and [generate](https://account.africastalking.com/settings/apikey) an api key. You will have to Sign In or Sign Up first.     
    
3. Start a project
        + create a folder in your desktop
        + open up a terminal or commandline and cd into the folder you created
        + run ``` npm init  ``` and accept all defaults
4. Install **africastalking** dependencies by running ``` npm install --save africastalking```