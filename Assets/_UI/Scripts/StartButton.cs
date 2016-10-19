using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class StartButton : MonoBehaviour,IPointerClickHandler
    {
        public ChoosePlayerPanel ChoosePlayerPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            //激活选择游戏对象面板
            ChoosePlayerPanel.gameObject.SetActive(true);
        }
    }

}
