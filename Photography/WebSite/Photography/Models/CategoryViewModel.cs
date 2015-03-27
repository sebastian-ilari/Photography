using System.Collections.Generic;

namespace Photography.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string BackgroundImagePath { get; set; }

        public IEnumerable<string> BackgroundImagePathList { get; set; }

        public string CoverImagePath { get; set; }

        public IEnumerable<string> ThumbnailImagePathList { get; set; }
    }
}