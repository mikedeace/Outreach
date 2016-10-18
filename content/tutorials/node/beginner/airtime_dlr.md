
```node
'use strict';

exports.airtimeDLR = function(req, res) {
	var status    = req.body.status
  var requestId = req.body.requestId

	console.log(messageId, status);

  // save to db on table airtime__status ?
	res.send(200); // return 200 
};
```
