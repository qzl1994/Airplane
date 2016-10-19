using UnityEngine;
using GameClient;

namespace Game
{
    public class EnemySpawn : MonoBehaviour
    {

        public float RandomRange = 10f;//随机生成的范围
        public float Interval;   //生成间隔

        private Timer timer;

        void Start()
        {
            timer = new Timer(Interval, () =>   //匿名函数
            {
                //得到x轴上的随机位置
                var pos = transform.position;
                pos.x += Random.Range(0f, RandomRange);

                //随机得到一个敌人数据
                var enemyDatas = Client.ins.Enemy.EnemyDatas;
                var enemyData = enemyDatas[Random.Range(0, enemyDatas.Length)];

                //生成敌人
                var enemyGo = (GameObject)Instantiate(Resources.Load(enemyData.Prefab), pos, Quaternion.Euler(0f, 0f, 180f));
                var enemy = enemyGo.GetComponent<Enemy>();
                enemy.Init(enemyData);
            });
        }

        void Update()
        {
            timer.Update();
        }
    }
}

