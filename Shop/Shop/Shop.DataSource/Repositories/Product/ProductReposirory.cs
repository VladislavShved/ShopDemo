using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DataSource.Context;

namespace Shop.DataSource.Repositories.Product
{
    public class ProductReposirory : BaseRepository<Entities.Product.Product>
    {
        public ProductReposirory(ShopContext context) : base(context)
        {
        }
    }
}
