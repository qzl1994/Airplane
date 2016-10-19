using UnityEngine;

namespace Game
{
    public class Move : MonoBehaviour
    {
        public Vector3 Speed;

        //每帧向Speed方向移动相应距离
        void Update()
        {
            transform.Translate(Speed * Time.deltaTime);
        }
    }
}

