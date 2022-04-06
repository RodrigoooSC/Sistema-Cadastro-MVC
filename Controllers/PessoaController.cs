using Cadastro_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


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
            if (ModelState.IsValid) // Testa se o Model (Anotação) é valida
            {
                pModel.Salvar();
                return RedirectToAction("Index");
            }
            else
            {
                return View(pModel);
            }
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
        public ActionResult Edit(PessoaModel pModel)
        {
            if (ModelState.IsValid) // Testa se o Model (Anotação) é valida
            {
            pModel.Atualizar();
            return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(pModel);
            }
        }

        // GET: Pessoa/Delete/id - Método realiza a exclusão do registro, passando os dados para o Model PessoaModel
        [HttpGet]
        public ActionResult Delete(int id)
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Excluir(id);
            return RedirectToAction(nameof(Index));
        }
    }
}