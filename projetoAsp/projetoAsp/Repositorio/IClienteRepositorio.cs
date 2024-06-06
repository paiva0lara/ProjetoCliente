using MySqlX.XDevAPI;
using projetoCliente.Models;

namespace projetoCliente.Repositorio
{
    public interface IClienteRepositorio
    {
        //CRUD
        IEnumerable<Cliente> TodosClientes();

        void Cadastrar(Cliente cliente);
    }
}
