using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class TourAgency
    {
        // Поля класса
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string INN { get; set; }
        public double CurrentYearProfit { get; set; }

        // Метод для инициализации полей класса
        public void Initialize(string name, int yearFounded, string inn, double currentYearProfit)
        {
            Name = name;
            YearFounded = yearFounded;
            INN = inn;
            CurrentYearProfit = currentYearProfit;
        }

        // Метод для получения информации о фирме
        public void GetInfo()
        {
            Console.WriteLine($"Название фирмы: {Name}");
            Console.WriteLine($"Год основания: {YearFounded}");
            Console.WriteLine($"ИНН: {INN}");
            Console.WriteLine($"Прибыль за текущий год: {CurrentYearProfit}");
        }
    }
}

