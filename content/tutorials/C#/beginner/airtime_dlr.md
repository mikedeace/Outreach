```cs


using System;

class MainClass
{
    static public void Main () {
        
    // Create a new instance of our awesome gateway class
            AfricasTalkingGateway gateway = new AfricasTalkingGateway ("MyAfricasTalking_Username", "MyAfricasTalking_APIKey");

            dynamic response = gateway.getUserData ();
            Console.WriteLine (response["balance"]);

    }
}