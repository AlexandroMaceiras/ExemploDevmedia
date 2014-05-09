using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploDevmedia.Controllers
{
    public class PaginasErroController : Controller
    {
        //
        // GET: /PaginasErro/

        public ActionResult PaginaNaoEncontrada()
        {
            return View();
        }

    }
}
