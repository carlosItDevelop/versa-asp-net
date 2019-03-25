using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Versa2._0.Dal;
using Versa2._0.Funcoes;
using Versa2._0.Models;

namespace Versa2._0.Controllers
{
    public class VendaSuaCotaController : Controller
    {
        // GET: VendaSuaCota
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(EnviarEmail _objModelMail)
        {
            if (ModelState.IsValid)
            {

                EnviarEmails.Enviar(TipoEmail.VendaSuaCota, _objModelMail);
                TempData["status"] = "VSC";

                EMails entityEmail = new EMails();
                entityEmail.es.Connection.Name = "SiteEmpresa";

                entityEmail.Administradora = _objModelMail.Administradora;
                entityEmail.Adicionais = _objModelMail.Adicionais;
                entityEmail.Celular = _objModelMail.Celular;
                entityEmail.Contemplado = _objModelMail.Contemplado;
                entityEmail.Cota = _objModelMail.Cota;
                entityEmail.DataInclusao = DateTime.Now;
                entityEmail.Email = _objModelMail.Email;
                entityEmail.Entrada = _objModelMail.Entrada;
                entityEmail.Grupo = _objModelMail.Grupo;
                entityEmail.Id = Guid.NewGuid();
                entityEmail.Nome = _objModelMail.Nome;
                entityEmail.ParcelasEmAtraso = Convert.ToDecimal(_objModelMail.ParcelasEmAtraso);
                entityEmail.ParcelasPagas = Convert.ToDecimal(_objModelMail.ParcelasPagas);
                entityEmail.SaldoDevedor = Convert.ToDecimal(_objModelMail.SaldoDevedor.Replace("R$", "").Replace(".", ","));
                entityEmail.Telefone = _objModelMail.Telefone;
                entityEmail.TipoConsorcio = _objModelMail.TipoConsorcio;
                entityEmail.TotalParcelas = Convert.ToDecimal(_objModelMail.TotalParcelas.Replace("R$", "").Replace(".", ","));
                entityEmail.ValorDaParcela = Convert.ToDecimal(_objModelMail.ValorDaParcela.Replace("R$", "").Replace(".", ","));
                entityEmail.ValorDoBem = Convert.ToDecimal(_objModelMail.ValorDoBem.Replace("R$", "").Replace(".", ","));
                entityEmail.Save();


                return RedirectToAction("Index", "Confirma");
            }
            else
            {
                return View(_objModelMail);
            }
        }
    }
}