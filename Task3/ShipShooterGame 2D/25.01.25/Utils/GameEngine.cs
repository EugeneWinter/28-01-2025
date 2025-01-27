using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._25.Utils
{
    public class GameEngine
    {
        public int Position { get; set; }

        private Player _player;
        private List<Enemy> _enemies;
        private Random _random;
        private int _score;
        private int _misses;
        private int _enemiesCounter;

        public GameEngine()
        {
            _player = new Player();
            _enemies = new List<Enemy>();
            _random = new Random();
            _score = 0;
            _misses = 0;
            _enemiesCounter = 0;
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                DisplayStatus();
                HandleInput();
                UpdateEnemies();
                if (CheckGameOver())
                {
                    Console.Clear();
                    Console.WriteLine("Игра окончена! Ваш счёт: " + _score);
                    break;
                }
                Thread.Sleep(100);
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Счёт: {_score}"); 
            Console.WriteLine($"Промахи: {_misses} / 5");
            Console.Write("Корабль: ");
            for (int i = 0; i < 10; i++)
            {
                if (i == _player.Position)
                {
                    Console.Write("■");
                }
                else if (_enemies.Any(e => e.Position == i))
                {
                    Console.Write("▼");
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();
        }
        private void HandleInput()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.LeftArrow)
                {
                    _player.MoveLeft();
                }
                if (key == ConsoleKey.RightArrow)
                {
                    _player.MoveRight();
                }
                if (key == ConsoleKey.Spacebar)
                {
                    Shoot();
                }
            }
        }
        private void Shoot()
        {
            bool hit = false;
            for (int i = _enemies.Count - 1; i >= 0; i--)
            {
                if (_enemies[i].Position == _player.Position)
                {
                    _enemiesCounter--;
                    _enemies.RemoveAt(i);
                    _score += 10;
                    Console.WriteLine("Разнос!");
                    hit = true;
                    break;

                }
            }
            if (!hit)
            {
                _misses++;
                Console.WriteLine("Промах!");
            }
               
                
        }
        private void UpdateEnemies()
        {
            if (_random.Next(0, 10) < 3)
            {
                var position = _random.Next(0, 10);
                if (!_enemies.Any(e => e.Position == position))
                {
                    _enemies.Add(new Enemy(position));
                    _enemiesCounter++;
                }
            }
        }
        private bool CheckGameOver()
        {
            return _enemiesCounter >= 10 || _misses >= 5;
        }
    }
}
