using BlogApp.Models;
using X.PagedList;

namespace BlogApp.ViewModels
{
    public class HomeVM
    {
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? ThumbnailUrl { get; set; }
        public IPagedList<Post>? Posts { get; set; }
        public List<string>? Categories { get; set; }
    }
}
