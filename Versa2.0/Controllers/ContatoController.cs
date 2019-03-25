using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Versa2._0.Funcoes;
using Versa2._0.Models;

namespace Versa2._0.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(EnviarEmail _objModelMail)
        {
            _objModelMail.TotalParcelas = "1";
            _objModelMail.Administradora = "Administradora";
            if (ModelState.IsValid)
            {
                EnviarEmails.Enviar(TipoEmail.Contato, _objModelMail);
                TempData["status"] = "CONTATO";
                return RedirectToAction("Index", "Confirma");
            }
            return View();

        }
    }
}