# create an instance of the AT gateway class
# define apikey and username
# Specify your Africa's Talking phone number in international format

```python
callFrom = "+254711082XYZ"

# Specify the numbers that you want to call to in a comma-separated list
# Please ensure you include the country code (+254 for Kenya in this case, +256 Uganda)
callTo   = "+254711XXXYYY,+254733YYYZZZ"

# Create a new instance of our awesome gateway class
gateway  = AfricasTalkingGateway(username, apikey)

try:
    # Make the call
    results = gateway.call(callFrom, callTo)

    for result in results:
        # Only status "Queued" means the call was successfully placed
        print "Status : %s; phoneNumber : %s " % (result['status'], 
                                result['phoneNumber'])

    # Our API will now contact your callback URL once recipient answers the call!
except AfricasTalkingGatewayException, e:
    print 'Encountered an error while making the call: %s' % str(e)
```
