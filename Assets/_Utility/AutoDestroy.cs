using UnityEngine;
using System.Collections;

namespace Game
{
    public class AutoDestroy : MonoBehaviour
    {

        public float time;

        private float _timer;

        void Update()
        {
            _timer += Time.deltaTime;
            if(_timer >= time)
            {
                Destroy(gameObject);
            }
        }
    }
}

