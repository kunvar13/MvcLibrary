﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcLibrary.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
