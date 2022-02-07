using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
   public class Example

    {
        public static void Main()
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Deepthi");
            apartment.door = new House.Door("Red");
            person.house = apartment;
            person.ShowData();
            Console.ReadLine();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public class House
        {
            public int Area { get; set; }
            public Door door;

            public House(int area = 200)
            {
                Area = area;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a house, my area is {Area} m2");
            }

            public Door GetDoor()
            {
                return door;
            }

            public class Door
            {
                public string Color { get; set; }

                public Door(string color = "white")
                {
                    Color = color;
                }

                public void ShowData()
                {
                    Console.WriteLine($"I am a door, my color is {Color}");
                }
            }
        }

        public class SmallApartment : House
        {
            public SmallApartment(int area = 100) : base(area)
            {
            }
        }

        public class Person
        {
            private string name;
            public House house { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public void ShowData()
            {
                Console.WriteLine($"A person whose name is {name}");
                Console.WriteLine("Data of house:");
                house.ShowData();
                Console.WriteLine("Data of door:");
                house.GetDoor().ShowData();
            }

        }

    }
}

