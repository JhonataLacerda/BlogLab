using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Photo
{
    public class PhotoCreate
    {
        public string ImageUrl { get; set; }
        public string PublicId { get; set; }
        public String Description { get; set; }
    }
}
