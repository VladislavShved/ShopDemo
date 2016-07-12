using Autofac;
using Autofac.Integration.Mvc;
using Shop.DataSource.Context;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Entities.Product;
using Shop.DataSource.Entities.User;
using Shop.DataSource.Repositories;
using Shop.DataSource.Repositories.Category;
using Shop.DataSource.Repositories.Product;
using Shop.DataSource.Repositories.User;
using Module = Autofac.Module;

namespace Shop.DependencyResolver
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShopContext>().AsSelf();
            builder.RegisterType<UserRepository>().As<IRepository<User>>();
            builder.RegisterType<ProductReposirory>().As<IRepository<Product>>();
            builder.RegisterType<CategoryRepository>().As<IRepository<Category>>();
        }
    }
}
