using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsContext _dbContext;

        public NewsController(NewsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int id)
        {
            var news = _dbContext.NewsModel.Find(id);
            return View(news);
        }
    }
}
