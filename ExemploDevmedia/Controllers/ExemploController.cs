using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploDevmedia.Controllers
{
    public class ExemploController : Controller
    {
        //
        // GET: /Exemplo/

        public string Index()
        {
            return "Hello World";
        }

        public string Teste()
        {
            return "Hello World Teste";
        }

        public ActionResult TesteComView()
        {
            ViewBag.Qualquercoisa = "Qualquer Coisa";
            return View();
        }


    }
}
