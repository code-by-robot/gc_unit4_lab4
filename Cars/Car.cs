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
    }
}
