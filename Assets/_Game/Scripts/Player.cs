using UnityEngine;
using System.Collections;
using GameClient;

namespace Game
{
    public class Player : MonoBehaviour
    {
        //子弹预制体
        public GameObject BulletPrefab;

        [System.NonSerialized]
        public float MoveSpeed = 1;         //移动差值
        [System.NonSerialized]
        public float ShootInterval = 0.2f;  //射击间隔
        [System.NonSerialized]  
        public float Power = 10;            //攻击力

        void Start()
        {
            StartCoroutine(Shoot());    //开启协程，自动发射子弹
        }

        IEnumerator Shoot()
        {
            while (true)
            {
                yield return new WaitForSeconds(ShootInterval);

                var bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Bullet>().Power = Power;
            }
        }

        //初始化玩家数据
        public void Init(PlayerData data)
        {
            Power = data.Power;
            ShootInterval = data.ShootInterval;
            MoveSpeed = data.MoveSpeed;
        }

        void Update()
        {
            //得到鼠标位置
            var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Z轴为0
            targetPos.z = 0f;
            //对象按速度移动到鼠标位置
            transform.position = Vector3.MoveTowards(transform.position, targetPos, MoveSpeed * Time.deltaTime);
        }

    }
}

