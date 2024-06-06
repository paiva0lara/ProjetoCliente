using Microsoft.AspNetCore.Mvc;
using projetoCliente.Models;
using projetoCliente.Repositorio;

namespace projetoCliente.Controllers
{
    public class ClienteController : Controller
    {
        // ILogger permite retornar erros e avisos dos nossos sistemas de forma simples e fácil
        private readonly ILogger<ClienteController> _logger;
        private IClienteRepositorio ? _clienteRepositorio;
        // criando um metodo para receber a interface do looger e do repositorio cliente

        public ClienteController(ILogger<ClienteController> logger, IClienteRepositorio clienteRepositorio)
        {
            _logger = logger;
            _clienteRepositorio = clienteRepositorio;

        }

        public IActionResult Cliente()
        {//retornando o repositorio com metodo todosClientes
            return View(_clienteRepositorio.TodosClientes());
        }


        //Página Cadastro Cliente
        public IActionResult CadCliente()
        { //retorna a pagina
            return View();
        }


        //Página Cadastro Cliente que envia os dados(post)
        [HttpPost]
        public IActionResult CadCliente(Cliente cliente)
        {
            //metodo cadastra
            //
            _clienteRepositorio.Cadastrar(cliente);

            //redireciona para index
            return RedirectToAction(nameof(Index));
        }
    }
}
