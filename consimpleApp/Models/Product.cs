﻿using System;
using System.Collections.Generic;
using System.Text;

namespace consimpleApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
