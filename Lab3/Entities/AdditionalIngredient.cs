﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class AdditionalIngredient
    {
        public int Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Count { get; set; }
    }
}