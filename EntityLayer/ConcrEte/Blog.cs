using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ConcrEte
{
   public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public string ThumbnailImage { get; set; }
        public int Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
