using soft_serv_interface;
using System;
using System.Collections.Generic;

namespace soft_serv_interface
{
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

            public void Sort()
            {
                Array.Sort(this.Tool.CompareTo);
            }
            //public int CompareTo(object obj)
            //{
            //    return  ;
            //}
            //public int CompareTo(object obj)
            //{
            //    return string.Compare(Tool.ToString(), obj != null ? ((IDeveloper)obj).Tool.ToString() : string.Empty);
            //}
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
            Programmer programmer1 = new Programmer() { lenguange = "C++ (programmer)" };
            Programmer programmer2 = new Programmer() { lenguange = "Java (programmer)" };
            Programmer programmer3 = new Programmer() { lenguange = "C# (programmer)" };
            Programmer programmer4 = new Programmer() { lenguange = "PHP (programmer)" };
            Builder builder1 = new Builder() { Tool = "Hammer (builder)" };
            Builder builder2 = new Builder() { Tool = "Axe (builder)" };
            Builder builder3 = new Builder() { Tool = "Drill (builder)" };
            Builder builder4 = new Builder() { Tool = "Paint (builder)" };
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

            Console.WriteLine(builder4.CompareTo(builder3)); 


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



