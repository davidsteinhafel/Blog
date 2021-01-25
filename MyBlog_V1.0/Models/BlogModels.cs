using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog_V1._0.Models
{
    public class BlogModels
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Blog Text")]
        public string Body { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Author")]
        public string Author { get; set; }
        [ForeignKey("IdentityModels")]
        public ApplicationUser ApplicationUserId { get; set; }
    }
}