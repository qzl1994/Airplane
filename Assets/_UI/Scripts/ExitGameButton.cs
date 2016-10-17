using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class ExitGameButton : MonoBehaviour,IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Application.LoadLevel("Menu");
            Time.timeScale = 1f;
        }
    }
}

