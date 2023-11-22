using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates {
    class GameEventManager {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;
        public static void TriggerGameStart() {
            if (OnGameStart != null) {
                Console.WriteLine("The game has started");
                OnGameStart();
            }
        }
                public static void TriggerGameEnd() {
            if (OnGameOver != null) {
                Console.WriteLine("Game is ending");
                OnGameOver();
            }
        }
    }
}