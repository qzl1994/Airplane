using UnityEngine;
using UnityEngine.EventSystems;
using System;

namespace UI
{
    public class StartButton : MonoBehaviour,IPointerClickHandler
    {
        public ChoosePlayerPanel ChoosePlayerPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            this.ChoosePlayerPanel.gameObject.SetActive(true);
        }
    }

}
