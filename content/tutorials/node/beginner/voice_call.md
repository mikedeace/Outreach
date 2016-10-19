### require Africastalking module

- npm install --save africastalking
- set up your name on an ```options``` object
- require the voice module
- make a voice


```node
var AfricasTalking = require('africastalking')(options.AT);
var voice   = AfricasTalking.VOICE;

var options = {
    apiKey: 'YOUR_API_KEY',
    username: 'YOUR_USERNAME',
    format: 'json' // or xml
};

voice.call({
      callFrom: '+254711082XXX',
      callTo: '+254701XXXXXX'
    })
    .then(function(s) {
      console.log(s);
    })
    .catch(function(error) {
      console.log(error);
    });
```


### next we look at handling a call
