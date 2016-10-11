##Get balance

```php
<?php
require_once('AfricastalkingGateway');

$username   = "MyAfricasTalkingUsername";
$apikey     = "MyAfricasTalkingApiKey";

$gateway    = new AfricasTalkingGateway($username, $apikey);

try
{ 
  $data = $gateway->getUserData();
  echo "Balance: " . $data->balance."\n";
}
catch ( AfricasTalkingGatewayException $e )
{
  echo "Encountered an error while fetching user data: ".$e->getMessage()."\n";
}