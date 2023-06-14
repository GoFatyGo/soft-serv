using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Buyer
    {
        public string name;
        public int money;

        public Buyer()
        {
            name = SetName();
            money = SetMoney();
        }
        //public Buyer()
        //{
        //    Money = money;
        //    Name = name;
        //}
        //public int money
        //{
        //    get { return Money; }
        //    set
        //    {
        //        // money = SetMoney();
        //        //if (value > 500)
        //        //{
        //        //    Money = 500;
        //        //}
        //        //else
        //        //{
        //        //    money = value;
        //        //}
        //       Money= SetMoney();
        //    }
        //}

        public int GetMoney()
        {
            return money;
        }
        public int SetMoney()
        {
            Console.WriteLine("How mutch money you get?");
            int m = int.Parse(Console.ReadLine());
            return m;
        }
        public string SetName()
        {
            Console.WriteLine("Write ur name:");
            string name = Console.ReadLine();
            return name;
        }
        public override string ToString()
        {
            return $"Name: {name}, money: {money}";
        }
    }
}
