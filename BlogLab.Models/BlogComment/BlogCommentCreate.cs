using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int ParentBlogCommentId { get; set; }
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is required!")]
        [MinLength(300, ErrorMessage = "Must be  10-300 characteres")]
        [MaxLength(300, ErrorMessage = "Must be  10-300 characteres")]
        public string content { get; set; }

    }
}
