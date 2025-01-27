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
                    CheckGameOver();
                    break;
                }
                Thread.Sleep(100);
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Награбленное золотишко: {_score}"); 
            Console.WriteLine($"Холостые выстрелы: {_misses} / 5");
            Console.WriteLine("Бескрайнее синее море: ");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x == _player.PositionX && y == _player.PositionY)
                    {
                        Console.Write("■");
                    }
                    else if (_enemies.Any(e => e.PositionX == x && e.PositionY == y))
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
                if (key == ConsoleKey.UpArrow)
                {
                    _player.MoveUp();
                }
                if (key == ConsoleKey.DownArrow)
                {
                    _player.MoveDown();
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
                if (_enemies[i].PositionX == _player.PositionX && _enemies[i].PositionY == _player.PositionY)
                {
                    _enemiesCounter--;
                    _enemies.RemoveAt(i);
                    _score += 10;
                    Console.WriteLine("Есть попадание, капитан!");
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
            if (_random.Next(0, 10) < 2)
            {
                var positionX = _random.Next(0, 10);
                var positionY = _random.Next(0, 10);
                if (!_enemies.Any(e => e.PositionX == positionX && e.PositionY == positionY))
                {
                    _enemies.Add(new Enemy(positionX, positionY));
                    _enemiesCounter++;
                }

            }
        }
        private bool CheckGameOver()
        {
            if (_enemiesCounter >= 20)
            {
                Console.Clear();
                Console.WriteLine("О нет, похоже ваш корабль окружили! Отправляйтесь в пасть морскому дьяволу!");
                Console.WriteLine($"Йо-хо-хо! Трюм разрывается от дублонов! Вы награбили {_score} золота");
                return true;
            };
            if (_misses >= 5)
            {
                Console.Clear();
                Console.WriteLine("О нет, похоже ваша команда команда больше не посадит вас за пушку. Отправляйтесь плясать на рее!");
                Console.WriteLine($"Йо-хо-хо! Трюм разрывается от дублонов! Вы награбили {_score} золота");
                return true;
            }
            else return false;
        }
    }
}
