using UnityEngine;
using UnityEngine.EventSystems;
using System;

namespace Game
{
    public class PauseButton : MonoBehaviour, IPointerClickHandler
    {

        public GameObject PauseDialog;

        public void OnPointerClick(PointerEventData eventData)
        {
            Time.timeScale = 0f;
            PauseDialog.SetActive(true);
        }
    }
}

