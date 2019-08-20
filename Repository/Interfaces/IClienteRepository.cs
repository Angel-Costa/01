using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IClienteRepository
    {
        int Relacionar(Cliente cliente);

        bool Apagar(int idCliente);

        List<Cliente> ObterTodosPeloIdCliente(int idCliente);

        Cliente ObterPeloId(int id);
    }
}
