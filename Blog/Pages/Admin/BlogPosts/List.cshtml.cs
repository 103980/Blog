using Blog.Data;
using Blog.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages.Admin.BlogPosts
{
    public class ListModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        public List<BlogPost> BlogPosts { get; set; }

        public ListModel(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        public void OnGet()
        {
            BlogPosts = blogDbContext.BlogPosts.ToList();
        }
    }
}
