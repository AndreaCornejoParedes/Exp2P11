using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DA_Nro11_SesionExternoGoogle.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var nuevaCookie = ControllerContext.HttpContext.Request.Cookies["valor"];
            var apple = ControllerContext.HttpContext.Request.Cookies["apple"];
            var dell = ControllerContext.HttpContext.Request.Cookies["dell"];
            var lenevo = ControllerContext.HttpContext.Request.Cookies["lenevo"];
            var acer = ControllerContext.HttpContext.Request.Cookies["acer"];
            var sony = ControllerContext.HttpContext.Request.Cookies["sony"];
            var wipro = ControllerContext.HttpContext.Request.Cookies["wipro"];

            if ((nuevaCookie != null)){
                ViewBag.nuevaCookie = nuevaCookie.Value;
            }
            if ((apple != null))
            {
                ViewBag.apple = apple.Value;
            }
            if ((dell != null))
            {
                ViewBag.dell = dell.Value;
            }
            if ((lenevo != null))
            {
                ViewBag.lenevo = lenevo.Value;
            }
            if ((acer != null))
            {
                ViewBag.acer = acer.Value;
            }
            if ((sony != null))
            {
                ViewBag.sony = sony.Value;
            }
            if ((wipro != null))
            {
                ViewBag.wipro = wipro.Value;
            }
            return View();
        }


        [HttpPost] public ActionResult SetCookie(string valor)
        {
            HttpCookie nuevaCookie = new HttpCookie("valor", valor);
            nuevaCookie.Expires = DateTime.Now.AddMinutes(1);
            ControllerContext.HttpContext.Response.SetCookie(nuevaCookie);
            ViewBag.nuevaCookie = valor;

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