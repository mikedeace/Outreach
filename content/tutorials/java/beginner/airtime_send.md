
- paste this code in your AirtimeSend.java class file and run it
    - include your username, apikey,  (to)recipient's phone number and (amount)amount of airtime you would like to send (Minimum allowed is 10 shillings) as shown in the variables
    
```

import org.json.JSONArray;
import org.json.JSONObject;


public class AirtimeSend {

    private static String username = "MyUsername";
    private static String apiKey = "MyAPIKey";
    private static String to = "+254711XXXYYY";   // number you would like to send airtime to
    private static int amount = 10;


    public static void main(String[] args_) {

        JSONArray recipient = new JSONArray();
        recipient.put(new JSONObject().put("phoneNumber", to).put("amount", "KES "+ Integer.toString(amount) ));

        String recipientStringFormat = recipient.toString();

        AfricasTalkingGateway gateway = new AfricasTalkingGateway(username, apiKey);

        try {
            //That's it. Hit send and we will handle the rest
            JSONArray results = gateway.sendAirtime(recipientStringFormat);
            
            for (int i = 0; i < results.length(); i++) {
                
                JSONObject result = results.getJSONObject(i);
                
                System.out.println(result.getString("status"));
                System.out.println(result.getString("amount"));
                System.out.println(result.getString("phoneNumber"));
                System.out.println(result.getString("discount"));
                System.out.println(result.getString("requestId"));

                //Error message is important when the status is not Success
                System.out.println(result.getString("errorMessage"));
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
```
