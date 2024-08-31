using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        private readonly  NewsContext _dbContext;

        public HomeController(NewsContext db)
        {
           _dbContext = db;
        }

        public IActionResult Index(string category)
        {
            if(category != null)
            {

                var news = _dbContext.NewsModel.Where(c => c.Category == category).ToList();

                return View(news);
            }
            else
            {
                var news = _dbContext.NewsModel.ToList();

                return View(news);
            }
        }
    }
}
