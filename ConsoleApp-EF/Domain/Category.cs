using System.Collections.Generic;

namespace ConsoleApp_EF.Domain
{
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
