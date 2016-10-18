﻿using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    protected static T _instance;

    public static T ins
    {
        get
        {
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        _instance = (T)this;
    }

    protected virtual void OnDestroy()
    {
        _instance = null;
    }
}
