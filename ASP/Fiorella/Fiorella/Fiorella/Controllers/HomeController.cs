using System.Linq;
using Fiorella.DataLayerAccess;
using Fiorella.Models;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        
        public IActionResult Index()
        {
            var sliderImages = _dbContext.SliderImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();

            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Include(x => x.Category).ToList();

            var about = _dbContext.AboutImg.SingleOrDefault();
            var aboutText = _dbContext.AboutTexts.SingleOrDefault();

            var experts = _dbContext.Experts.ToList();
            var expertTitle = _dbContext.ExpertTitles.SingleOrDefault();

            var blogTitle = _dbContext.BlogTitles.SingleOrDefault();
            var bloggers = _dbContext.Bloggers.ToList();

            var saysliders = _dbContext.SaySliders.ToList();

            var subscribeImg = _dbContext.SubscribeImg.SingleOrDefault();

            var instagramImgs = _dbContext.InstagramImg.ToList();
            
            
            
            return View(new HomeViewModel
            {
                SliderImages = sliderImages,
                Slider = slider,
                Categories = categories,
                Products = products, 
                About = about,
                AboutText = aboutText,
                Experts = experts,
                ExpertTitle = expertTitle,
                BlogTitle = blogTitle,
                Bloggers = bloggers,
                SaySliders = saysliders,
                SubscribeImg = subscribeImg,
                InstagramImgs = instagramImgs,
            });
        }

        
    }
}