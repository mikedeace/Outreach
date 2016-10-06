```python
# Specify an array of dicts to hold the recipients and the amount to send
recipients = [{"phoneNumber" : "+2547XXYYYZZZ", 
               "amount"      : "KES XX"}]

# Create a new instance of our awesome gateway class
gateway    = AfricasTalkingGateway(username, apikey)

try:
    # Thats it, hit send and we'll take care of the rest. 
    responses = gateway.sendAirtime(recipients)
    for response in responses:
        print "phoneNumber=%s; amount=%s; status=%s; discount=%s; requestId=%s" %(response['phoneNumber'],
                        response['amount'],
                        response['status'],
                        response['discount']
                        response['requestId'])

except AfricasTalkingGatewayException, e:
    print 'Encountered an error while sending airtime: %s' % str(e)
```
