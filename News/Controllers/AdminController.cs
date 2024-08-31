using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Models;

namespace News.Controllers
{
    public class AdminController : Controller
    {
        private readonly NewsContext _dbContext;

        public AdminController(NewsContext db)
        {
            _dbContext = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(NewsViewModel nvm)
        {
            NewsModel _newsModel = new NewsModel{Description = nvm.Description, Category = nvm.Category, ShortDescription = nvm.ShortDescription };

            byte[] imageData = null;

            if(nvm.Image != null)
            {
                using (var binaryReader = new BinaryReader(nvm.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)nvm.Image.Length);
                }

                _newsModel.Image = imageData;
            }

            if(ModelState.IsValid)
            {
                _dbContext.NewsModel.Add(_newsModel);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
