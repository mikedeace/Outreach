```python
@app.route('/api/voice/callback/', methods=['POST'])
def voice_callback():
    if request.method == 'POST':
        is_active = request.values.get('isActive', None)
        session_id = request.values.get('sessionId', None)
        caller_number = request.values.get('callerNumber', None)
        direction = request.values.get('direction', None)


```
