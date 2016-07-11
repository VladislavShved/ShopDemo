using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DataSource.Context;

namespace Shop.DataSource.Repositories.User
{
    public class UserRepository : BaseRepository<Entities.User.User>
    {
        public UserRepository(ShopContext context) 
            : base(context)
        {
        }
    }
}
