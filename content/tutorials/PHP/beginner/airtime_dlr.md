##Get balance

```php
<?php
require_once('AfricastalkingGateway');


$gateway    = new AfricasTalkingGateway("MyAfricasTalkingUsername", "MyAfricasTalkingApiKey");

 $data = $gateway->getUserData();
  echo "Balance: " . $data->balance."\n";
  
  ?>