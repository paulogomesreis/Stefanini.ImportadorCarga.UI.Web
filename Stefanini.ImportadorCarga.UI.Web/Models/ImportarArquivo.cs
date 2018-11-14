using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stefanini.ImportadorCarga.UI.Web.Models
{
    public class ImportarArquivo
    {
        [Required(ErrorMessage = "O Arquivo é obrigatório.")]
        public HttpPostedFileBase Arquivo { get; set; }

        internal String RetornarConteudoArquivo(Stream fileStream)
        {
            String conteudoArquivo;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                conteudoArquivo = reader.ReadToEnd();
            }
            return conteudoArquivo;
        }
    }
}