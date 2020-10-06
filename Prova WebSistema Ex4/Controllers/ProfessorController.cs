using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prova_WebSistema_Ex4.Contexto;
using Prova_WebSistema_Ex4.Models;

namespace Prova_WebSistema_Ex4.Controllers
{
    public class ProfessorController : Controller
    {
        private ContextoData db = new ContextoData();


        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Telefone,Endereco,Disciplina,Email")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                await db.SaveChangesAsync();
            }

            return View(professor);
        }
    
    }
}
