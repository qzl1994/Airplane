using System;

namespace Game
{
    public class EventManager : Singleton<EventManager>
    {
        //Action委托
        public Action<Enemy> OnDestroyEnemy;
    }
}

