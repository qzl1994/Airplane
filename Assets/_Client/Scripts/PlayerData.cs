using System;

namespace GameClient
{
    [Serializable]
    public class PlayerData
    {
        public string Name;
        public float MoveSpeed;
        public float Power;
        public float ShootInterval;
        public string Prefab;
    }
}

