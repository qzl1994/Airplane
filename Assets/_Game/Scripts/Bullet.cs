using UnityEngine;

namespace Game
{
    public class Bullet : MonoBehaviour
    {
        //爆炸特效预设体
        public GameObject ExplosionEffect;

        [System.NonSerialized]
        public float Power; //子弹攻击力

        //触发
        void OnTriggerEnter(Collider other)
        {
            //碰到标签为Enemy的带有刚体的物体
            if(other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Enemy"))
            {
                //生成爆炸效果
                Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

                other.attachedRigidbody.GetComponent<Enemy>().Hit(this);//执行碰撞函数

                Destroy(gameObject);//销毁子弹
            }
        }
    }
}

