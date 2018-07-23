using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Group
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }

        public IList<UserGroup> UserGroups { get; set; }
        public ICollection<List> Lists { get; set; }
    }
}
