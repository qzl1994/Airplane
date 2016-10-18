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
            Application.LoadLevel("Game");
        }
    }
}

