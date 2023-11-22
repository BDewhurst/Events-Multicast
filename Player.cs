using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates {
    public class Player {
        public string PlayerName {get; set;}
    public Player(string name) {
        this.PlayerName = name;
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;
    }
    private void StartGame() {
        System.Console.WriteLine($"Spawning {PlayerName}");
    }

    private void GameOver() {
        System.Console.WriteLine($"Removing {PlayerName}");
    }
    }
}