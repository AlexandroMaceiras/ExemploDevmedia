using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploDevmedia.Models;

namespace ExemploDevmedia.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        ClienteRepositorio clienteRepositorio;

        public ClienteController()
        {
            clienteRepositorio = RepositorioFactory.InstanciarRepositorio();
        }

        public ActionResult Index()
        {
            var clientes = clienteRepositorio.RetornarTodos();
            return View(clientes);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var cli = clienteRepositorio.RetornarTodos().OrderByDescending(c => c.Id).First();
                cliente.Id = cli.Id + 1;
                clienteRepositorio.inserir(cliente);

                var clientes = clienteRepositorio.RetornarTodos();

                return View("Index", clientes);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Alterar(int id)
        {
            var cli = clienteRepositorio.RetornarPorID(id);
            return View(cli);
        }


        [HttpPost]
        public ActionResult Alterar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteRepositorio.alterar(cliente);

                var clientes = clienteRepositorio.RetornarTodos();
                TempData["Mensagem"] = "Usuário ALTERADO com sucesso!";
                return View("Index", clientes);
            }
            else
            {
                return View(cliente);
            }
        }

        public ActionResult Excluir(int id)
        {
            var cli = clienteRepositorio.RetornarPorID(id);
            return View(cli);
        }


        [HttpPost, ActionName("Excluir")]
        public ActionResult Excluir(Cliente cliente)
        {
            clienteRepositorio.excluir(cliente);

            var clientes = clienteRepositorio.RetornarTodos();
            TempData["Mensagem"] = "Usuário EXCLUIDO com sucesso!";
            return View("Index", clientes);
        }

        /* 
         * ActionName("Excluir") não é necessário, só use se não estiver usando "Excluir","Cliente" no BeginForm
         * da View Excluir, ou se este o action aqui chamado Excluir da ClienteController.cs tiver outro nome diferente 
         * deste atual sua view Excluir.
         * Como este action chama-se Excluir e tem um atributto [HttpPost] não necessita de nada disto.
         */

    }
}
