using UnityEngine;

//单例
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    protected static T _instance;

    //得到单例对象
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
