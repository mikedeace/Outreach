##Send airtime
===============
```php
<?php

        require_once "AfricasTalkingGateway.php";

        //Create an instance of our awesome gateway class and pass your credentials
        $gateway = new AfricasTalkingGateway("MyafricastalkingUsername", "myAfricasTalkingAPIKey");
        
        $gateway->sendAirtime([{"amount":"KES 100", "phoneNumber":"+254711XXXYYY"},{"amount":"KES 100", "phoneNumber":"+254733YYYZZZ"}]);
   
  
?>