Importing the helper gateway
```python
from AfricasTalkingGateway import (AfricasTalkingGateway, AfricasTalkingGatewayException)

```
Add the number you are sending to

```python
to = "+2547xxxxxxxx"
message = "If this works you are a genuis..."

gateway = AfricasTalkingGateway("your_username", "your_api_key")

results = gateway.sendMessage (to, message)

print results

```
