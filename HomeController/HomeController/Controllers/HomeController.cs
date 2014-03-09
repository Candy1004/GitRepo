using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeController.Models;

namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {
            return "Navegar a una URL para mostrar un ejemplo";
        }

        public ViewResult AutoProperty()
        {
            //Crear un uevo objeto
            // Dela clase producto

            Produc myProduct = new Produc
            {

            //Establece el valor de la propiedad
            ProductID = 12,
            Name = "Kayak",
            Description = "kiosteca Blue",
            Category = "SPORTS",
            Price = 12.5f
        };
            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                 myProduct.ProductID,
                 myProduct.Name,
                 myProduct.Description,
                 myProduct.Category,
                 myProduct.Price);


            //Genera la vista
            return View("Result",
                (object)salida);

        }
    }
}
