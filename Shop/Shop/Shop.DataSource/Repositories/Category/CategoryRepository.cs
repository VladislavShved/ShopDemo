using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DataSource.Context;

namespace Shop.DataSource.Repositories.Category
{
    public class CategoryRepository : BaseRepository<Entities.Category.Category>
    {
        public CategoryRepository(ShopContext context)
            : base(context)
        {
        }
    }
}
