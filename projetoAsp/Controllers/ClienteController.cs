using Microsoft.AspNetCore.Mvc;
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
    }
}
