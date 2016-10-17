1. Create a file in your project called **sms.js**
    1. Open your **airtime.js** file in your favourite text editor and paste the following code
        * replace **YOUR_API_KEY** with the apikey you generated and  **YOUR_USERNAME** with your africastalking username
        * add your country code as a prefix in RECIPIENT`S_NUMBER like '+254712345678' 
    ```
    
    var options = {
    apiKey: 'YOUR_API_KEY',
    username: 'YOUR_USERNAME',
    format: 'json'
       };
        
    var AfricasTalking = require('africastalking')(options);
    
    var airtime = AfricasTalking.AIRTIME;

    var recipients =[{'phoneNumber':'RECIPIENT`S_NUMBER', 'amount':'KES XX'}];
  
    airtime.send(recipients);
    
    
    ```
    
2. switch to the terminal and run ```node .js``
