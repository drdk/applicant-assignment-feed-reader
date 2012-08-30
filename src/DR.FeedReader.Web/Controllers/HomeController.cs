using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DR.FeedReader.RssFeedRepository.Contract;

namespace DR.FeedReader.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRssFeedArticleRepository _rssFeedArticleRepository;

        public HomeController(IRssFeedArticleRepository rssFeedArticleRepository)
        {
            _rssFeedArticleRepository = rssFeedArticleRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
