using UnityEngine;
using System.Collections;

namespace Game
{
    public class Move : MonoBehaviour
    {
        public Vector3 Speed;

        void Update()
        {
            transform.Translate(Speed * Time.deltaTime);
        }
    }
}

