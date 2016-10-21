- paste this code in your VoiceCall.java class file and run it
    - include your username, apikey, (from)your africastalking virtual number and (to)recipient's phone number as shown in the variables


```

import org.json.JSONArray;
import org.json.JSONObject;


public class VoiceCall {

    public static String username = "MyUsername";
    public static String apiKey = "MyAPIKey";
    public static String from = "+254711XXXYYY";    //your africastalking phone number
    public static String to = "+254711XXXYYY";   // number you would like to call


    public static void main(String[] args_) {
        AfricasTalkingGateway gateway = new AfricasTalkingGateway(username, apiKey);

        //
        try {
            JSONArray results = gateway.call(from, to);
            // print the gateway`s response

            int len = results.length();
            for (int i = 0; i < len; i++) {
                JSONObject result = results.getJSONObject(i);
                //Only status "Queued" means the call was successfully placed
                System.out.print(result.getString("status") + ",");
                System.out.print(result.getString("phoneNumber") + "\n");
            }
            
        } catch (Exception e) {
            System.out.println("Encountered an error" + e.getMessage());
        }

    }
}

```
