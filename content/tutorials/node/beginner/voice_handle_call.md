### require Africastalking module

- npm install --save africastalking
- set up your API username and API_KEY on an ```options``` object
- setup a POST function to handle the call


```node
'use strict';

var options = {
    apiKey: 'YOUR_API_KEY',
    username: 'YOUR_USERNAME',
    format: 'json' // or xml
};

var AfricasTalking = require('africastalking')(options);


exports.voice = function(req, res) {
  console.log(req.body);
  var message = "";

  var callerNumber = req.body.callerNumber;
  console.log(callerNumber);

  var response = "<Response><Say>Hey, thank you for calling in.</Say></Response>";

	res.setHeader('Content-Type', 'text/plain');
	res.send( response);
};
```
