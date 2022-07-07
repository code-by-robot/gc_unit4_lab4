using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
        //properties
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public decimal Price { get; }
        //public static List<Car> CarList = new List<Car>();

        //constructor
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price; 
        }
    

        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t{Price}";
        }

        public static void ListCars(List<Car> carlist)
        {
            foreach(Car c in carlist)
            {
                Console.WriteLine($"{carlist.IndexOf(c)+1}." + c.ToString()); 
            }
        }

        //Add a public static method to Car called ListCars that loops through the list and prints out each member and its index in the list. (Hint: Use a regular for loop, not a foreach loop so you  can print out the index.)
        //Add a public static method to Car called Remove which takes an integer parameter and removes the car whose index is that parameter

        

        public static void Remove(int index, List<Car> CarList)
        {
            CarList.RemoveAt(index-1);
        }

        public static void BuyBack(Car vehicle, List<Car> CarList)
        {
            CarList.Add(vehicle);
        }
    }
}
