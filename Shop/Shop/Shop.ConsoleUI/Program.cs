using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Shop.DataSource.Context;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Entities.Product;
using Shop.DataSource.Entities.User;

namespace Shop.ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var shopContext = new ShopContext())
      {
        if (shopContext.Users.Count() != 0)
        {
          shopContext.Set<User>().RemoveRange(shopContext.Users);
        }
        var md5 = MD5.Create();
        var user = new User
        {
          Id = Guid.NewGuid(),
          BirthDate = new DateTime(1994, 12, 25),
          FirstName = "Vlad",
          LastName = "Shved",
          Login = "Sedrik",
          Balance = 100,
          Email = "devil-vlad@yandex.ru",
          PasswordHash = md5.ComputeHash(Encoding.UTF8.GetBytes("qwerty123"))
        };
        shopContext.Users.Add(user);

        if (shopContext.Categories.Count() != 0)
        {
          shopContext.Set<Category>().RemoveRange(shopContext.Categories);
        }
        var category1 = new Category()
        {
          Id = Guid.NewGuid(),
          Name = "Mobile Phones"
        };
        shopContext.Categories.Add(category1);

        var category2 = new Category()
        {
          Id = Guid.NewGuid(),
          Name = "Headphones"
        };
        shopContext.Categories.Add(category2);

        var category3 = new Category()
        {
          Id = Guid.NewGuid(),
          Name = "Shoes"
        };
        shopContext.Categories.Add(category3);

        if (shopContext.Products.Count() != 0)
        {
          shopContext.Set<Product>().RemoveRange(shopContext.Products);
        }
        var product = new Product()
        {
          Id = Guid.NewGuid(),
          Category = category1,
          CategoryId = category1.Id,
          Name = "IPhone 5S",
          Price = 1000,
          ImapgePath = "/Content/images/apple-iphone-5s.jpg",
          Description = "New IPhone 5S",
          Raiting = 4,
          Views = 0
        };

        var product2 = new Product()
        {
          Id = Guid.NewGuid(),
          Category = category1,
          CategoryId = category1.Id,
          Name = "Samsung Galaxy S6",
          Price = 900,
          ImapgePath = "/Content/images/galaxy-s6.jpg",
          Description = "Samsung Galaxy S6",
          Raiting = 3,
          Views = 0
        };

        var product3 = new Product()
        {
          Id = Guid.NewGuid(),
          Category = category1,
          CategoryId = category1.Id,
          Name = "Nexus 5",
          Price = 400,
          ImapgePath = "/Content/images/nexus5.png",
          Description = "Good Nexus 5 with OS Android 6.0",
          Raiting = 5,
          Views = 0
        };

        var product4 = new Product()
        {
          Id = Guid.NewGuid(),
          Category = category1,
          CategoryId = category1.Id,
          Name = "HTC One",
          Price = 700,
          ImapgePath = "/Content/images/HTC-one.jpg",
          Description = "HTC One M8",
          Raiting = 5,
          Views = 0
        };

        var product5 = new Product()
        {
          Id = Guid.NewGuid(),
          Category = category1,
          CategoryId = category1.Id,
          Name = "Nokia 3310",
          Price = 10,
          ImapgePath = "/Content/images/nokia3310.jpg",
          Description = "Strong mobile phone",
          Raiting = 5,
          Views = 0
        };

        shopContext.Products.Add(product);
        shopContext.Products.Add(product2);
        shopContext.Products.Add(product3);
        shopContext.Products.Add(product4);
        shopContext.Products.Add(product5);

        shopContext.SaveChanges();
      }
    }
  }
}
