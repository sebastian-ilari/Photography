using Photography.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Photography.Models
{
    public class Picture : DomainObject
    {
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public string FileName { get; set; }

        [NotMapped]
        public string FullPath
        {
            get
            {
                return string.Format("~/Images/{0}", this.FileName);
            }
        }

        [Required]
        [Display(Name = "Picture Type")]
        public PictureType PictureType { get; set; }

        public int Position { get; set; }
        
        [Range(1, 1000)]
        public int Width { get; set; }

        [Range(1, 800)]
        public int Height { get; set; }
    }
}