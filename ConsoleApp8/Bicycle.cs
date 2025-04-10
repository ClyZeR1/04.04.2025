using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Bicycle:Vehicle
    {
        public int MaxPassengers { get; set; }
        public Bicycle(int price, int maxspeed,int year,int maxPassengers):base(price,maxspeed,year)
        {
            MaxPassengers = maxPassengers;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Велосипед: Цена: {Price}руб, Скорость:{Maxspeed}км/ч, Год:{Year}, Максимум пассажиров:{MaxPassengers}");
        }
    }
}
