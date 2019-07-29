using ConsoleApp_EF.Domain;
using ConsoleApp_EF.Mapping;
using System.Data.Entity;

namespace ConsoleApp_EF.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext() : base("MyConnectionString")
        {
            Database.SetInitializer<MyDataContext>(new Initializer());
        }

        // Faz a ligação com o banco atraves das propriedades
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Override no metododo de criação do banco e adiciona as classes de mapeamento de cada modelo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    

    // Toda vez que o programa rodar vai dropar o DB e criar outro... bom para desenv em inicio.
    public class Initializer : DropCreateDatabaseAlways<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            context.Categories.Add(new Category { Id = 1, Title = "Treinamentos" });
            context.Products.Add(new Product { Id = 1, Title = "EF", Price = 99, CategoryId = 1 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
