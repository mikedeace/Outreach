```python
# give us a HTTP endpoint which can receive a POST request
# this is a simple Flask setup, with a function based view.

# be careful of the / slash at the end of the route - it does not exist
@app.route('/api/airtime/dlr', methods=['POST'])
def airtime_dlr_callback():
    # Reads the variables sent via POST from our gateway
    _from = request.values.get('from', None)
    to    = request.values.get('to', None)
    text  = request.values.get('text', None)
    date  = request.values.get('date', None)
    id_   = request.values.get('id', None)

    # update db or some sort of operation
    print(_from, to, text, date, id_)

    resp = make_response('OK', 200)
    resp.headers['Content-Type'] = 'text/plain'
    return resp
```
