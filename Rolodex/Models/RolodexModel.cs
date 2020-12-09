using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rolodex.Models
{
    public class RolodexModel
    {
        [Required]
        public string Title { get; set; }

        public string PlateColor { get; set; }

        public byte[] Cover { get; set; }

        public int MnemonicImageId { get; set; }

        public List<MnemonicImage> MnemonicImages { get; set; }
    }
}