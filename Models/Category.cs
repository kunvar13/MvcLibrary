using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

    }
}
