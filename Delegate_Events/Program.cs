using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_Events
{
    public delegate void MyDell(int m);

    class Program
    {
            public static event MyDell MarkChange;

        public class accounting
        {

            public  int PayingFellowship(List<int> listOfMarks)
            {
                double result = listOfMarks.AsQueryable().Average();
               int res =Convert.ToInt32( ( Math.Round(result)));
                return res;
            }
            public void answer (int mark)
            {
                if (mark >= 4)
                {
                    Console.WriteLine("\naccounting answer: scholarship approved");
                }
                else
                {
                    Console.WriteLine("\naccounting answer: No scholarship."); 
                }
            }
        }

        public class Student
        {
            public string name { get; set; }
            public List<int> marks = new List<int>();
            public void AddMark(int mark)
            {
                marks.Add(mark);
            }
           // string str;
            public void ShowList()
            {
                Console.Write("Marks: ");
                foreach (var item in marks)
                {
                    Console.Write(string.Format("{0}, ", item));
                }

                //  char ch = ',';
                //str = String.Join(ch, marks);
            }
            public override string ToString()
            {
                return $"Name: {name}";
            }
        }
        public class Parent
        {
            public void OnMarkChange(int mark)
            {
                Console.WriteLine($"\nYour child has new mark: {mark}");
            }
        }

        static void Main(string[] args)
        {
            //            Create Delegate void MyDel(int m)
            //Create class Student with names and marks(a type of list <int>), 
            //            event MarkChange of the type MyDel and the method AddMark(adds a new mark to the list of marks).
            //Create class Parent with the method OnMarkChange(which receives
            //    an int estimate and displays it on the console)
            //In Main, create a student, parent, sign the parent method of OnMarkChange
            //            on the student event MarkChange.Call the method AddMark several times.
            //Create a class Accountancy, a method of PayingFellowship(which prints will be
            //    a student have a scholarship or not). Sign this method on the student event MarkChange
            // int setMark =int.Parse( Console.ReadLine());
            Console.WriteLine("Hello World!");
            Student Petr = new Student() { name = "Petr"/*, marks = { 2, 2 }*/ };
            Parent parent = new Parent();
            accounting accounting = new accounting();

            int setMark1 = 2;
            int setMark2 = 3;
            int setMark3 = 4;
            int setMark4 = 5;
            int setMark5 = 2;
            //Petr.AddMark(setMark);
            MyDell myDell = Petr.AddMark;

            Petr.AddMark(setMark1);
            Petr.AddMark(setMark2);
            Petr.AddMark(setMark3);
            Petr.AddMark(setMark4);
            Petr.AddMark(setMark5);

            MarkChange += parent.OnMarkChange;
            MarkChange(setMark4);
            MarkChange(setMark5);

            Console.WriteLine(Petr);
            Petr.ShowList();

            MarkChange = accounting.answer;
            MarkChange(setMark5);


            //Petr.ShowList();
            //MarkChange += myDell;
            //MarkChange += parent.OnMarkChange;
            //MarkChange(5);
            //Petr.ShowList();



        }


    }
}