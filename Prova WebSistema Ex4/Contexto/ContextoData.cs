using Prova_WebSistema_Ex4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova_WebSistema_Ex4.Contexto
{
    public class ContextoData : DbContext
    {

        public DbSet<Professor> Professors{ get; set; }
      
    }
}