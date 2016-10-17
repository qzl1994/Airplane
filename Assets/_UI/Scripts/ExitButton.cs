using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class ExitButton : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Application.Quit();
        }
    }
}

