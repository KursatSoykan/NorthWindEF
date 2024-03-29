﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEF.Models.ORM
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
      

    }
}
