using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        
        public ICollection<ListItem> ListItems { get; set; }
    }
}
