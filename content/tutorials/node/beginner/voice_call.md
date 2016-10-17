##MAKING A CALL
1. run ```npm install init``` to start a project.
2. install dependencies by running ```npm install africastalking```
3. copy this code to a text editor and save to a file ``voice_call.js``, remember to enter your **api key**, **username**, your **africastalking virtual number**, and **recipient**
    ```
    var username = "your_AfricasTalkingUsername";
    var apiKey   = "your_AfricasTalkingAPIkey";
    var from = "AfricasTalkingPhoneNumber_that_you_requested"; //eg AT virtual number +254711082XXX
    var to   = "+254711XXXYYY,+254733YYYZZZ"; //the number you would like to call
    
    
    var options = {
        apiKey: apiKey,
        username: username,
        format: 'json'
    };
    
    var AfricasTalking = require('africastalking')(options);
    
    var voice = AfricasTalking.VOICE;
    
    var opts ={
        callFrom: from,
        callTo: to
    };
    
    voice.call(opts) ;

    ```
4. run ``` node voice_call.js```
