 ```cs

    using System;

    class MainClass
    {
        
        static public void testCalling ()
        {

            // Create a new instance of our awesome gateway class
            AfricasTalkingGateway gateway = new AfricasTalkingGateway ("MyAfricasTalking_Username", "MyAfricasTalking_APIKey");

            // Specify your Africa's Talking phone number in international format the first parameter is the number where its from and the second parameter is to
            gateway.call("+254711082XYZ", "+254711XXXYYY");
        }
    }