using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataSource.Entities.Product
{
    public class Product : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string ImapgePath { get; set; }

        public string Description { get; set; }

        public int Raiting { get; set; }

        public int Views { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category.Category Category { get; set; }
    }
}
