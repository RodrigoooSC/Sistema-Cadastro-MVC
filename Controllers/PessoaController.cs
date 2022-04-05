using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Cadastro_MVC.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        [HttpGet]
        public ActionResult Index()
        {
            // Criar uma referência para o PessoaModel
            PessoaModel pModel = new PessoaModel();

            // Executar o método Listar()                    

            return View(pModel.Listar());
        }

        // GET: Pessoa/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        [HttpGet]
        public ActionResult Create()
        {
            //A View agora está relacionada com o Modelo
            return View(new PessoaModel());

        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel pModel)
        {            
                pModel.Salvar();

                return RedirectToAction("Index");            
        }

        // GET: Pessoa/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}