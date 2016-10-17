1. Handling a voice call requires the use of functions such as **say**, **play**, **redirect**
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
    
    // Handle the call here
    voice.say('Hello '+username', Welcome', voice='woman');
```

You could altenatively play a tune or recording by providing a url 
```
voice.say('listen to this tune', play='http://www.location_of_voice.com');
```
