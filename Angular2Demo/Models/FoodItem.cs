﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2Demo.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime Created { get; set; }
    }
}
