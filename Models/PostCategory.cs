using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangLam.Models
{
    public class PostCategory : BaseModel
    {
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
