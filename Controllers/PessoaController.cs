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
        // GET: Pessoa - Este método tra a lista com todas as pessoas do BD
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

        // GET: Pessoa/Edit/id - Este método apenas recupera o registro e mostra no formulário para alteração dos dados
        [HttpGet]
        public ActionResult Edit(int id) // Este parâmetro é o ID da pessoa ou PessoaID
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Editar(id);
            return View(pModel);
        }

        // POST: Pessoa/Edit/id - este método salva no BD os dados alterados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaModel pModel)
        {
            pModel.Atualizar();
            return RedirectToAction(nameof(Index));
        }

        // GET: Pessoa/Delete/id
        public ActionResult Delete(int id)
        {
            return RedirectToAction(nameof(Index));
        }

        // POST: Pessoa/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}