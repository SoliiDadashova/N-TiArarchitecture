using DataAccessLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.DTOs
{
    public class UpdateCategoryDTO:BaseEntity
    {
        public string CategoryName { get; set; }

    }
}
