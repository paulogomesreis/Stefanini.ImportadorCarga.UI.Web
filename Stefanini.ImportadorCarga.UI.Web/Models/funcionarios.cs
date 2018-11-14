using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stefanini.ImportadorCarga.UI.Web.Models
{
    public sealed class Funcionarios
    {
        public int ID { get; set; }
        public int ID_Funcionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }


    }
}