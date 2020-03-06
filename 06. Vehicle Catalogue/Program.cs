using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Catalogue(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public override string ToString()
        {
            return $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                   $"Model: {Model}{Environment.NewLine}" +
                   $"Color: {Color}{Environment.NewLine}" +
                   $"Horsepower: {HorsePower}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogues = new List<Catalogue>();
            
            while (true)
            {

                string[] info = Console.ReadLine().Split();
                string type = info[0];
                if (type=="End")
                {
                    break;
                }
                else
                {
                    string brand = info[1];
                    string color = info[2];
                    int power = int.Parse(info[3]);

                    Catalogue catalogue = new Catalogue(type, brand, color, power);

                    catalogues.Add(catalogue);
                }
            }

            
            while (true)
            {
                var printModel = Console.ReadLine();

                if (printModel == "Close the Catalogue")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join(" ", catalogues.Where(x => x.Model == printModel)));
                }
            }

            List<Catalogue> cars = catalogues.Where(x => x.Type == "car").ToList();
            List<Catalogue> trucks = catalogues.Where(x => x.Type == "truck").ToList();

            if (cars.Count > 0)
            {
                double averageCarHp = cars.Average(x => x.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {cars.Sum(x => x.HorsePower):f2}.");
            }

            if (trucks.Count > 0)
            {
                double averageTruckHp = trucks.Average(x => x.HorsePower);

                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {trucks.Sum(x => x.HorsePower):f2}.");
            }
        }
    }
}
