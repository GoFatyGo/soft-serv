using System;

namespace try_catch
{

    class Program
    {
        static int ReadNumber(int start, int end)
        {
            int val = 0;
            try
            {
                val = int.Parse(Console.ReadLine());
                if (start > val || val > end)
                    throw new ArgumentException("Doesnt meet the conditions ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine( ex.Message);
            }

            return val;
        }

        static void Mainn()
        {


            try
            {
                int[] arrInt = new int[10];
                arrInt[0] = ReadNumber(0, 5);
                if (arrInt[0] <= 1)
                    throw new ArgumentException("Invalid range");
                arrInt[1] = ReadNumber(0, 100);
                if (arrInt[1] <= arrInt[0])
                    throw new ArgumentException("Invalid range");
                arrInt[2] = ReadNumber(0, 100);
                if (arrInt[2] <= arrInt[1])
                    throw new ArgumentException("Invalid range");
                arrInt[3] = ReadNumber(0, 100);
                if (arrInt[3] <= arrInt[2])
                    throw new ArgumentException("Invalid range");
                arrInt[4] = ReadNumber(0, 100);
                if (arrInt[4] <= arrInt[3])
                    throw new ArgumentException("Invalid range");
                arrInt[5] = ReadNumber(0, 100);
                if (arrInt[5] <= arrInt[4])
                    throw new ArgumentException("Invalid range");
                arrInt[6] = ReadNumber(0, 100);
                if (arrInt[6] <= arrInt[5])
                    throw new ArgumentException("Invalid range");
                arrInt[7] = ReadNumber(0, 100);
                if (arrInt[7] <= arrInt[6])
                    throw new ArgumentException("Invalid range");
                arrInt[8] = ReadNumber(0, 100);
                if (arrInt[8] <= arrInt[7])
                    throw new ArgumentException("Invalid range");
                arrInt[9] = ReadNumber(0, 100);
                if (arrInt[9] <= arrInt[8])
                    throw new ArgumentException("Invalid range");
                Console.WriteLine("Result: ");
                for (int i = 0; i < arrInt.Length; i++)
                {
                    Console.Write(arrInt[i]+"  ");
                }
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine( ex.Message);

            }

        }
        static int Div(int val1, int val2)
        {

            return val1 / val2;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Create method Div(), which calculates the dividing of two int numbers.\n In Main() read  two int numbers and call this method. Catch appropriative exceptions");
            //bool chek = false;


            try
            {
                Console.WriteLine("First value");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Second value");
                int b = int.Parse(Console.ReadLine());
                //if (a%1!=0 || b%1!=0)
                //    throw new Exception("Both cant be more then 9");
                Console.WriteLine(Div(a, b));

                Div(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Cant div by zero:  { ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Only int:  { ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error :  { ex.Message}");
            }

            Console.WriteLine("Напишіть метод ReadNumber(int start, int end), який читає з цілих чисел консолі \nі повертає його, якщо він знаходиться в діапазоні[start... end].\nЯкщо прочитано недійсний номер чи нечисельний текст, \nметод повинен кинути виняток.За допомогою цього методу \nнапишіть метод Main(), який повинен ввести 10 номерів:a1, a2, ..., a10, таке, що 1 < a1 < ... < a10 < 100");
            
            ReadNumber(1,5);
            Mainn();
        }
    }
}
