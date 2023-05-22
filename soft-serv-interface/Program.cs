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

    class Bird:IFlyable
    {
        public string name { get; set; }
        public string canFly { get; set; }

        public void Fly()
        {
            Console.WriteLine($"{name} +  {canFly}");
        }

    }

    class Plane:IFlyable
    {
        public string mark { get; set; }
        public string highFly { get; set; }
      
        public void Fly()
        {
            Console.WriteLine($"{ mark} + {highFly}");
        }
    }

    //interface ICompareTo
    //{

    //}



    interface IDeveloper
    {
        string Tool { get; set; }
        //string languange { get; set; }
        void Create();
        void Destroy();
        string ToString();
        //int CompareTo(object obj)
        //{
        //    return string.Compare(Tool.ToString(), obj != null ? ((IDeveloper)obj).Tool.ToString() : string.Empty);
        //}
        //public int CompareTo(object obj)
        //{
        //    return this.Tool.CompareTo(obj.)
        //}
    }
    class Program
    {
        class Programmer : IDeveloper, IComparable
        {
            public string lenguange { get; set; }

            public string Tool { get; set; }

            public int CompareTo(object obj)
            {
                return string.Compare(Tool.ToString(), obj != null ? ((IDeveloper)obj).Tool.ToString() : string.Empty);
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
        class Builder : IDeveloper, IComparable
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

            //public void Sort()
            //{
            //    Array.Sort(this.Tool.CompareTo);
            //}

            public int CompareTo(object obj)
            {
                return string.Compare(Tool.ToString(), obj != null ? ((IDeveloper)obj).Tool.ToString() : string.Empty);
            }
        }
        static void Main(string[] args)
        {

            Bird bird1 = new Bird() { name = "parrot", canFly = "flies" };
            Bird bird2 = new Bird() { name = "hang", canFly = "can not flies" };
            Plane plane1 = new Plane() { mark = "Tu 144", highFly = "20 000m" };
            Plane plane2 = new Plane() { mark = "Su 35", highFly = "20 000m" };
            IFlyable[] flyables = new IFlyable[]
            {
               bird1,bird2,plane1,plane2
            };
            foreach (var item in flyables)
            {
                item.Fly();
            }


            //Console.WriteLine("Hello World!");
            //Programmer programmer1 = new Programmer() { lenguange = "C++ (programmer)" };
            //Programmer programmer2 = new Programmer() { lenguange = "Java (programmer)" };
            //Programmer programmer3 = new Programmer() { lenguange = "C# (programmer)" };
            //Programmer programmer4 = new Programmer() { lenguange = "PHP (programmer)" };
            //Builder builder1 = new Builder() { Tool = "Hammer (builder)" };
            //Builder builder2 = new Builder() { Tool = "Axe (builder)" };
            //Builder builder3 = new Builder() { Tool = "Drill (builder)" };
            //Builder builder4 = new Builder() { Tool = "Paint (builder)" };
            //IDeveloper[] arrDeveloper = new IDeveloper[]
            //    {
            //            programmer1,
            //            builder1,
            //            builder2,
            //            programmer2,
            //            builder3,
            //            builder4,
            //            programmer3,
            //            programmer4
            //    };



            //foreach (var item in arrDeveloper)
            //{
            //    Console.WriteLine(item);
            //}

          //  Console.WriteLine(builder4.CompareTo(builder3)); 


            // List<IDeveloper> developers = new List<IDeveloper>();


            //programmer1.Create();
            //IDeveloper developer = new Programmer();
            //developer.Destroy();
            //developer = builder1;
            //builder1.Create();
            //Builder builder2 = new Builder();
            //builder2.Create();

        }

       
    }
}



