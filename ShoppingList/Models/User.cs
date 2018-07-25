using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }

        public IList<UserGroup> UserGroups { get; set; }
    }
}   
