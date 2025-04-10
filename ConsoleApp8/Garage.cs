

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Garage
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Bicycle> Bicycles { get; set; } = new List<Bicycle>();
        public List<Lorry> Lorries { get; set; } = new List<Lorry>();

        public void AddCar(int price, int maxspeed, int year, int power)
        {
            Cars.Add(new Car(price, year, power, maxspeed));
        }
        public void AddBicycle(int price, int maxspeed, int year, int maxPassengers)
        {
            Bicycles.Add(new Bicycle(price, year, maxspeed, maxPassengers));
        }
        public void AddLorry(int price, int maxspeed, int year, int maxcapacity)
        {
            Lorries.Add(new Lorry(price, year, maxspeed,maxcapacity));
        }
        public void ShowAllCars()
        {
            foreach (var car in Cars)
            {
                car.ShowDetails();
            }
        }
        public void ShowAllBicycles()
        {
            foreach (var bicycle in Bicycles)
            {
                bicycle.ShowDetails();
            }
        }
        public void ShowAllLorries()
        {
            foreach (var lorry in Lorries)
            {
                lorry.ShowDetails();
            }
        }
    }
}