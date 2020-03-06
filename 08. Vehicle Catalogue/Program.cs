using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Hp { get; set; }

    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalogue
    {
        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command.Split("/");
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int data = int.Parse(info[3]);
                if (type == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = data
                    };

                    trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        Hp = data
                    };

                    cars.Add(car);
                }
            }

            Catalogue catalogue = new Catalogue(cars, trucks);

            IEnumerable<Car> orderedCars = cars.OrderBy(car => car.Brand); 

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Hp}hp");
                }
            }
           
            IEnumerable<Truck> orderedTrucks = trucks.OrderBy(truck => truck.Brand);

            if (trucks.Count>0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
