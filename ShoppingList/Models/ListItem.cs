﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class ListItem
    {
        [Key]
        long ListItemId { get; set; }

        public int Qty { get; set; }

        public long ListId { get; set; }
        public List List { get; set; }

        public int ProductId { get; set; }
        public Product product { get; set; }

    }
}
