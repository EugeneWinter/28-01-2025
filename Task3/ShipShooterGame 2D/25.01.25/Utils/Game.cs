using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._25.Utils
{
    public class Game
    {
        private GameEngine gameEngine;

        public Game() 
        {
            gameEngine = new GameEngine();
        }

        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру");
            Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить");
            Console.ReadKey();
            gameEngine.Run();
        }
    }
}
