using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Game
{
    public class ExitGameButton : MonoBehaviour,IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
#pragma warning disable CS0618 // 类型或成员已过时
            //Application.LoadLevel("Menu");//加载菜单场景
#pragma warning restore CS0618 // 类型或成员已过时

            SceneManager.LoadScene("Menu");

            Time.timeScale = 1f;          //恢复时间缩放
        }
    }
}

