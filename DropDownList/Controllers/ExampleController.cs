using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList.Controllers
{
    public class ExampleController : Controller
    {
        public  ActionResult   Index()
        {
            return View();
        }
        public JsonResult check(FormCollection form)
        {
            System.Threading.Thread.Sleep(3000);
            string name = form["username"];

            if (name.Equals("mark"))
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }
    }
}
