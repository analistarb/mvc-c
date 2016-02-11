using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Aplicacao;
using Application.Dominio;
using System.Collections.ObjectModel;


namespace Application.UI.Web.Areas.Logins.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Login/


        public ActionResult Index()
        {
            var login = new Login();
            return View(login);
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (login.nm_login == "teste_login")
            {
                Session["usuarioLogadoID"] = "1";
                Session["usuarioLogadoNome"] = "João da Silva";

                TempData["alert"] = "Login realizado com sucesso!!!";

                return RedirectToAction("Index", "Home", new { area = "Alunos" });
            }
            else
            {
                return View(login);
            }

        }


        public ActionResult Sair()
        {
            Session["usuarioLogadoID"] = null;
            Session["usuarioLogadoNome"] = null;
            return RedirectToAction("Index", "Home", new { area = "" });
        }





    }
}
