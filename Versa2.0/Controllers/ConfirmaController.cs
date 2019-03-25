using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Versa2._0.Controllers
{
    public class ConfirmaController : Controller
    {
        // GET: Confirma
        public ActionResult Index()
        {
            var Mensagem = TempData["status"].ToString();

            if (Mensagem == "VSC")
            {
                ViewBag.TipoMensagem = "Nossa equipe já recebeu o seu e-mail, muito obrigado! Faremos uma rápida análise das informações fornecidas e em breve entraremos em contato. Agradecemos a sua confiança!";
            }
            else if (Mensagem == "CV")
            {
                ViewBag.TipoMensagem = "Já sabemos do seu interesse pela cota. Muito obrigado! Entraremos em contato o mais breve possível. Com a Versa Consórcios a negociação é rápida, transparente e segura. Agradecemos a sua confiança!";
            }
            else ViewBag.TipoMensagem = "Seu e-mail foi recebido por nossa equipe e em breve entraremos em contato. Obrigado!";

            return View();
        }
    }
}