using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ABPort.Models;

namespace AB3.Models
{
    public class AB3Context : DbContext
    {
        public AB3Context (DbContextOptions<AB3Context> options)
            : base(options)
        {
        }

        public DbSet<ABPort.Models.Project> Project { get; set; }
        public DbSet<ABPort.Models.Image> Image { get; set; }
        public DbSet<ABPort.Models.Category> Category { get; set; }
    }
}
