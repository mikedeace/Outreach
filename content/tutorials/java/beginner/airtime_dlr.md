- register a [callback](https://en.wikipedia.org/wiki/Callback_(computer_programming)) url [here](https://account.africastalking.com/airtime/callback)
- paste this code in your AirtimeSend.java class file and run it

```
import static spark.Spark.post;

public class AirtimeStatus {
    public static void main(String[] args) {

        post("/airtimeNotification", (request, response) -> {
            String status = request.params("status");
            String requestId = request.params(" requestid");

            return "The status is " + status + "and the requestId is " + requestId;
        });
    }
}

```
