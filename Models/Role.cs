using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangLam.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
