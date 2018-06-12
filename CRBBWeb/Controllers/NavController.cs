using CRBBWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBBWeb.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Index()
        {
            List<NavItemViewModel> list = NavXML.GetSelectedXMLNodes();
            list.Sort((x, y) => x.ID.CompareTo(y.ID));
            NavItemsViewModel nivm = new NavItemsViewModel();
            nivm.NotFixedSelectedCount = list.Where(m => !m.Fixed && m.IsSelected).Count();
            nivm.NavItemViewModels = list;
            return PartialView(nivm);
        }

        public ActionResult NavSetter()
        {
            List<NavItemViewModel> list = NavXML.GetXMLNodes();
            list.Sort((x, y) => x.ID.CompareTo(y.ID));
            //JsonResult jr = new JsonResult();
            //jr.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //jr.Data = list;
            return View(list);
        }

        [HttpPost]
        public ActionResult SaveNavSetter(List<NavItemPostModel> navItemViewModelList)
        {
            List<NavItemViewModel> list = new List<NavItemViewModel>();
            navItemViewModelList.RemoveAll(m => m.ID > 0 && m.ID < 5);
            foreach (var item in navItemViewModelList)
            {
                NavItemViewModel nivm = new NavItemViewModel();
                nivm.ID = item.ID;
                nivm.Name = item.Name ?? "";
                nivm.Fixed = item.Fixed == null ? false : true;
                nivm.IsSelected = item.IsSelected == null ? false : true;
                nivm.Url = item.Url ?? "#";
                nivm.Active = item.Active == null ? false : true;
                list.Add(nivm);
            }
            NavXML.WriteXmlNode(list);
            return RedirectToAction("Index", "Home");
        }
    }
}