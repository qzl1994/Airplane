using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class ExitButton : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            //退出应用程序
            Application.Quit();
        }
    }
}

