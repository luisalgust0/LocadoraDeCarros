using Negocio.Models;
using Negocio.RepositorioNegocio;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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

        public bool DeletarCliente(Cliente clienteDeletar)
        {
            return _clienteRepositorio.DeletarCliente(clienteDeletar);
        }

        public bool EditarCliente(Cliente clienteEditar)
        {
            return _clienteRepositorio.EditarCliente(clienteEditar);
        }

        public bool InserirCliente(Cliente novoCliente)
        {
            if(_clienteRepositorio.VerificarNomeExiste(novoCliente.Nome))
            {
                throw new Exception("Nome já existente");
            }
            else if(_clienteRepositorio.VerificarCarteiraMotoristaExiste(novoCliente.CarteiraDeMotorista))
            {
                throw new Exception("Carteira Motorista existente");
            }
            else if(_clienteRepositorio.VerificarEmailExiste(novoCliente.Email))
            {
                throw new Exception("Email existente");
            }
            return _clienteRepositorio.InserirCliente(novoCliente);
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
