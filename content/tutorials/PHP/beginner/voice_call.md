## Making a call
#####You will require
-------------------
> Africastalking Gateway class,Username and Apikey. 
>Also you will require to create an Africa's Talking voice number [here]( https://account.sandbox.africastalking.com/voice/create)

-The voice number will be your default caller number That is it is going to be used when you are making outgoing call and also for receiving incoming calls

```php
<?php
//gateway class
require_once('AfricasTalkingGateway.php');

//login credatials
$username   = "Username eg ripper";
$apikey     = "APIKey";

// Specify your Africa's Talking phone number in a 12 digit

  // Make the call
  //the first your Africa's Talking phone number the second is the numbers you want to call
  //Both should be in a 12 digit format
$gateway->call("+254711XXX045", "+254722XXXYYY");



?>