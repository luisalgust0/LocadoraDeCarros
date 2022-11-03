using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Negocio.RepositorioNegocio
{
    public interface IClienteRepositorio
    {
        Cliente ObterClientePorEmail(string email);
        Cliente ObterClientePorId(int id);
        List<Cliente> ObterListaCliente();
        bool InserirCliente(Cliente novoCliente);
        bool EditarCliente(Cliente clienteEditar);
        bool DeletarCliente(Cliente clienteDeletar);
    }
}
