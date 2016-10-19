using UnityEngine;
using GameClient;

namespace Game
{
    public class GameManager : Singleton<GameManager>
    {
        public Transform SpawnPos;

        void Start()
        {
            var playerData = Client.ins.Game.ChoosedPlayer;//得到选择对象的数据
            var perfab = Resources.Load<GameObject>(playerData.Prefab);//加载预设体
            //生成玩家对象
            var player = ((GameObject)Instantiate(perfab, SpawnPos.position, SpawnPos.rotation)).GetComponent<Player>();
            //初始化数据
            player.Init(playerData);
        }
    }
}
