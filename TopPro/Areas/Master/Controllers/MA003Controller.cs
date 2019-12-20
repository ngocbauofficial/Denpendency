using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopPro.Service.MA003Service;

namespace TopPro.Areas.Master.Controllers
{
    public class MA003Controller : Controller
    {
        #region Fields
        private readonly IMA003Service _ma003Service;

        #endregion
        // GET: Master/MA003
        public ActionResult Index()
        {
            return View();
        }
    }
}