using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNum { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command.Split(" ");
                string serialNum = info[0];
                string name = info[1];
                int quantity = int.Parse(info[2]);
                double itemPrice = double.Parse(info[3]);
                double boxPrice = itemPrice * quantity;

                Item item = new Item()
                {
                    Name = name,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNum = serialNum,
                    Item = item,
                    Quantity = quantity,
                    Price = boxPrice


                };

                boxes.Add(box);
            }
            
            IEnumerable<Box> ordered = boxes.OrderBy(Box => Box.Price);

            foreach (Box box in ordered.Reverse())
            {
                Console.WriteLine($"{box.SerialNum}\n-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}\n-- ${box.Price:f2}");
            }
        }
    }
}
