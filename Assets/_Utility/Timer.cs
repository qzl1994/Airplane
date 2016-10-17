using UnityEngine;
using System;

public class Timer {

    private float _timer;
    private Action _action;
    private bool _timeScale;

    public float time { get; set; }

    public Timer(float time,Action action,bool timeScale = true)
    {
        _timer = 0f;
        this._timer = time;
        _action = action;
        _timeScale = timeScale;
    }
	
    public void Update()
    {
        _timer += _timeScale ? Time.deltaTime : Time.unscaledDeltaTime;
        if(_timer >= time)
        {
            _timer = 0f;
            _action();
        }
    }
}
