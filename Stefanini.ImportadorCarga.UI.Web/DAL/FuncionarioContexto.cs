using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Stefanini.ImportadorCarga.UI.Web.Models;

namespace Stefanini.ImportadorCarga.UI.Web.DAL
{
    public class FuncionarioContexto : DbContext

    {
        public FuncionarioContexto() : base("FuncionarioContexto")
        {

        }

        public DbSet<Funcionarios> funcionarios { get; set; }
        public DbSet<Funcionario_Produto> funcionario_Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}