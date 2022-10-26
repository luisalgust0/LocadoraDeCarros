using Negocio.Models;
using Negocio.RepositorioNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ServicoNegocio.Base
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public bool DeletarCliente(int id)
        {
            return _clienteRepositorio.DeletarCliente(id);
        }

        public bool EditarCliente(Cliente clienteEditar)
        {
            return _clienteRepositorio.EditarCliente(clienteEditar);
        }

        public bool InserirCliente(Cliente novoCliente)
        {
            return _clienteRepositorio.InserirCliente(novoCliente);
        }

        public Cliente ObterClientePorEmail(string email)
        {
            return _clienteRepositorio.ObterClientePorEmail(email);
        }

        public Cliente ObterClientePorId(int id)
        {
            return _clienteRepositorio.ObterClientePorId(id);
        }

        public List<Cliente> ObterListaCliente()
        {
            return _clienteRepositorio.ObterListaCliente();
        }

    }
}
