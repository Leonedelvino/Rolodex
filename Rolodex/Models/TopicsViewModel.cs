using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolodex.Models
{
    public class TopicsViewModel
    {
        public int Id { get; set; }
        public List<RolodexModel> Rolodexes { get; set; }

        public int RolodexCount => Rolodexes.Count;
    }
}
