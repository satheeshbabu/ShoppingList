using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ProductCategory
    {
        [Key]
        public long ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
