using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{


    public class Shop
    {
        
        const string testLoad = "test.txt";
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        // static string filePath = Path.Combine(desktopPath, FILE_NAME);
        //  static string filePathTest = Path.Combine(desktopPath, test);

        static string filePathLoad = Path.Combine(desktopPath, testLoad);
        string[] lines = File.ReadAllLines(filePathLoad);
        public static List<Goods> ListGoods = new List<Goods>();

        //parsing txt 
        public List<Goods> Create()
        {
            foreach (var item in lines)
            {
                string[] columns = item.Split(' ');
                if (columns[1] == "Food")
                {
                    ListGoods.Add(new Food() { Id = int.Parse(columns[0]), Class = columns[1], Name = columns[2], BestBeforeDate = DateTime.Parse(columns[4]), Category = columns[6], Price = int.Parse(columns[8]), Count = int.Parse(columns[10]) });
                }
                else if (columns[1] == "Cloth")
                {
                    ListGoods.Add(new Cloth() { Id = int.Parse(columns[0]), Class = columns[1], Name = columns[2], Category = columns[4], Price = int.Parse(columns[6]), Count = int.Parse(columns[8]) });
                }
                else if (columns[1] == "Chemistry")
                {
                    ListGoods.Add(new Chemistry() { Id = int.Parse(columns[0]), Class = columns[1], Name = columns[2], BestBeforeDate = DateTime.Parse(columns[4]), Category = columns[6], Price = int.Parse(columns[8]), Count = int.Parse(columns[10]) });
                }
            }
            return ListGoods;
        }

        public void AddGood()
        {
            try
            {
                foreach (Goods item in ListGoods)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Add \"Food\", \"Cloth\" or \"Chemistry\":");   //    add conditions for new class
                string GoodsClass = Console.ReadLine();
                int IdAdd;
                do
                {
                    Console.WriteLine("Set Id:");
                    IdAdd = int.Parse(Console.ReadLine());
                } while (ChekId(IdAdd, ListGoods));

                Console.WriteLine("Name:");
                string NameAdd = Console.ReadLine();

                Console.WriteLine("BestBefor:");
                DateTime BestBeforAdd = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Category:");
                string CategoryAdd = Console.ReadLine();
                Console.WriteLine("Price:");
                int PriceAdd = int.Parse(Console.ReadLine());
                Console.WriteLine("Count:");
                int CountAdd = int.Parse(Console.ReadLine());

                if (chek(NameAdd))   // if new good is exists
                {
                    foreach (Goods item in ListGoods)
                    {
                        if (item.Name == NameAdd)
                        {
                            item.Count += CountAdd;
                        }
                    }
                }

                //form of entry new good to list
                else if (GoodsClass == "Food")
                {
                    Food addFood = new Food() { Id = IdAdd, Class = GoodsClass, Name = NameAdd, BestBeforeDate = BestBeforAdd, Category = CategoryAdd, Price = PriceAdd, Count = CountAdd };
                    ListGoods.Add(addFood);
                }
                else if (GoodsClass == "Cloth")
                {
                    Cloth addCloth = new Cloth() { Id = IdAdd, Class = GoodsClass, Name = NameAdd, Category = CategoryAdd, Price = PriceAdd, Count = CountAdd };
                    ListGoods.Add(addCloth);
                }
                else if (GoodsClass == "Chemistry")
                {
                    Chemistry addChemistry = new Chemistry() { Id = IdAdd, Class = GoodsClass, Name = NameAdd, BestBeforeDate = BestBeforAdd, Category = CategoryAdd, Price = PriceAdd, Count = CountAdd };
                    ListGoods.Add(addChemistry);
                }
                //else if
                //{
                //    add conditions for new class
                //}
               
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message); ;
                Console.ResetColor();
            }
        }
       
        public void SaveGood(string path, List<Goods> savelist)
        {
            //File.WriteAllText(path, string.Empty);
            foreach (Goods item in savelist)
            {
                if (item == ListGoods.Last())
                {
                    if (item is Food)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Food)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}").Replace("  ", " "));
                    }
                    else if (item is Cloth)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}").Replace("  ", " "));
                    }
                    else if (item is Chemistry)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Chemistry)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}").Replace("  ", " "));
                    }
                    // File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {(item is Food ? ("BestBefor ").ToString() + ((Food)item).BestBeforeDate.ToString("dd.MM.yyyy") : "")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}").Replace("  ", " "));
                }
                else if (item == ListGoods.First())
                {
                    if (item is Food)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Food)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                    else if (item is Cloth)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                    else if (item is Chemistry)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Chemistry)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                }
                else
                {
                    if (item is Food)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Food)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                    else if (item is Cloth)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                    else if (item is Chemistry)
                    {
                        File.AppendAllText(path, ($"{item.Id.ToString()} {item.Class.ToString()} {item.Name.ToString()} {("BestBefor ").ToString() + ((Chemistry)item).BestBeforeDate.ToString("dd.MM.yyyy")} Category {item.Category} Price {item.Price.ToString()} Count {item.Count.ToString()}\n").Replace("  ", " "));
                    }
                }
            }
        }
        public void CategoryObject()
        {
            string CategoryEnter = SetFinder();
            foreach (Goods item in ListGoods)
            {
                if (item.Category == CategoryEnter)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void FindProduct()
        {
            ShowList(ListGoods);
            string ProductEnter = SetFinder();
            foreach (Goods item in ListGoods)
            {
                if (item.Name == ProductEnter)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void DeletePtoduct()
        {
            ShowList(ListGoods);
            string productName = SetFinder();

            for (int i = 0; i < ListGoods.Count; i++)
            {
                if (ListGoods[i].Name == productName)
                {
                    ListGoods.RemoveAt(i);
                }
            }

        }

        public void Buy()
        {
            try
            {

                Buyer buyer = new Buyer();
                Shop shop = new Shop();
                List<Goods> buyList = new List<Goods>();
                ShowList(ListGoods);
                int total = 0;

                string exit;
                bool exitBool = false;
                do
                {
                    //enter Id and count of goods
                    int t = 0;
                    Console.Write("Enter Id of product:");
                    int idBuy = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter count: ");
                    int countBuy = int.Parse(Console.ReadLine());

                    //find good by Id
                    Goods findGood = ListGoods.Find(i => i.Id == idBuy);

                    //checking money
                    if (buyer.money <= findGood.Price)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not enough money");
                        Console.ResetColor();
                        break;
                    }
                    buyer.money -= findGood.Price * countBuy;
                    t += findGood.Price * countBuy;

                    //cheking count of good
                    if (countBuy > findGood.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not enough goods");
                        Console.ResetColor();
                        break;
                    }

                    findGood.Count -= countBuy;
                    buyList.Add(findGood);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(buyer.ToString() + "\nYour basket:");
                    //bill
                    foreach (Goods item in buyList)
                    {
                        Console.WriteLine($"{item.Name} {item.Count}*{item.Price} ");
                    }
                    Console.WriteLine("Total: " + (total += t));
                    Console.ResetColor();

                    Console.WriteLine("0 - exit. Any key to continue.");
                    exit = Console.ReadLine();
                    if (exit == "0")
                    {
                        exitBool = false;
                    }
                    else
                        exitBool = true;
                } while (exitBool);
                ShowList(ListGoods);
            }
            catch (NullReferenceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong id.");
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
        public void Menu()
        {
            const string PASS = "0000";
            string chooseOperation;
            bool chekOperation = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Shop menu:");
                Console.ResetColor();
                Console.WriteLine("2 - Category.");
                Console.WriteLine("3 - Find Product by Name.");
                Console.WriteLine("5 - Buy.");
                Console.WriteLine("0 - Exit.");
                chooseOperation = Console.ReadLine();
                if (chooseOperation == PASS)
                {
                    do
                    {
                        // Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Admin menu:");
                        Console.ResetColor();

                        Console.WriteLine("1 - Add Product.");
                        Console.WriteLine("2 - Category.");
                        Console.WriteLine("3 - Find Product by Name.");
                        Console.WriteLine("4 - Delete product.");
                        Console.WriteLine("0 - Exit");
                        chooseOperation = Console.ReadLine();
                        //   MenuAdmin(chooseOperation);
                        switch (chooseOperation)
                        {
                            case "1":
                                AddGood();
                                break;
                            case "2":
                                CategoryObject();
                                break;
                            case "3":
                                FindProduct();
                                break;
                            case "4":
                                DeletePtoduct();
                                break;
                            case "0":
                                File.WriteAllText(filePathLoad, string.Empty);
                                SaveGood(filePathLoad, ListGoods);
                                chekOperation = true;
                                break;
                        }
                    } while (chooseOperation != "0");
                }
                else
                {
                    switch (chooseOperation)
                    {

                        case "2":
                            CategoryObject();
                            break;
                        case "3":
                            FindProduct();
                            break;

                        case "5":
                            Buy();
                            break;
                        case "0":
                            File.WriteAllText(filePathLoad, string.Empty);
                            SaveGood(filePathLoad, ListGoods);
                            chekOperation = true;
                            break;
                    }
                }
            } while (chooseOperation != "0");
        }

        public bool ChekId(int a, List<Goods> list)
        {
            bool chekId = false;
            foreach (Goods item in list)
            {
                if (item.Id == a)
                {
                    Console.WriteLine("This Id is exist alredy.");
                    return chekId = true;
                }
            }
            return chekId;
        }
        public string SetFinder()
        {
            Console.WriteLine("Enter what u looking at:");
            string CategoryEnter = Console.ReadLine();
            return CategoryEnter;
        }
        public bool chek(string m)
        {
            foreach (Goods item in ListGoods)
            {
                if (item.Name == m)
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowList(List<Goods> list)
        {
            foreach (Goods item in list)
            {
                Console.WriteLine(item);
            }
        }
        //public bool MenuAdmin(string operation)
        //{
        //    switch (operation)
        //    {
        //        case "1":
        //            AddGood();

        //            return true;
        //            break;
        //        case "2":
        //            CategoryObject();
        //            return true;
        //            break;
        //        case "3":
        //            FindProduct();
        //            return true;
        //            break;
        //        case "4":
        //            DeletePtoduct();
        //            return true;
        //            break;
        //        case "0":
        //            File.WriteAllText(filePathLoad, string.Empty);
        //            SaveGood(filePathLoad, ListGoods);
        //            return true;
        //            break;
        //    }
        //    return false;
        //}
        //public bool MenuClient(string operation)
        //{
        //    switch (operation)
        //    {

        //        case "2":
        //            CategoryObject();
        //            break;
        //        case "3":
        //            FindProduct();
        //            break;

        //        case "5":
        //            Buy();
        //            break;
        //        case "0":
        //            File.WriteAllText(filePathLoad, string.Empty);
        //            SaveGood(filePathLoad, ListGoods);
        //            return true;
        //            break;
        //    }
        //    return false;
        //}
    }
}
