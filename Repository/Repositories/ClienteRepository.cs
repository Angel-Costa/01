using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public bool Apagar(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodosPeloIdCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public int Relacionar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
