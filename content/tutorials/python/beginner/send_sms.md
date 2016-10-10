### Intro to sending sms using Python

- gateway instance, action -send message (method)


```python
# import our API wrapper
from africastalking.AfricasTalkingGateway import AfricasTalkingGateway

# instantiate the gateway class
gateway = AfricasTalkingGateway("some-username", "some-apikey")

# send message using by calling the sendMessage method on our API
gateway.sendMessage('+254701XXXXXX', "Hi, I'm texting")


# go to intermediate
