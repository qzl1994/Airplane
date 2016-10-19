using UnityEngine;

public class DontDestroy : MonoBehaviour {

	void Start () {//场景切换后不被销毁
        DontDestroyOnLoad(gameObject);
	}   
}
