using UnityEngine;

namespace Game
{
    public class AutoDestroy : MonoBehaviour    //自动销毁
    {

        public float time;  //自动销毁时间

        private float _timer;

        void Update()
        {
            _timer += Time.deltaTime;//计时
            if(_timer >= time)//时间到了之后销毁对象
            {
                Destroy(gameObject);
            }
        }
    }
}

