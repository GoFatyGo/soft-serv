using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
   public class Sale
    {
        public string name { get; set; }
        public string good { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public int total { get; set; }

       public Sale(Buyer buyer, Goods good, int c, int t)
        {
            name = buyer.name;
            this.good = good.Name;
            price = good.Price;
            count = c;
            total = t;
        }
        public int Total()
        {
            int t = 0;
            t = price * count;
           return total += t;
        }

        public override string ToString()
        {
            return $"Name:{name}, Good:{good}*{count} {total}";
        }

        //  const string FILE_NAME = "Incoming.txt";
        //  const string test = "Incoming test.txt";
        //  const string testLoad = "test.txt";
        //  static  string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //static  string filePath = Path.Combine(desktopPath, FILE_NAME);
        //  static string filePathTest = Path.Combine(desktopPath, test);
        //  static string filePathLoad = Path.Combine(desktopPath, testLoad);

        //    static Shop shop = new Shop();
        //    List<Goods> WorkList = shop.Create();
        //    List<Goods> buyList = new List<Goods>();

        //    public void Buy()
        //    {
        //        string exit;
        //        bool exitBool = false;
        //       // bool boolCountBuy = true;
        //        Buyer buyer = new Buyer();
        //        List<Goods> buyList = new List<Goods>();
        //        do
        //        {
        //            foreach (Goods item in WorkList)
        //            {
        //                Console.WriteLine(item);
        //            }

        //            Console.Write("Enter Id of product:");
        //            int IdBuy = int.Parse(Console.ReadLine());
        //            Console.Write("\nEnter count: ");
        //            int CountBuy = int.Parse(Console.ReadLine());

        //            Goods find = WorkList.Find(i => i.Id == IdBuy);
        //            // Console.WriteLine(find.ToString());
        //            find.Count = find.Count - CountBuy;
        //            buyer.Money = buyer.Money - find.Price * CountBuy;

        //            buyList.Add(find);
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine(buyer.ToString());
        //            foreach (var item in buyList)
        //            {
        //                Console.WriteLine(item);
        //            }
        //            Console.ResetColor();

        //            Console.WriteLine("0 - exit. Any key to continue.");
        //            exit = Console.ReadLine();
        //            if (exit == "0")
        //            {
        //                exitBool = false;
        //            }
        //            else
        //                exitBool = true;
        //        } while (exitBool);
        //        foreach (var item in WorkList)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        //  File.WriteAllText(filePathLoad, string.Empty);
        //        //  shop.SaveProduct(filePathLoad, WorkList);
        //    }
        //    public void Sell()
        //    {

        //        string ChooseOperation;
        //        bool chekOperation = false;
        //        do
        //        {
        //            foreach (Goods item in WorkList)
        //            {
        //                Console.WriteLine(item);
        //            }
        //            Console.WriteLine("1 - Add Product.");
        //            Console.WriteLine("2 - Category.");
        //            Console.WriteLine("3 - Find Product by Name.");
        //            Console.WriteLine("4 - Delete product.");
        //            Console.WriteLine("5 - Buy");
        //            Console.WriteLine("0 - Exit");
        //            ChooseOperation = Console.ReadLine();
        //            switch (ChooseOperation)
        //            {
        //                case "1":
        //                    shop.AddGood();
        //                    break;
        //                case "2":
        //                    shop.CategoryObject();
        //                    break;
        //                case "3":
        //                    shop.FindProduct();
        //                    break;
        //                case "4":
        //                    shop.DeletePtoduct();
        //                    break;
        //                case "5":
        //                    Sell();
        //                    break;
        //                case "0":
        //                    //File.WriteAllText(filePathLoad, string.Empty);
        //                    // shop.SaveProduct(filePathLoad, WorkList);
        //                    chekOperation = true;
        //                    break;
        //            }
        //        } while (!chekOperation);
        //    }
        //}
    }
}
