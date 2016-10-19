using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class ChoosePlayerBackButton : MonoBehaviour,IPointerClickHandler
    {
        public ChoosePlayerPanel ChoosePlayerPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            ChoosePlayerPanel.gameObject.SetActive(false);//停用选择玩家对象面板
        }
    }
}
