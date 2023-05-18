using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {


            //In Main() method declare Dictionary PhoneBook for keeping pairs PersonName - 
            //    PhoneNumber.
            //    1) From file "phones.txt" read 9 pairs into PhoneBook.Write
            //    only PhoneNumbers into file "Phones.txt".
            //    2) Find and print phone number by 
            //    the given name(name input from console)
            //    3) Change all phone numbers,
            //    which are in format 80######### into new format +380#########. 
            //    The result write into file «New.txt»


            //create dictionary with names and numbers
            Console.WriteLine("Hello World!");
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            PhoneBook.Add("Petr", "+380672222222");
            PhoneBook.Add("Vasiliy", "80672222223");
            PhoneBook.Add("Oleg", "80672222224");
            PhoneBook.Add("Nikolay", "+380672222225");
            PhoneBook.Add("Volodimir", "80672222226");
            PhoneBook.Add("Ruslan", "80672222227");
            PhoneBook.Add("Nik", "80672222228");
            PhoneBook.Add("Jhon", "80672222229");
            PhoneBook.Add("Albert", "80672222233");
            PhoneBook.Add("Karl", "80672222244");



            //create folder and txt with Names and numbers

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo dir = Directory.CreateDirectory($@"{desktopPath}/test_folder");

            string fileName = "PNumbers.txt";
            string filePath = Path.Combine(dir.FullName, fileName);
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (StreamWriter includPhonesnumber = File.CreateText(filePath))
            {
                foreach (var item in PhoneBook)
                {
                    includPhonesnumber.WriteLine(item);
                }
            }

            //create new txt in folder with numbers only

            // string desktopPathOnlyNumbers = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // DirectoryInfo dirOnlyNumbers = Directory.CreateDirectory($@"{desktopPathOnlyNumbers}/Only_numbers");

            string fileNameOnlyNumbers = "OnlyNumbers.txt";
            string filePath2 = Path.Combine(dir.FullName, fileNameOnlyNumbers);
            if (!File.Exists(filePath2))
            {
                File.Create(filePath2).Close();
            }

            string personName, phoneNumber;
            List<string> arrPhones = new List<string>();
            foreach (KeyValuePair<string, string> info in PhoneBook)
            {
                personName = info.Key;
                phoneNumber = info.Value;
                arrPhones.Add(phoneNumber);
            }
            using (StreamWriter includOnlyPhonesnumber = File.CreateText(filePath2))
            {
                foreach (var item in arrPhones)
                {
                    includOnlyPhonesnumber.WriteLine(item);
                }
            }

            //find phonenumbers with name

            using (StreamReader reader = File.OpenText(filePath))
            {
                string number = "not found";
                string allText = reader.ReadToEnd();
                Console.WriteLine(allText);
                Console.WriteLine("Enter name to find number: ");
                string find = Console.ReadLine();
                if (PhoneBook.TryGetValue(find, out number))
                {
                    Console.WriteLine(find + "  " + number);
                }
                else
                {
                    Console.WriteLine("not found number");
                }
            }

            //change "80" in "+380"

            
            string[] arrAllinfo = File.ReadAllLines(filePath2);
            using (StreamWriter includOnlyPhonesnumber = new StreamWriter(filePath2,true))
            {
                
                includOnlyPhonesnumber.WriteLine("\nCorrect format: ");
                for (int i = 0; i < arrAllinfo.Length; i++)
                {
                    if (arrAllinfo[i].StartsWith("80"))
                    {
                        arrAllinfo[i] = "+3" + arrAllinfo[i].Substring(0);
                    }
                    includOnlyPhonesnumber.WriteLine(arrAllinfo[i]);
                }

            }




        }
    }
}
