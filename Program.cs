using System; 

namespace EventsAndMulticastDelegates {
    class Program {
        static void Main(string[] args) {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("Fastman");
            Player player2 = new Player("Slowman");
            
            GameEventManager.TriggerGameStart(); 

            System.Console.WriteLine("Game is Running... press any key to end game");
            
            Console.Read();

            GameEventManager.TriggerGameEnd();

            

        }
    }
}
