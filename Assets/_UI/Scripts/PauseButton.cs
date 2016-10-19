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
            Time.timeScale = 0f;//时间缩放设为0，暂停游戏
            PauseDialog.SetActive(true);//激活暂停面板
        }
    }
}

