using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangLam.Models
{
    public class Comment : BaseModel
    {
        public string Content { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
