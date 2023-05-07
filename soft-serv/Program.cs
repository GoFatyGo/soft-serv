using System;

namespace soft_serv
{


    class Program
    {

        class Person
        {
            private string name;
            private DateTime birthYear = new DateTime();
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
                    name = "Very Young";
                    Console.WriteLine($"{name} ({Age})");
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
            //DateTime birthA = new DateTime(2000, 2, 2);
            //DateTime birthB = new DateTime(2010, 2, 2);
            //DateTime birthC = new DateTime(2005, 2, 2);
            //DateTime birthD = new DateTime(2012, 2, 2);
            //DateTime birthF = new DateTime(2001, 2, 2);
            //DateTime birthK = new DateTime(2004, 2, 2);


            Person a = new Person("Nik", new DateTime(2000,1,1));
            Person b = new Person("Vasya", new DateTime(2010, 2, 2));
            Person c = new Person("Vasya", new DateTime(2005, 2, 2));
            Person d = new Person("Petya", new DateTime(2012, 2, 2));
            Person f = new Person("Kolya", new DateTime(2001, 2, 2));
            Person k = new Person("Nik", new DateTime(2004, 2, 2));

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
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"{arr[i]} and {arr[j]} same names");
                    }
                }
            }




        }
    }
}
