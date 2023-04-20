using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using WebApp.Models.Entities;

namespace WebApp.Helpers;

public static class Seeder
{
    class CategoryProduct
    {
        public CategoryProduct(int categoriesId, int productsId)
        {
            CategoriesId = categoriesId;
            ProductsId = productsId;
        }

        public int CategoriesId { get; set; }
        public int ProductsId { get; set; }
    }

    public static void Seed(ModelBuilder modelBuilder)
    {
        // Seed Roles
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "admin", Name = "Admin" },
            new IdentityRole { Id = "customer", Name = "Customer" }
        );

        // Seed Categories
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "New" },
            new Category { Id = 2, Name = "Featured" },
            new Category { Id = 3, Name = "Popular" }
        );

        var seedData = JArray.Parse(File.ReadAllText(@"Helpers\seed-data.json"));
        var products = new List<Product>();
        foreach (var item in seedData)
        {
            products.Add(item.ToObject<Product>());
        }

        // Create product for seeding
        // for (var i = 1; i <= 20; i++)
        // {
        //     products.Add(
        //         new Product
        //         {
        //             Id = i,
        //             Name = $"Product {i}",
        //             Description = "Synth!",
        //             Image = $"product{i}.jpg",
        //             Price = Random.Shared.Next(50, 100),
        //         });
        // }

        // Seed Products
        modelBuilder.Entity<Product>().HasData(products);

        // Create CategoryProducts for seeding
        var categoryProducts = new List<CategoryProduct>();
        for (var i = 1; i <= 3; i++)
        {
            for (var j = 1 + (i - 1) * 5; j <= 10 + (i - 1) * 5; j++)
            {
                categoryProducts.Add(new CategoryProduct(i, j));
            }
        }

        // Seed joined table: CategoryProduct
        modelBuilder.Entity("CategoryProduct").HasData(categoryProducts);
    }
}