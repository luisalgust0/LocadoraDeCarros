using Negocio.Models;
using Negocio.RepositorioNegocio;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Dados.Models;
using Dados.Contexts;

namespace Dados.RepositorioDados
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IMapper _mapper;
        private readonly LocadoraDbContext _context;

        public ClienteRepositorio(IMapper mapper, LocadoraDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public bool DeletarCliente(int id)
        {
            // logica de acesso a dados
            return true;
        }

        public bool EditarCliente(Cliente clienteEditar)
        {
            _mapper.Map<ClienteModel>(clienteEditar);
            //logica de acesso a dados

            return true;
        }

        public bool InserirCliente(Cliente novoCliente)
        {
            _mapper.Map<ClienteModel>(novoCliente);
            // logica de acesso a dados

            return true;
        }

        public Cliente ObterClientePorEmail(string email)
        {
            ClienteModel clienteModel = new ClienteModel();
            // logica de acesso a dados
            return _mapper.Map<Cliente>(clienteModel);
        }

        public Cliente ObterClientePorId(int id)
        {
            ClienteModel clienteModel = new ClienteModel();
            // logica de acesso a dados
            return _mapper.Map<Cliente>(clienteModel);
        }

        public List<Cliente> ObterListaCliente()
        {
            List<ClienteModel> listaClienteModel = new List<ClienteModel>();
            return _mapper.Map<List<Cliente>>(listaClienteModel);
        }
    }
}
