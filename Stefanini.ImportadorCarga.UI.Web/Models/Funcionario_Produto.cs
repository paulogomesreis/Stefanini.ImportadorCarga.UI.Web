using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stefanini.ImportadorCarga.UI.Web.Models
{
    public sealed class Funcionario_Produto
    {
        public int ID { get; set; }
        public int ID_Funcionario { get; set; }
        public int ID_Produto { get; set; }
        public string Desc_Produto { get; set; }
    }
}