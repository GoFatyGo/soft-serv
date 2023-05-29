using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LINQ
{
    abstract class Shape
    {
        public string name;
        public string Name { get; set; }
        public abstract double Area();
        public abstract double Perimetr();
        public abstract override string ToString();

    }

    class Circle : Shape
    {
        double pi = 3.14;
        // string name;
        public double R { get; set; }

        public Circle()
        {
            Name = "Circle";
            R = 10;
        }
        public Circle(string name, double radius)
        {
            Name = this.name;
            R = radius;
        }
        public override double Area()
        {
            return (pi * R * R);
        }
        public override double Perimetr()
        {
            return (2 * pi * R);
        }
        public override string ToString()
        {
            return $"Name: {Name}; R = {R};  Area = {Math.Round(Area(), 3, MidpointRounding.AwayFromZero)}; Perimetr = {Math.Round(Perimetr(), 3, MidpointRounding.AwayFromZero)};";
        }
    }
    class Square : Shape
    {
        // string name;
        public double Side { get; set; }
        public Square()
        {
            Name = "any square";
            Side = 5;
        }
        public Square(string name, double side)
        {
            Name = this.name;
            Side = side;
        }
        public override double Area()
        {
            return (Side * Side);
        }
        public override double Perimetr()
        {
            return (4 * Side);
        }
        public override string ToString()
        {
            return $"Name: {Name}; Side = {Side}; Area = {Math.Round(Area(), 3, MidpointRounding.AwayFromZero)}; Perimetr = {Math.Round(Perimetr(), 3, MidpointRounding.AwayFromZero)};";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Create list of Shape and fill it with 6 different shapes (Circle and Square).
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square() { Name = "Square1", Side = 5 });
            shapes.Add(new Circle() { Name = "Circle1", R = 100 });
            shapes.Add(new Square() { Name = "Square2", Side = 7 });
            shapes.Add(new Circle() { Name = "Circle2", R = 150 });
            shapes.Add(new Square() { Name = "Square3", Side = 20 });
            shapes.Add(new Circle() { Name = "Circle3", R = 40 });

            // Find and write into the file shapes with area from range [10,100]
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo dir = Directory.CreateDirectory($@"{desktopPath}/Shapes 10100");

            string fileName = "Shapes 10100.txt";
            string filePath = Path.Combine(dir.FullName, fileName);
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using (StreamWriter includShapes = File.CreateText(filePath))
            {
                foreach (var item in shapes)
                {
                    if (item.Area() > 10100)
                    {
                        includShapes.WriteLine(item);
                    }
                }

            }

            //Find and write into the file shapes which name contains letter 'a'
            Regex regex = new Regex(@"(\w+(a)\w+)");

            using (StreamWriter includShapes = File.AppendText(filePath))
            {
                foreach (var item in shapes)
                {
                    if (regex.IsMatch(item.Name))
                    {
                        includShapes.WriteLine(item.Name);
                    }
                }
            }

            // Find and remove from the list all shapes with perimeter less then 50.
            // Write resulted list into Console

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimetr() < 50)
                {
                    Console.WriteLine(shapes[i] + "was removed");
                    shapes.RemoveAt(i);
                }
            }
            Console.WriteLine("New List:");
            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }


            //         B) Create Console Application project.
            //Prepare txt file with a lot of text inside(for example take you.cs file from previos homework)
            //             Read all lines of text from file into array of strings.
            //Each array item contains one line from file.
            //Complete next tasks:
            //1) Count and write the number of symbols in every line.

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName_txt = "test.txt";
            string filePath_txt = Path.Combine(path, fileName_txt);

            string[] lines = File.ReadAllLines(filePath_txt);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(i + " = " + lines[i].Length);
            }

            //2) Find the longest and the shortest line. 
           
            int max = 0;
            int line = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > max)
                {
                    max = lines[i].Length;
                    line = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nLongest line is {line} with {max} symbols.\n\n");
            Console.ResetColor();

            // 3) Find and write only lines, which consist of word "int". I dont have "var" in my code:))

            Regex regex_int = new Regex(@"(\bint\b)");
            for (int i = 0; i < lines.Length; i++)
            {
                if (regex_int.IsMatch(lines[i]))
                {
                    Console.WriteLine($"{i} line:{lines[i]}");
                }
            }


            
        }
    }
}
