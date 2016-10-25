- register a [callback](https://en.wikipedia.org/wiki/Callback_(computer_programming)) url [here](https://account.africastalking.com/ussd/callback)
- Make sure you request a short code as well.

- ensure that you have these dependencies
```
compile group: 'com.sparkjava', name: 'spark-core', version:'2.5'
compile group: 'org.slf4j', name: 'slf4j-simple', version:'1.7.21'
```
   
- paste this code in your AirtimeSend.java class file and run it

```

import spark.Request;
import spark.Response;

import static spark.Spark.*;

public class Ussd {
    public static void main(String[] args) {
        port(9000);
        threadPool(400);

        post("/", (Request req, Response res) -> {
            String phoneNumber = req.queryParams("phoneNumber");
            String sessionId = req.queryParams("sessionId");
            String serviceCode = req.queryParams("serviceCode");
            String text = req.queryParams("text");

            System.out.println(phoneNumber + " " + sessionId + " " + serviceCode+" "+text);

            if (text == " ") {
                res.body(  "CON" +
                        "1. check phoneNumber" +
                                "2. check account" );
               
            } else if (text == "1") {
                res.body("END your account number is 123");
                return "hey";
            } else if (text == "2") {
                res.body("END your phone number is 075637");
            }
            res.header("content-type", "text/plain");
            

            return res.body();
        });



    }
}

```
