### require Africastalking module

- npm install --save africastalking
- set up your API username and APIKEY on an ```options``` variable
- require the ```airtime``` module
- send airtime


```node
'use strict';

var options = {
  apiKey: 'YOUR_API_KEY',
  username: 'YOUR_USERNAME',
  format: 'json' // or xml
};

var AfricasTalking = require('africastalking')(options.AT);

var airtime = AfricasTalking.AIRTIME;

var opts = { 'recipients': [{ "phoneNumber": '+254701435178', "amount": '10' }] };

airtime.send(opts)
	    .then(function(s) {
	    	console.log(s);
	    })
	    .catch(function (error) {
	    	console.log(error);
	    });
```


### Receiving delivery reports after sending airtime

- how do we know whether the airtime was sent successfully or not?
- We send a ```POST``` request after every send airtime event to a callback registered here <link>
