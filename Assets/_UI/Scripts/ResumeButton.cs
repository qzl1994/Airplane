using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class ResumeButton : MonoBehaviour, IPointerClickHandler
    {
        public GameObject PauseDialog;

        public void OnPointerClick(PointerEventData eventData)
        {
            Time.timeScale = 1.0f;//恢复时间缩放
            PauseDialog.SetActive(false);//停用暂停面板
        }
    }
}
