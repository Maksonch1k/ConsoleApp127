using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание коллекции объектов класса "Туристическая фирма"
            List<TourAgency> tourAgencies = new List<TourAgency>();

            // Добавление объектов в коллекцию
            tourAgencies.Add(new TourAgency { Name = "Фирма1", YearFounded = 2000, INN = "1234567890", CurrentYearProfit = 100000 });
            tourAgencies.Add(new TourAgency { Name = "Фирма2", YearFounded = 1995, INN = "0987654321", CurrentYearProfit = 150000 });
            tourAgencies.Add(new TourAgency { Name = "Фирма3", YearFounded = 2010, INN = "5678901234", CurrentYearProfit = 80000 });

            // Получение информации о фирме по ее названию
            string firmName = "Фирма1";
            TourAgency foundFirm = tourAgencies.FirstOrDefault(firm => firm.Name == firmName);
            if (foundFirm != null)
            {
                Console.WriteLine($"ИНН фирмы '{firmName}': {foundFirm.INN}");
                Console.WriteLine($"Прибыль фирмы '{firmName}' за текущий год: {foundFirm.CurrentYearProfit}");
            }
            else
            {
                Console.WriteLine($"Фирма с названием '{firmName}' не найдена.");
            }

            // Нахождение суммарной прибыли всех фирм
            double totalProfit = tourAgencies.Sum(firm => firm.CurrentYearProfit);
            Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit}");

            // Нахождение фирмы с наибольшей прибылью и размера этой прибыли
            TourAgency maxProfitFirm = tourAgencies.OrderByDescending(firm => firm.CurrentYearProfit).First();
            Console.WriteLine($"Фирма с наибольшей прибылью: {maxProfitFirm.Name}, прибыль: {maxProfitFirm.CurrentYearProfit}");

            // Удаление информации об обанкротившейся фирме
            string bankruptFirmName = "Фирма3";
            TourAgency bankruptFirm = tourAgencies.FirstOrDefault(firm => firm.Name == bankruptFirmName);
            if (bankruptFirm != null)
            {
                tourAgencies.Remove(bankruptFirm);
                Console.WriteLine($"Фирма '{bankruptFirmName}' удалена из коллекции.");
            }
            else
            {
                Console.WriteLine($"Фирма с названием '{bankruptFirmName}' не найдена.");
            }

            // Добавление информации о новой фирме
            tourAgencies.Add(new TourAgency { Name = "Новая фирма", YearFounded = 2022, INN = "2468135790", CurrentYearProfit = 120000 });

            // Сортировка коллекции по размеру прибыли за текущий год
            tourAgencies = tourAgencies.OrderByDescending(firm => firm.CurrentYearProfit).ToList();

            // Вывод информации о всех фирмах после сортировки
            Console.WriteLine("Информация о фирмах после сортировки:");
            foreach (var firm in tourAgencies)
            {
                firm.GetInfo();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
    }

