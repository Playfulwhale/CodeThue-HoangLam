using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangLam.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
