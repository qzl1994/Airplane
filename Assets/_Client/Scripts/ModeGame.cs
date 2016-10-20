using UnityEngine;
using System;

namespace GameClient
{
    public class ModeGame : MonoBehaviour
    {
        [NonSerialized]
        public PlayerData ChoosedPlayer;

        public void StartGame()
        {
#pragma warning disable CS0618 // 类型或成员已过时
            Application.LoadLevel("Game");
#pragma warning restore CS0618 // 类型或成员已过时
        }
    }
}

