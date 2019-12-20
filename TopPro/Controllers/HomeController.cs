using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopPro.Domain.Model;
using TopPro.Service.MA001Service;

namespace TopPro.Controllers
{
    public class HomeController : Controller
    {
        private  IMA001Service _ma001Service;

        public HomeController(IMA001Service ma001Service)
        {
            this._ma001Service = ma001Service;
        }
        public ActionResult Index()
        {
            var a = _ma001Service.GetAll();
            MA001 model = new MA001();
            model.MAIDCD = "2";
            _ma001Service.Insert(model);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}