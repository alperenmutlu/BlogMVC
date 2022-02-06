using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogMVC.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            newsLetterManager.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}
