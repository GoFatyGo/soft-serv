using System;
using System.Collections.Generic;
using System.Linq;

namespace Clases
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
            return $"Name: {Name}; R = {R};  Area = {Math.Round(Area(), 3, MidpointRounding.AwayFromZero)}; Perimetr = {Math.Round(Perimetr(),3,MidpointRounding.AwayFromZero)};";
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
            return $"Name: {Name}; Side = {Side}; Area = {Math.Round(Area(),3,MidpointRounding.AwayFromZero)}; Perimetr = {Math.Round(Perimetr(), 3, MidpointRounding.AwayFromZero)};";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //         1) Create abstract class Shape with field name and property Name.
            //Add constructor with 1 parameter and abstract methods Area() and Perimeter(),
            //which can return area and perimeter of shape; 
            //Create classes Circle, Square derived from Shape with field radius(for Circle) and
            //side(for Square).   Add necessary constructors, properties to these classes,
            //override methods from abstract class Shape. 
            //a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.
            //Write name, area and perimeter of all shapes. 
            //b) Find shape with the largest perimeter and print its name.
            //3) Sort shapes by area and print obtained list(Remember about IComparable)
           
            //create List of objects
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square() { Name = "Square 1", Side = 5 });
            shapes.Add(new Circle() { Name = "Circle 1", R = 10 });
            shapes.Add(new Square() { Name = "Square 2", Side = 7 });
            shapes.Add(new Circle() { Name = "Circle 2", R = 15 });
            shapes.Add(new Square() { Name = "Square 3", Side = 2 });
            shapes.Add(new Circle() { Name = "Circle 3", R = 4 });
            shapes.Add(new Square() { Name = "Square 4", Side = 15 });
            shapes.Add(new Circle() { Name = "Circle 4", R = 20 });
            shapes.Add(new Square() { Name = "Square 5", Side = 25 });
            shapes.Add(new Circle() { Name = "Circle 5", R = 3 });

            foreach (var item in shapes)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            //search for the largest perimetr
            double[] arrPerimetr = new double[shapes.Count];
            string[] arrPerimetrNames = new string[shapes.Count];
            for (int i = 0; i < shapes.Count; i++)
            {
                arrPerimetrNames[i] = shapes[i].Name;
                arrPerimetr[i] = shapes[i].Perimetr();
            }
            double maxValuePerimetr = arrPerimetr.Max();
            string name = null;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (maxValuePerimetr == shapes[i].Perimetr())
                {
                    name = shapes[i].Name;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe shape with the biggest perimetr is: {name}, Perimetr = {maxValuePerimetr}\n");
            Console.ResetColor();

            //searching for the largest Area
            double[] arrArea = new double[shapes.Count];
            string[] arrAreaNames = new string[shapes.Count];
            for (int i = 0; i < shapes.Count; i++)
            {
                arrAreaNames[i] = shapes[i].Name;
                arrArea[i] = shapes[i].Area();
            }

            //create Dictionary of objects with all information to sort Area
            Dictionary<Shape, double> shapesDictionary = new Dictionary<Shape, double>();
            for (int i = 0; i < shapes.Count; i++)
            {
                shapesDictionary.Add(shapes[i], arrArea[i]);
            }

            //sort Dictionary by Area value from largest to smallest
            foreach (KeyValuePair<Shape, double> Area in shapesDictionary.OrderByDescending(key=>key.Value))
            {
                Console.WriteLine(Area.Key.ToString(),Area.Value);
            }


        }
    }
}
