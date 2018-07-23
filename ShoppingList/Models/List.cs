using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class List
    {
        public long ListId { get; set; }
        public string ListName { get; set; }

        public long UserGroupId { get; set; }
        public Group UserGroup { get; set; }

        public ICollection<ListItem> ListItems { get; set; }
    }
}
