using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataSource.Entities.Message
{
    public class Message : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string EncryptedText { get; set; }

        public Guid SenderId { get; set; }

        public Guid ReceiverId { get; set; }

        [ForeignKey("ReceiverId")]
        public User.User Receiver { get; set; }
    }
}
