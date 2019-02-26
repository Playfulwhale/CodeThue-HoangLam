using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangLam.Models
{
    public class Post : BaseModel
    {
        public string Title { get; set; }
        public string Decriptions { get; set; }


        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int PostCategoryId { get; set; }
        public virtual PostCategory PostCategory { get; set; }

        public virtual List<Image> Images { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
