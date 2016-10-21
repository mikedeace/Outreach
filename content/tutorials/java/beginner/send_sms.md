- Make sure your build.gradle file has the following ```json``` dependency
    ```
    compile group: 'org.json', name: 'json', version: '20160810'
    ```
    
- Download the ```africastalking gateway class``` [here](http://docs.africastalking.com/smslibraries/java)
- Include it in your src/main/java folder
- paste this code in your Send_SMS.java class 
    - include your username, apikey, recipient's phone number and message as shown in the variables

```

import org.json.JSONArray;
import org.json.JSONObject;


public class SendSms {

    public static String username = "MyUsername";
    public static String apiKey = "MyAPIKey";
    public static String recipients = "+254711XXXYYY,+254733YYYZZZ";
    public static String message = "We are lumberjacks. We code all day and sleep all night";



    public static void main(String[] args_) {
        AfricasTalkingGateway gateway = new AfricasTalkingGateway(username, apiKey);


        try {
            JSONArray results = gateway.sendMessage(recipients, message);

            for (int i = 0; i < results.length(); ++i) {
                JSONObject result = results.getJSONObject(i);
                System.out.print(result.getString("status") + ","); // status is either "Success" or "error message"
                System.out.print(result.getString("number") + ",");
                System.out.print(result.getString("messageId") + ",");
                System.out.println(result.getString("cost"));
            }


        } catch (Exception e) {
            System.out.println("Encountered an error while sending " + e.getMessage());
        }

    }
}


```
