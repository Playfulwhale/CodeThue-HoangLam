using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HoangLam.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<HoangLam.Models.Post> Post { get; set; }
    }
}
