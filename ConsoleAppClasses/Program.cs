using System;

namespace ConsoleAppClasses
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Car id counter: " + Car.IdCounter);

            Car myCar = new Car("Saab","900S","Dark blue",1989, 320);
            Console.WriteLine("Car id counter: " + Car.IdCounter);    
            
            Car anotherCar = new Car("Volvo","740","Brun",1981, 120);
            Console.WriteLine("Car id counter: " + Car.IdCounter);
            
            Car someonceCar = new Car("BMW","525i","Black",2001, 420);
            Console.WriteLine("Car id counter: " + Car.IdCounter);
            

            //Console.WriteLine(myCar.brand);

            //Console.WriteLine(myCar.Model);

            //myCar.Model = "9000";

            //Console.WriteLine(myCar.ToString());//Console.WriteLine(myCar);

            Console.WriteLine(myCar.Info());
            Console.WriteLine(anotherCar.Info());
            Console.WriteLine(someonceCar.Info());

            Console.WriteLine(DivMath(3.0,0.0));
        }

        public static double DivMath(double numA, double numB)
        {
            return numA / numB;
        }
    }
}
