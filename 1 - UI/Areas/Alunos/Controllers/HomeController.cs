using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Aplicacao;
using Application.Dominio;
using System.Collections.ObjectModel;


namespace Application.UI.Web.Areas.Alunos.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var appAluno = new AlunoAplicacao();
            var listaDeAlunos = appAluno.ListarTodos();
            return View(listaDeAlunos);
        }


        public ActionResult Cadastrar()
        {
            var appRaca = new RacaAplicacao();
            var raca = appRaca.ListarTodos();
            ViewBag.raca = raca;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Aluno aluno)
        {
            var appRaca = new RacaAplicacao();
            var raca = appRaca.ListarTodos();
            ViewBag.raca = raca;


            if (string.IsNullOrEmpty(aluno.Mae))
            {
                ModelState.AddModelError("Nome da Mae", "O campo nome da mae é obrigatório");
            }
            if (aluno.nm_senha != aluno.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas não conferem");
            }


            if (ModelState.IsValid)
            {
                var appAluno = new AlunoAplicacao();
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }


        public ActionResult Editar(string id)
        {
            var appAluno = new AlunoAplicacao();
            var aluno = appAluno.ListarPorId(id);

            var appRaca = new RacaAplicacao();
            var raca = appRaca.ListarTodos();
            ViewBag.raca = raca;


            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Aluno aluno)
        {

            if (string.IsNullOrEmpty(aluno.Mae))
            {
                ModelState.AddModelError("Nome da Mae", "O campo nome da mae é obrigatório");
            }
            if (aluno.nm_senha != aluno.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas não conferem");
            }


            if (ModelState.IsValid)
            {
                var appAluno = new AlunoAplicacao();
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);

        }



        public ActionResult Detalhes(string id)
        {
            var appAluno = new AlunoAplicacao();
            var aluno = appAluno.ListarPorId(id);

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }


        public ActionResult Excluir(string id)
        {
            var appAluno = new AlunoAplicacao();
            var aluno = appAluno.ListarPorId(id);

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }



        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            var appAluno = new AlunoAplicacao();
            appAluno.Excluir(id);
            return RedirectToAction("Index");
        }





        public ActionResult ValidarCpf(string nr_cpf)
        {
            int Id = 0;

            if (nr_cpf.Replace(".","").Replace("-","").Length <= 11)
            {
                Id = 1;
            }
            else
            {
                Id = 0;
            }

            var retorno = (Id > 0);

            return Json(retorno, JsonRequestBehavior.AllowGet);
        }


        public ActionResult LoginUnico(string nm_usuario)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
                {
                    "Rafael",
                    "Anderson",
                    "Renata"
                };

            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != nm_usuario.ToLower()), JsonRequestBehavior.AllowGet);
        }
 



    }
}
