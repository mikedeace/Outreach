### require Africastalking module

- npm install --save africastalking
- set up your name on an ```options``` object
- require the sms module
- send sms


### Code sample

```node
var options = {
  apiKey: 'YOUR_API_KEY',
  username: 'YOUR_USERNAME',
  format: 'json' // or xml
};

var AfricasTalking = require('africastalking')(options);

var sms = AfricasTalking.SMS;

sms.send(opts)
     .then(function(s) {
       console.log(s);
     })
     .catch(function (error) {
       console.log(error);
     });
```
