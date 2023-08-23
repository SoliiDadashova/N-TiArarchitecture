using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entites
{
    public class Category:BaseEntity
    {
        public string Categoryname { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
