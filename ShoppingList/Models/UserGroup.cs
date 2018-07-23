using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class UserGroup
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long GroupId { get; set; }
        public Group Group { get; set; }

    }
}
