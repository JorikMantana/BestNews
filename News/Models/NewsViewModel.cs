using Microsoft.AspNetCore.Http;

namespace News.Models
{
    public class NewsViewModel
    {
        public string? Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string? Category { get; set; }
        public IFormFile? Image { get; set; }
    }
}
