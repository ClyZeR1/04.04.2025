using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Lorry:Vehicle
    {
        public int MaxCapacity { get; set; } 
        public Lorry(int price,int maxspeed,int year,int maxcapacity):base(price,maxspeed,year)
        {
            MaxCapacity = maxcapacity;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Грузовик: Цена: {Price}руб, Скорость: {Maxspeed}км/ч, Год:{Year}, Максимальная грузоподъёмность{MaxCapacity}кг:");
        }
    }
}
