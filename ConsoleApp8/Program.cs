using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            while (true)
            {
                Console.WriteLine(@"Выберите действие:
                1. Добавить велосипед;
                2. Добавить машину;
                3. Добавить грузовик;
                4. Показать все велосипеды;
                5. Показать все машины;
                6. Показать все грузовики;
                7. Выход.");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите цену велосипеда:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите макс. скорость велосипеда:");
                            int maxSpeed = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска велосипеда:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите кол-во пассажиров:");
                            int maxPassengers = Convert.ToInt32(Console.ReadLine());

                            garage.AddBicycle(price, maxSpeed, year, maxPassengers);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите цену автомобиля:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите макс скорость автомобиля:");
                            int maxSpeed = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска автомобиля:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите мощность автомобиля:");
                            int power = Convert.ToInt32(Console.ReadLine());

                            garage.AddCar(price, maxSpeed, year, power);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите цену грузовика:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите макс. скорость грузовика:");
                            int maxSpeed = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска грузовика:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите макс грузоподъемность:");
                            int maxCapacity = Convert.ToInt32(Console.ReadLine());

                            garage.AddLorry(price, maxSpeed, year, maxCapacity);
                            break;
                        }
                    case 4:
                        Console.WriteLine("Все велосипеды:");
                        garage.ShowAllBicycles();
                        break;
                    case 5:
                        Console.WriteLine("Все машины:");
                        garage.ShowAllCars();
                        break;
                    case 6:
                        Console.WriteLine("Все грузовики:");
                        garage.ShowAllLorries();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}