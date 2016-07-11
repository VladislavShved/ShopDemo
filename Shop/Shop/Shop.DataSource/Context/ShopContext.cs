using System;
using System.Collections.Generic;
using System.Data.Entity;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Entities.Message;
using Shop.DataSource.Entities.Product;
using Shop.DataSource.Entities.User;

namespace Shop.DataSource.Context
{
    public class ShopContext : DbContext 
    {
        public ShopContext()
            : base("ShopContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(m => m.Products)
                .WithRequired(m => m.Category)
                .HasForeignKey(m => m.CategoryId);
        }

        public IDbSet<User> Users { get; set; }
        
        public IDbSet<Product> Products { get; set;}

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Message> Messages { get; set; }
    }
}
