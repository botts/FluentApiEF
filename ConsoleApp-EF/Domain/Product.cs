﻿using System.ComponentModel.DataAnnotations;

namespace ConsoleApp_EF.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
