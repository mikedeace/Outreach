## Making a call
#####You will require
-------------------
> *Africastalking Gateway class,Username and Apikey. 

```php
<?php
//gateway class
require_once('AfricasTalkingGateway.php');

//login credatials
$username   = "Username eg ripper";
$apikey     = "APIKey";

// Specify your Africa's Talking phone number in a 12 digit
$from = "+254711XXX045";

// Specify the numbers that you want to call to in a comma-separated list
// Please ensure you include the country code (+254 for Kenya in this case)
$to   = "+254722XXXYYY,+254733YYYZZZ";

// Any gateway errors will be captured by our custom Exception class below, 
// so wrap the call in a try-catch block
try 
{
  // Make the call
  $results = $gateway->call($from, $to);

  //This will loop through all the numbers you requested to be called
  foreach($results as $result) {
    //Only status "Queued" means the call was successfully placed
    echo $result->status;
    echo $result->phoneNumber;
    echo "<br/>";
  }
        
}
catch ( AfricasTalkingGatewayException $e )
{
  echo "Encountered an error while making the call: ".$e->getMessage();
}


?>