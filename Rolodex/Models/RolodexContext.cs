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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=Rolodex.Db");
    }
}
