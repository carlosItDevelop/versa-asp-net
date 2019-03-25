using Consorcio.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Versa2._0.Funcoes;
using Versa2._0.Models;

namespace Versa2._0.Controllers
{
    public class CotasVendaController : Controller
    {
        // GET: CotasVenda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult ListaCotas(char tipo)
        {
            CotasVendaCollection entityCotas = new CotasVendaCollection();

            GerConsorcio entitySistema = new GerConsorcio();
            entitySistema.es.Connection.Name = "Midiaone";

            GerTpcota entityTipo = new GerTpcota();
            entityTipo.es.Connection.Name = "Midiaone";

            entityCotas.LoadAll();
            var cotas = new CotasAVenda();
            var cotasList = new List<CotasAVenda>();
            foreach (var item in entityCotas)
            {
                cotas = new CotasAVenda();
                entitySistema.LoadByPrimaryKey((int)item.AdministradoraId);
                cotas.Id = (Guid)item.Id;
                cotas.Administradora = entitySistema.Nome;
                cotas.Credito = (decimal)item.Credito;
                cotas.Valor = (decimal)item.Valor;
                cotas.NumParcela = (int)item.NumParcela;
                cotas.Parcela = (decimal)item.Parcela;
                //entityTipo = new GerTpcota();
                entityTipo.LoadByPrimaryKey((int)item.TipoCota);
                cotas.TipoCota = entityTipo.str().Nome;
                cotas.IdTipoCota = entityTipo.TipoSite;
                cotas.DemaisParcelas = (decimal)item.DemaisParcelas;
                cotas.INCC = item.Incc;
                // cotas.TipoCota = (TipoCota)item.TipoCota;
                cotas.Grupo = item.Grupo;
                cotas.Cota = item.Cota;
                cotasList.Add(cotas);
            }
            ViewData["Selecao"] = tipo;
            return PartialView("_ListaCotas", cotasList.Where(c => c.IdTipoCota == tipo));

        }

        [AllowAnonymous]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CotasVenda cotasVenda = new CotasVenda();
            cotasVenda.LoadByPrimaryKey((Guid)id);


            GerConsorcio entitySistema = new GerConsorcio();
            entitySistema.es.Connection.Name = "Midiaone";

            GerTpcota entityTipoCota = new GerTpcota();
            entityTipoCota.es.Connection.Name = "Midiaone";
            entityTipoCota.LoadByPrimaryKey((int)cotasVenda.TipoCota);


            entitySistema.LoadByPrimaryKey((int)cotasVenda.AdministradoraId);
            string strValorParcela = String.Format("{0:C}", cotasVenda.Parcela);
            EnviarEmail CotasEmail = new EnviarEmail
            {
                Administradora = entitySistema.Nome,
                Credito = (decimal)cotasVenda.Credito,
                TotalParcelas = cotasVenda.NumParcela.ToString(),
                ValorDaParcela = strValorParcela,
                ValorDoBem = cotasVenda.Valor.ToString(),
                Entrada = (decimal)cotasVenda.Valor,
                Grupo = cotasVenda.Grupo,
                TipoConsorcio = entityTipoCota.Nome,
                Cota = cotasVenda.Cota

            };

            return View(CotasEmail);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Details(EnviarEmail _objModelMail)
        {
            if (ModelState.IsValid)
            {

                EnviarEmails.Enviar(TipoEmail.CotasAVenda, _objModelMail);
                TempData["status"] = "CV";
                return RedirectToAction("Index", "Confirma");

            }
            else
            {
                return View();
            }
        }

    }
}