using ConsoleApp_EF.DataContext;
using ConsoleApp_EF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyDataContext db = new MyDataContext())
            {
                foreach (Product product in db.Products)
                {
                    Console.WriteLine(product.Title);
                }
            }
        }
    }
}
