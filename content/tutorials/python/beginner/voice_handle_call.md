#### Handling a voice call

Here we receive POST params sent to our API when a call is made to our virtual number.
This is captured using the ```request``` object in Flask.

We then return an ```XML``` string with the action we want performed when the call is active.

```python

@app.route('/api/voice/callback/', methods=['POST'])
def voice_callback():
    if request.method == 'POST':

        is_active     = request.values.get('isActive', None)
        caller_number = request.values.get('callerNumber', None)

        response = '<Response>' \ +
                      '<Say> Hello, welcome to the test site. your number is {}</Say>' \ +
                   '</Response>'.format(caller_number)
```
