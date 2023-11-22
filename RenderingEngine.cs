using System;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates {
    public class RenderingEngine {
        public void StartGame() {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals");
        }
        public void GameOver() {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}