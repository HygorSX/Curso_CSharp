using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DesafioAcessoDados.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
