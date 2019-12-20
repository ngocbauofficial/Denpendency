using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopPro.Domain.Model;
using TopPro.Extesions;
using TopPro.Service.MA002Service;

namespace TopPro.Areas.Master.Controllers
{
    public class MA002Controller : Controller
    {
        #region Fields
        private readonly IMA002Service _ma002Service;
        #endregion


        #region Ctor
        public MA002Controller(IMA002Service ma002Service)
        {
            this._ma002Service = ma002Service;
        }
        #endregion
        // GET: Master/MA002
        public ActionResult Index()
        {
            ViewData["message-success"] = "Message";
            return View();
        }
        [HttpPost]
        public ActionResult List(string Search, int draw, int start, int length)
        {
            var model = _ma002Service.GetAll( start,  length);
            DataTableData dataTableData = new DataTableData();
            dataTableData.draw = draw;
            dataTableData.recordsTotal = model.TotalCount;
            dataTableData.data = model.ToList();
            dataTableData.recordsFiltered = model.TotalCount;
            return Json(dataTableData);
        }
        public ActionResult Edit(int id)
        {
          var model =  _ma002Service.GetById(id);
          return View(model);
        }
    }
}