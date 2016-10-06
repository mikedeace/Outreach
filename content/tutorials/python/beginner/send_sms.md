### some intro

```python
from africastalking.AfricasTalkingGateway import (AfricasTalkingGateway, AfricasTalkingGatewayException)

# Specify your login credentials
username = "MyAfricasTalkingUsername"
apikey   = "MyAfricasTalkingAPIKey"

# Please ensure you include the country code (+254 for Kenya in this case)
to      = "+254711XXXYYY,+254733YYYZZZ"

message = "I'm a lumberjack and it's ok, I sleep all night and I work all day"

# Create a new instance of our awesome gateway class
gateway = AfricasTalkingGateway(username, apikey)

try:
    # Thats it, hit send and we'll take care of the rest.

    results = gateway.sendMessage(to, message)

    for recipient in results:
        # status is either "Success" or "error message"
        print 'number=%s;status=%s;messageId=%s;cost=%s' %(recipient['number'],
                                                        recipient['status'],
                                                        recipient['messageId'],
                                                        recipient['cost'])
except AfricasTalkingGatewayException, e:
    print 'Encountered an error while sending: %s' % str(e)
```
