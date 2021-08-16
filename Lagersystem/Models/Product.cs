﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lagersystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }



    }
}