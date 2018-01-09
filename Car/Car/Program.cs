using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("red", "Toyota");
        }
    }

    public class Car
    {
        public Car(string _color, string _manufacturer)
        {
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }
        public class SaloonCar : Car
        {
            public SaloonCar ()
            {
            }
            public int numberOfSeats { get; set; }
        }
}
