1. Create an sms short code. [click here to navigate](https://account.sandbox.africastalking.com/sms/createshortcode)

2. Your first SMS
    
    1. Start a project
        + create a folder in your desktop
        + open up a terminal or commandline and cd into the folder you created
        + run ``` npm init  ``` and accept all defaults
    2. Install **africastalking** dependencies by running ``` npm install --save africastalking```
    3. Create a file in your project called **sms.js**
    4. Open your **sms.js** file in your favourite text editor and paste the following code
        * replace **YOUR_API_KEY** with the apikey you generated and  **YOUR_USERNAME** with your africastalking username
        * add your country code as a prefix in YOUR_NUMBER like '+254712345678' 
    ```
    
    var options = {
    apiKey: 'YOUR_API_KEY',
    username: 'YOUR_USERNAME',
    format: 'json'
       };
       
    var sms = AfricasTalking.SMS;   
       
    var AfricasTalking = require('africastalking')(options);
    
    var opts ={
        'to' : 'YOUR_NUMBER', //include the country code example +254712345678
        'from':'YOUR_SHORT_CODE',
        'message':'Hello AFRICA'
    };
    
    sms.send(opts);
    
    ```
   3. switch to the terminal and run ```node sms.js``
   4. view the message you just sent to the target number
