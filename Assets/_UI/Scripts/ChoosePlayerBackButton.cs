using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class ChoosePlayerBackButton : MonoBehaviour,IPointerClickHandler
    {
        public ChoosePlayerPanel ChoosePlayerPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            this.ChoosePlayerPanel.gameObject.SetActive(false);
        }
    }
}
