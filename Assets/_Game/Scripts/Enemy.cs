using UnityEngine;
using GameClient;

namespace Game
{
    public class Enemy : MonoBehaviour
    {
        [System.NonSerialized]
        public float Life;      //生命值

        [System.NonSerialized]
        public int Score;     //分数

        //初始化生命值和分值
        public void Init(EnemyData data)
        {
            Life = data.Life;
            Score = data.Score;
        }

        //碰撞
        public void Hit(Bullet bullet)
        {
            Life -= bullet.Power;//生命值减去子弹的攻击力

            //生命值小于0，死亡
            if (Life <= 0)
            {
                if(EventManager.ins.OnDestroyEnemy != null)
                {
                    EventManager.ins.OnDestroyEnemy(this);
                }

                Destroy(gameObject);//销毁自己
            }
        }
    }
}

