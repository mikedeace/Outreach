```java
// Make sure the downloaded jar file is in the classpath
import org.json.*;
import com.org.AfricasTalkingGateway.*;


public class TestCalling {
  public static void main(String[] args) {
    // Specify your login credentials
    String username = "MyAfricasTalking_Username";
    String apiKey   = "MyAfricasTalking_APIKey";

    // Specify your Africa's Talking phone number in international format
    String from = "+254711082XXX";

    // Specify the numbers that you want to call to in a comma-separated list
    // Please ensure you include the country code (+254 for Kenya in this case)
    String to   = "+254711XXXYYY,+254733YYYZZZ";

    // Create a new instance of our awesome gateway class
    AfricasTalkingGateway gateway  = new AfricasTalkingGateway(username, apiKey);

    // Any gateway errors will be captured by our custom Exception class below,
    // so wrap the call in a try-catch block
    try {
      JSONArray results = gateway.call(from, to);
      int len = results.length();
      for(int i = 0; i < len; i++) {
      JSONObject result = results.getJSONObject(i);

      //Only status "Queued" means the call was successfully placed
      System.out.print(result.getString("status") + ",");
      System.out.print(result.getString("phoneNumber") + "\n");
      }
      // Our API will now contact your callback URL once the recipient answers the call!
    }

    catch (Exception e) {
    System.out.println("Encountered an error" + e.getMessage());
    }

  }
}
