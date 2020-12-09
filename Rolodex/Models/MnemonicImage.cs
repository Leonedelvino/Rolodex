using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolodex.Models
{
    public class MnemonicImage
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Image { get; set; }
        
        public RolodexModel Rolodex { get; set; }
    }
}
