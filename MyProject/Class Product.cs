using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
   public abstract class Goods
    {
        public string Class { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public abstract override string ToString();
    }

    class Food : Goods
    {
        public DateTime BestBeforeDate { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, {Class}, Name: {Name}, Best Befor: {BestBeforeDate.ToString("dd.MM.yyyy")}, Category: {Category}, Price: {Price}, Count: {Count}";
        }
    }

    class Cloth : Goods
    {
        public override string ToString()
        {
            return $"Id:{Id}, {Class}, Name: {Name},  Category: {Category}, Price: {Price}, Count: {Count}";
        }
      
    }

    class Chemistry : Goods
    {
        public DateTime BestBeforeDate { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, {Class}, Name: {Name}, Best Befor: {BestBeforeDate.ToString("dd.MM.yyyy")}, Category: {Category}, Price: {Price}, Count: {Count}";
        }
    }
}
