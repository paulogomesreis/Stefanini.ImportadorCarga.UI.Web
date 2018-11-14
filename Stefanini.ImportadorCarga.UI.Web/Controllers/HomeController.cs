using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stefanini.ImportadorCarga.UI.Web.Models;

namespace Stefanini.ImportadorCarga.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult ImportarArquivo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Importar(ImportarArquivo importarArquivo)
        {
            var conteudo = String.Empty;
            if(ModelState.IsValid)
            {
                conteudo = importarArquivo.RetornarConteudoArquivo(importarArquivo.Arquivo.InputStream);
            }

            var totalColunas = conteudo.Split(';').Length;
            if (importarArquivo.Arquivo.ContentLength > 0)
            {
                ViewData["conteudo"] = conteudo;
                ViewData["totalColunas"] = totalColunas;
                return Content("<b>Conteúdo:</b>" + conteudo + "<br><b>Total de Colunas: </b>" + totalColunas);
            }
                       
            //ViewBag.Message = "Your contact page.";
            return View();

        }
        
    }
}