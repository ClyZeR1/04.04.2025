using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Car : Vehicle
    {
        public int Power { get; set; }
        public Car(int price, int maxspeed, int year, int power):base(price,maxspeed,year)
        {
            Power = power;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Автомобиль: Цена: {Price}руб, Скорость:{Maxspeed}км/ч, Год: {Year}, Мощность: {Power} л.с.");

        }
    }
}
