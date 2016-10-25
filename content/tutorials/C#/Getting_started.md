#### Dependencies

- Creating Africa's Talking [Sandbox](https://account.sandbox.africastalking.com/login?page=/ ) account or [live](https://www.africastalking.com/) account
- Take note of your africa's talking live account username and sandbox account user name
- Get [Sandbox API_KEY](https://account.sandbox.africastalking.com/settings/apikey) / [Live API_KEY](https://account.africastalking.com/settings/apikey)
- [Download](http://docs.africastalking.com/smslibraries/c#) the C# gateway class
- install visual studio ``preferably Microsoft Visual Studio community`` but others would work as well

- After installation Open visual studio, and create a new console project 
- copy this

```cs

 using System;

    class MainClass
    {
        static public void Main (){
            
            // Create a new instance of our awesome gateway class
            AfricasTalkingGateway gateway = new AfricasTalkingGateway ("MyAfricasTalkingUsername", "MyAfricasTalkingAPIKey");

            gateway.sendMessage ("+254711XXXYYY", "Hi Stranger");
        }
    }

```

- Add the Africastalking gateway 
>> ```On the solution Explore right click on the name of your project then select add ,which will give you an option to add existing item or new item, click on the existing item``` Or simply click ```Shift+Alt+A```

- On the windows Explorer select ```AfricasTalkingGateway.cs```

>>> To help decode JSON responses, you will need to add a reference to System.Web.Extensions and System.Microsoft.CSharp

##### STEPS TO ADD
---------------------
- First:- Right click your project select properties,
Change your target Framework to ```Net Framework 3.5 ``` and above. Save and close the refrence tab

- Second:-Right click on the refrence Item in your Solution explorer "usually but NOT ALWAYS found on the right hand side"
choose Add refrence
In the .Net tab scroll down to System.Web, System.Web.Extensions and System.Microsoft.CSharp and Add them

