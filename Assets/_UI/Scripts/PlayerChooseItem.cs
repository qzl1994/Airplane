using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using GameClient;

namespace UI
{
    public class PlayerChooseItem : MonoBehaviour,IPointerClickHandler
    {

        public Text NameLabel;
        private PlayerData data;

        public void Init(PlayerData data)
        {
            this.data = data;
            NameLabel.text = data.Name;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Client.ins.Game.ChoosedPlayer = data;

            Client.ins.Game.StartGame();
        }
    }
}

