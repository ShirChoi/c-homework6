using System;

namespace Problem1 {
    class Hero {
        private string _name;
        private int _healthPoints;
        private string _information;

        public Hero() {
            _name = "Noname";
            _healthPoints = 0;
            _information = "None";
        }

        public Hero(string name, int healthPoints, string information) {
            _name = name;
            _healthPoints = healthPoints;
            _information = information;
        }

        public void PrintInfo() {
            Console.WriteLine($"Имя: {_name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Здоровье: {_healthPoints}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Информация: {_information}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Program {
        static void Main(string[] args) {
            Hero hero1 = new Hero("Артес", 160, "Мощный паладин");
            Hero hero2 = new Hero("Лич", 80, "Тёмный волшебник");

            hero1.PrintInfo();
            System.Console.WriteLine();
            hero2.PrintInfo();
        }
    }
}
