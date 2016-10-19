using System;

namespace Game
{
    public class EventManager : Singleton<EventManager>
    {
        public Action<Enemy> OnDestroyEnemy;
    }
}

