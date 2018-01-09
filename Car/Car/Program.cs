using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("red", "Toyota");
            var saloonCar1 = new SaloonCar1(2);
            var saloonCar2 = new SaloonCar2(3, "Nissan");
            var saloonCar3 = new SaloonCar3(4, "Ford", "purple");
        }
    }

    // Construct for property common to all objects: numberOfSeats
    public class CommonConstructs
    {
        public CommonConstructs()
        {
        }
        public int numberOfSeats { get; set; }
    }

    //Construct2 for numberOfSeats and manufacturer
    public class Constructor2 : CommonConstructs
    {
        public Constructor2 ()
        {
        }
        public string _manufacturer { get; set; }
    }

    //Construct3 for numberOfSeats, manufacturer and color
    public class Constructor3 : Constructor2
    {
        public Constructor3 ()
        {
        }
        public string _color { get; set; }
    }
    public class Car : Constructor3
    {
        public Car(string _color, string _manufacturer)
        {
        }
    }

    public class SaloonCar1 : CommonConstructs
    {
        public SaloonCar1(int num)
        {
        }
    }

    public class SaloonCar2 : Constructor2
    {
        public SaloonCar2(int num, string _manufacturer)
        {
        }
    }

    public class SaloonCar3 : Constructor3
    {
        public SaloonCar3(int num, string _color, string _manufacturer)
        {
        }
    }
}
