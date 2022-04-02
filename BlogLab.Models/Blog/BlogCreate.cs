using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        [MinLength(10, ErrorMessage = "Must be  10-50 characteres")]
        [MaxLength(50,ErrorMessage = "Must be  10-50 characteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required!")]
        [MinLength(300, ErrorMessage = "Must be  300-3000 characteres")]
        [MaxLength(3000,ErrorMessage = "Must be  300-3000 characteres")]
        public string Content { get; set; }
        public int PhotoId { get; set; }
    }
}
