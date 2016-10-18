#importing the helper gateway
from AfricasTalkingGateway import (AfricasTalkingGateway, AfricasTalkingGatewayException)

#add the number you are sending to
to = "+2547xxxxxxxx"
message = "If this works you are a genuis..."

gateway = AfricasTalkingGateway("your_username", "your_api_key")

results = gateway.sendMessage (to, message)

print results
