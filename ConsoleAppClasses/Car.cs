using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClasses
{
    public class Car
    {
        //default access modifier is private inside a class

        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        readonly int id;
        public int Id { get { return id; } }


        public readonly string brand;//field
        private string model;
        public string Model//Prop
        {
            get 
            {
                return model; 
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cant be empty.");
                }
                model = value;
            }
        }
        public string color;
        public int year;
        public int hp;

        //if you dont make a constructor, C# will add a zero cunstructor for you.

        public Car(string brand, string carModel, string color, int year, int hp)
        {
            id = ++idCounter;
            this.brand = brand;
            Model = carModel;
            this.color = color;
            this.year = year;
            this.hp = hp;
        }

        public string Info()
        {
            return $"---- Car Info ----\nId: {id}\nBrand: {brand}\nModel: {model}\nColor: {color}\nYear: {year}\nBHP: {hp}";
        }

        public override string ToString()
        {
            return Info();
        }
    }
}
