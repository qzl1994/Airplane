using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameClient;

namespace UI
{
    public class ChoosePlayerPanel : MonoBehaviour
    {
        public GameObject PlayerItemPrefab;//游戏对象预设体
        public GridLayoutGroup Grid;       //网格布局
        public ScrollRect Scroll;          //滚动组件

        private RectTransform _gridRecTransform;//矩形组件
        private List<PlayerChooseItem> _items;  //待选择游戏对象集合
        private float _widthPerItem;

        void Awake()
        {
            _items = new List<PlayerChooseItem>();
            _gridRecTransform = Grid.GetComponent<RectTransform>();
            _widthPerItem = Scroll.content.rect.width;
        }

        void OnEnable()
        {
            var playerDatas = Client.ins.Player.PlayerDatas;//得到玩家游戏对象信息
            foreach(var playerData in playerDatas) //得到每一个对象信息
            {
                InsertItem(playerData);//调用InsertItem()函数
            }
        }

        void OnDisable()
        {
            foreach(var item in _items)
            {
                Destroy(item.gameObject);//销毁每一个选择对象
            }
            _items.Clear();//清空集合
        }
        
        //向选择游戏对象集合中插入数据
        public void InsertItem(PlayerData data)
        {
            //待选择游戏对象
            PlayerChooseItem item = Instantiate(PlayerItemPrefab).GetComponent<PlayerChooseItem>();
            //根据传入参数初始化
            item.Init(data);
            //向集合中添加对象
            _items.Add(item);

            item.transform.SetParent(_gridRecTransform);//设置父节点
            item.transform.localScale = Vector3.one;    //设置大小

            //设置每个对象间距
            var rect = Scroll.content.rect;
            rect.width = _widthPerItem * _items.Count;
            Scroll.content.sizeDelta = new Vector2(rect.width, rect.height);
        }
    }
}

