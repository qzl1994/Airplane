using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameClient;
using System.Collections;
using System;

namespace UI
{
    public class ChoosePlayerPanel : MonoBehaviour
    {
        public GameObject PlayerItemPrefab;
        public GridLayoutGroup Grid;
        public ScrollRect Scroll;

        private RectTransform _gridRecTransform;
        private List<PlayerChooseItem> _items;
        private float _widthPerItem;

        void Awake()
        {
            _items = new List<PlayerChooseItem>();
            _gridRecTransform = Grid.GetComponent<RectTransform>();
            _widthPerItem = Scroll.content.rect.width;
        }

        void OnEnable()
        {
            var playerDatas = Client.ins.Player.PlayerDatas;
            foreach(var playerData in playerDatas)
            {
                
            }
        }

        void OnDisable()
        {
            foreach(var item in _items)
            {
                Destroy(item.gameObject);
            }
            _items.Clear();
        }
        
        public void InsertItem(PlayerData data)
        {
            PlayerChooseItem item = Instantiate(PlayerItemPrefab).GetComponent<PlayerChooseItem>();
            
        }
    }
}

