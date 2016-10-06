```python
# give us a HTTP endpoint which can receive a POST request
# this is a simple Flask setup, with a function based view.

@app.route('/api/airtime/dlr/', methods=['POST'])
def airtime_dlr_callback():
    # Reads the variables sent via POST from our gateway
    _from = request.values.get('from', None)
    to = request.values.get('to', None)
    text = request.values.get('text', None)
    date = request.values.get('date', None)
    id_ = request.values.get('id', None)

    try:
        # update db or some sort of operation
        logging.info(_from, to, text, date, id_)

    except Exception as e:
        logging.error('Failed with - ', e)

    resp = make_response('Ok', 200)
    resp.headers['Content-Type'] = 'text/plain'
    resp.cache_control.no_cache = True
    return resp
```
