using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Score : MonoBehaviour
    {
        private int _score;
        public Text text;

        void Start()
        {
            EventManager.ins.OnDestroyEnemy += enemy =>
            {
                _score += enemy.Score;
                text.text = _score.ToString();
            };
        }
    }
}

