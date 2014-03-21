using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ViewResult Index() //es una vista que renderea en ViewResult
        {
            return View();
        }

        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            //var Controller = (string)RouteData.Values["controller"];
            //var Action= (string)RouteData.Values["action"];
            //var model = PetManagement.GetByNameI(name);
            //if (model == null)
                return RedirectToAction("NotFound");
            //return View(model);

        }

        public ActionResult NotFound()
        {
            return View();
        }

        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\Dulcerito\Pictures/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);

        }

    }
}
