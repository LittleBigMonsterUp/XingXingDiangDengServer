using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualityBusCard.DAL;
namespace VirtualityBusCard.Controllers
{
    public class HomeController : Controller
    {
        private AccountContext db = new AccountContext();
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            ViewBag.Title = "小风谷";
            var virtualityBusCardMessageUser= unitOfWork.VirtualityBusCardMessageUserRepository.Get();
            var virtualityBusCardUser = unitOfWork.VirtualityBusCardUserRepository.Get();
            return View();
        }
    }
}
