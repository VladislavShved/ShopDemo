using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataSource.Entities.User
{
    public class User : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Login { get; set; }

        public byte[] PasswordHash { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Balance { get; set; }

        public virtual ICollection<Message.Message> Messages { get; set; } 
    }
}
