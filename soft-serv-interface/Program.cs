using soft_serv_interface;
using System;
using System.Collections.Generic;

namespace soft_serv_interface
{
    //    Develop interface IFlyable with method Fly() (Output information about bird or plane).
    //Create two classes Bird(with fields: name and canFly) and Plane(with fields: mark and highFly) ,
    //which implement interface IFlyable.
    //Create List of IFlyable objects.Add some Birds and Planes to it.Call Fly() method for every item from
    //the list of it.

    interface IFlyable
    {
        void Fly();
    }

    class Bird : IFlyable
    {
        public string name { get; set; }
        public string canFly { get; set; }

        public void Fly()
        {
            Console.WriteLine($"{name} +  {canFly}");
        }

    }

    class Plane : IFlyable
    {
        public string mark { get; set; }
        public string highFly { get; set; }

        public void Fly()
        {
            Console.WriteLine($"{ mark} + {highFly}");
        }
    }

    interface IDeveloper:IComparable<IDeveloper>
    {
        string Tool { get; set; }
        //string languange { get; set; }
        void Create();
        void Destroy();
        string ToString();
    }
    class Program
    {
        class Programmer : IDeveloper
        {
            public string lenguange { get; set; }

            public string Tool { get; set; }

            public int CompareTo(IDeveloper? other)
            {
                return string.Compare(Tool, other?.Tool);
            }

            public void Create()
            {
                Console.WriteLine("Programmer write code");
            }
            public void Destroy()
            {
                Console.WriteLine("Destroy Programm");
            }
            public override string ToString()
            {
                return $"{lenguange}";
            }
        }
        class Builder : IDeveloper
        {
            public string Tool { get; set; }
            public void Create()
            {
                Console.WriteLine("Builder build houses");
            }
            public void Destroy()
            {
                Console.WriteLine("Destroy Building");
            }
            public override string ToString()
            {
                return $"{ Tool }";
            }

            public int CompareTo(IDeveloper? other)
            {
                return string.Compare(Tool, other?.Tool);
            }

          
        }
        static void Main(string[] args)
        {
            //Task #1
            //Bird bird1 = new Bird() { name = "parrot", canFly = "flies" };
            //Bird bird2 = new Bird() { name = "hang", canFly = "can not flies" };
            //Plane plane1 = new Plane() { mark = "Tu 144", highFly = "20 000m" };
            //Plane plane2 = new Plane() { mark = "Su 35", highFly = "20 000m" };
            //IFlyable[] flyables = new IFlyable[]
            //{
            //   bird1,bird2,plane1,plane2
            //};
            //foreach (var item in flyables)
            //{
            //    item.Fly();
            //}

            //Homwork:
            Console.WriteLine("\n\nHello World!\n\n");
            Programmer programmer1 = new Programmer() { lenguange = "C++ (programmer)" };
            Programmer programmer2 = new Programmer() { lenguange = "Java (programmer)" };
            Programmer programmer3 = new Programmer() { lenguange = "C# (programmer)" };
            Programmer programmer4 = new Programmer() { lenguange = "PHP (programmer)" };
            Builder builder1 = new Builder() { Tool = "Hammer (builder)" };
            Builder builder2 = new Builder() { Tool = "Axe (builder)" };
            Builder builder3 = new Builder() { Tool = "Drill (builder)" };
            Builder builder4 = new Builder() { Tool = "Paint (builder)" };
            

            Console.WriteLine("Unsorted List: \n");
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(programmer4);
            developers.Add(builder4);
            developers.Add(programmer1);
            developers.Add(builder1);
            developers.Add(builder2);
            developers.Add(builder3);
            developers.Add(programmer2);
            foreach (var item in developers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter sorted List: \n");
            developers.Sort();
            foreach (var item in developers)
            {
                Console.WriteLine(item);
            }


            //Create Console Application project in VS. In the Main() method declare Dictionary<uint,string>. 

            Console.WriteLine("\nEnter Id 1-8(Or exeption) ");
            Dictionary<int, string> IdNames = new Dictionary<int, string>();
            try
            {
                int Id = int.Parse(Console.ReadLine());
                //Add to Dictionary from Console 7 pairs (ID, Name) of some persons. 

                string Name;/*= Console.ReadLine();*/
                IdNames.Add(1, "Pupkin.V");
                IdNames.Add(2, "Supkin.V");
                IdNames.Add(3, "Zupko.V");
                IdNames.Add(4, "Mac.V");
                IdNames.Add(5, "Durko.V");
                IdNames.Add(6, "Shmatko.V");
                IdNames.Add(7, "Shtirlits.V");
                IdNames.Add(8, "Salivan.V");

                Console.ForegroundColor = ConsoleColor.Green;

                //Ask user to enter ID, then find and write corresponding Name from your Dictionary. If you can't find this ID - say about it to user. 
                Console.WriteLine($"{Name = IdNames[Id]}\n");
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ArgumentException" + ex.Message);

            }
            catch (KeyNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are no names with this Id");
            }
            Console.ResetColor();

        }


    }
}



