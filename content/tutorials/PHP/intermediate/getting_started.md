## Introduction

- A simple demo on USSD, messaging, airtime and Voice API's.

- To get started you require to install laravel ``version 5.3`` 

## Why laravel?
-------------------
- Well laravel is becoming the most porpular php framework avaliable and it helps in writing clean and reusable code to develop projects smoothly.

#### FOR EXAMPLE
- It provides

>> 1. Routing System: With Laravel, we can easily approach to routing. The route can be triggered in the application with good flexibility and control. To match the URL. 
>> 2. Artisan Console: Artisan is the command line interface in the laravel. Provides number of command while developing a web application.
>> 3. Http Middleware: Provide a convenient mechanism for filtering HTTP requests entering your application.

### How to use this demo

- If you have a basic idea about laravel you know the best place to get started is look at the routes
- There you will see 

```php

Route::group(['middleware' => ['web']], function () {
    //
});

Route::group(['prefix' => '/main/serve'], function () {
    Route::resource('/ussd', 'UssdController@index');
    Route::resource('/sms', 'UssdController@getSms');
    Route::resource('/call', 'UssdController@getCall');
    Route::resource('/airtime', 'UssdController@getAirtime');
});
```

- Which generates a URL to a named controller and the function named
- FOR EXAMPLE if you start your apache server and run "your localhost address"/main/serve/sms , this will send a simple message to the specified recipient

```php

public function getSms()
    {
            // if its part of the ussd replace the number with $phoneNumber    
            $recipient = "+254716XXXYYY";
            $message    = "Hi mr. In order to succeed, we must first believe that we can. 
            Read more at: http://www.brainyquote.com/quotes/topics/topic_motivational.html";
            // use your africastalking username and apikey
            $gateway    = new AfricasTalkingGateway($username, $apikey);
            $results = $gateway->sendMessage($recipient, $message);
        return $results;
    }

```

