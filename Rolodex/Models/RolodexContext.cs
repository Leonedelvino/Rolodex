using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolodex.Models
{
    public class RolodexContext : DbContext
    {
        public DbSet<RolodexModel> Rolodexes { get; set; }
        public DbSet<MnemonicImage> MnemonicImages { get; set; }

        public RolodexContext(DbContextOptions<RolodexContext> options) : base(options)
        {
        }
    }
}
