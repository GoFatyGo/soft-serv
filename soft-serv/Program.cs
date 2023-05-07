using System;

namespace soft_serv
{


    class Program
    {

        class Person
        {
            // DateTime dateTime = new DateTime();
            private string name;
            private DateTime birthYear = new DateTime();
            static int q;
            public Person()
            {
                name = "none";
                birthYear = birthYear.Date;
            }
            public Person(string n) { name = n; }
            public Person(string n, DateTime date) { name = n; birthYear = date; }
            public string GetName { get { return name; } }
            public DateTime GetbirthYear { get { return birthYear; } }

            public void Age()
            {
                DateTime Now = new DateTime(2023, 06, 05);
                int Age = Now.Year - birthYear.Year;
                if (Age < 16)
                {
                    // name = "Very Young";
                    Console.WriteLine($"{name} is very Young ({Age})");
                }
                else
                    Console.WriteLine($"{name} is {Age}");
            }
            public void Input()
            {
                name = Console.ReadLine();
                birthYear = DateTime.Parse(Console.ReadLine());
            }
            public void ChangeName()
            {
                name = Console.ReadLine();
            }

            public override string ToString()
            {
                return $"Name: {name}, Birth: {birthYear}";
            }
            public void Output()
            {
                Console.WriteLine($"Name: {name}, Birth: {birthYear}");
            }

            public static bool operator ==(Person person1, Person person2)
            {
                return person1.name == person2.name;
            }
            public static bool operator !=(Person person1, Person person2)
            {
                return person1.name != person2.name;
            }
        }
        static void Main(string[] args)
        {
            // DateTime Now = new DateTime();
            //Now = DateTime.Parse(Console.ReadLine());
            DateTime birthA = new DateTime(2000, 2, 2);
            DateTime birthB = new DateTime(2010, 2, 2);
            DateTime birthC = new DateTime(2005, 2, 2);
            DateTime birthD = new DateTime(2012, 2, 2);
            DateTime birthF = new DateTime(2001, 2, 2);
            DateTime birthK = new DateTime(2004, 2, 2);


            Person a = new Person("Nik",birthA);
            Person b = new Person("Vasya",birthB);
            Person c = new Person("Vasya",birthC);
            Person d = new Person("Petya",birthD);
            Person f = new Person("Kolya",birthF);
            Person k = new Person("Nik",birthK);

            a.Age();
            b.Age();
            c.Age();
            d.Age();
            f.Age();
            k.Age();




            Person[] arr = new Person[] { a, b, c, d, f, k };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            if (b == c)
            {
                Console.WriteLine("Одинаковые имена");
            }


        }
    }
}
