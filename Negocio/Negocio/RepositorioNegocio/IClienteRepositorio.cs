using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Negocio.RepositorioNegocio
{
    public interface IClienteRepositorio
    {
        bool VerificarEmailExiste(string email);
        bool VerificarNomeExiste(string nome);
        bool VerificarCarteiraMotoristaExiste(string carteiraMotorista);
        Cliente ObterClientePorId(int id);
        List<Cliente> ObterListaCliente();
        bool InserirCliente(Cliente novoCliente);
        bool EditarCliente(Cliente clienteEditar);
        bool DeletarCliente(Cliente clienteDeletar);
    }
}
