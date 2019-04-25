using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ArticleViewModel
    {
        public List<Article> Articles { get; set; }

        public ArticleViewModel()
        {
            Articles = new List<Article>();
        }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Content { get; set; }
    }
}
