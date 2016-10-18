### Introduction to sending a simple sms using PHP

```php
<?php
// include africastalking gateway 
require_once('AfricasTalkingGateway.php');

// specify username and apikey
$username   = "Username eg ripper";
$apikey     = "APIKey";

// include the numbers that you want to send sms to in a 12 digit format 
$recipients = "+254711xxxyyy,+254733YYYZZZ";

$message = "Hey Stranger!!!!";

// instantiate the gateway class
$gateway    = new AfricasTalkingGateway($username, $apikey);

// Any gateway error will be captured by our custom Exception class below,in tne try-catch block

try 
{ 
 
  $results = $gateway->sendMessage($recipients, $message);
      
  foreach($results as $result) {
    // status is either "Success" or "error message"
    echo " Number: " .$result->number;
    echo " Status: " .$result->status;
    echo " MessageId: " .$result->messageId;
    echo " Cost: "   .$result->cost."\n";
  }
}
catch ( AfricasTalkingGatewayException $e )
{
  echo "Encountered an error while sending: ".$e->getMessage();
}

?>