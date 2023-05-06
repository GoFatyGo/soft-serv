using System;

namespace soft_serv
{


    class Program
    {

        class Person
        {
            // DateTime dateTime = new DateTime();
            string name;
            DateTime birthYear;
            public Person(string n) { name = n; }
            public Person(string n, DateTime date) { name = n; birthYear = date; }
            public string getName { get { return name; } }
            public DateTime getbirthYear { get { return birthYear; } }

            public void Input()
            {
                name = Console.ReadLine();
            }

            public override string ToString()
            {
                return $"Name: {name}, Birth: {birthYear}";
            }
            public void Output()
            {
               // Console.WriteLine($"Name: {name}, Birth: {birthYear}");
            }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person a = new Person("Nik");
            a.Input();

            a.Output();
            Console.WriteLine(a);
            a.Output();

            // a.getbirthYear();
            // DateTime dateTime = new DateTime(1582, 10, 5);
        }
    }
}
