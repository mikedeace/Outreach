### Set up

-To set up php all that is required is to install any apache webserver in your system

>Install MAMP for Mac, WAMP for Windows and LAMP for Linux.
>MAMP has GUI, where you can do basic config, such as change running port.
>WAMP allows you to do lot of configuration from the GUI, e.g. turn on modules.

###Test that you have everything
======================================

After you have completed every step in the Getting_started.md, we need to test everything.

-Download the Sandbox App from Google store [here](http://www.apk16.com/download/africastalking.nerdbox.activity.html) or

-Visit the web application [here](https://sandbox.africastalking.com)

-Register with your phone number on the application to begin using the sandbox

-Create a folder to test your application and call it what you like for example

>> 1. Windows ``C:\Users\YourUsername\Documents\ATPHP``
>> 2. Linux ``$mkdir ATPHP``


-Copy / transfer the gateway class downloaded from the ``Getting_started.md`` to this folder 

-Create a php file for example ``sms.php`` and copy paste this code 

```php

<?php
require_once('AfricasTalkingGateway.php');

$gateway    = new AfricasTalkingGateway("Username eg ripper", "APIKey");

$gateway->sendMessage("+254733YYYZZZ","Hey Stranger!!!!");

?>

```

- Start the apache server you have installed and load sms.php

- If everything is fine,+254733YYYZZZ will receive Hey stranger text