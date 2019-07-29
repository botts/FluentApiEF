using ConsoleApp_EF.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EF.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(x => x.Id);
            Property(x => x.Price).HasColumnType("money").IsRequired();
            Property(x => x.Title).HasMaxLength(60).IsRequired();
            Property(x => x.CategoryId);
        }
    }
}
