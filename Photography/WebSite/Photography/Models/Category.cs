using Photography.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Category : DomainObject
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [Display(Name="Display Type")]
        public DisplayType DisplayType { get; set; }

        public virtual IList<Picture> Pictures { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public int Position { get; set; }

        public bool Visible { get; set; }
    }
}