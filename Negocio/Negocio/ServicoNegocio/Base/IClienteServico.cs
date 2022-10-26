using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ServicoNegocio.Base
{
    public interface IClienteServico
    {
        Cliente ObterClientePorEmail(string email);

        Cliente ObterClientePorId(int id);

        List<Cliente> ObterListaCliente();

        bool InserirCliente(Cliente novoCliente);

        bool EditarCliente(Cliente clienteEditar);

        bool DeletarCliente(int id);
    }
}
