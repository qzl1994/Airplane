using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

namespace Game
{
    public class ResumeButton : MonoBehaviour, IPointerClickHandler
    {
        public GameObject PauseDialog;

        public void OnPointerClick(PointerEventData eventData)
        {
            Time.timeScale = 1.0f;
            PauseDialog.SetActive(false);
        }
    }
}
