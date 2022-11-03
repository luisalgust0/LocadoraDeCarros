using Negocio.Models;
using Negocio.RepositorioNegocio;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Dados.Models;
using Dados.Contexts;
using System.Linq;

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

        public bool DeletarCliente(Cliente clienteDeletar)
        {
            ClienteModel clienteDeletarModel = _mapper.Map<ClienteModel>(clienteDeletar);
            _context.Cliente.Remove(clienteDeletarModel);
            _context.SaveChanges();
            return true;
        }

        public bool EditarCliente(Cliente clienteEditar)
        {
            ClienteModel clienteModelEditar = _mapper.Map<ClienteModel>(clienteEditar);
            _context.Cliente.Update(clienteModelEditar);
            _context.SaveChanges();
            return true;
        }

        public bool InserirCliente(Cliente novoCliente)
        {
            _context.Add(_mapper.Map<ClienteModel>(novoCliente));
            _context.SaveChanges();
            return true;
        }

        public Cliente ObterClientePorEmail(string email)
        {
            return _mapper.Map<Cliente>(_context.Cliente.FirstOrDefault(cliente => cliente.Email == email));
        }

        public Cliente ObterClientePorId(int id)
        {            
            return _mapper.Map<Cliente>(_context.Cliente.FirstOrDefault(cliente => cliente.Id == id));
        }

        public List<Cliente> ObterListaCliente()
        {
            return _mapper.Map<List<Cliente>>(_context.Cliente.AsEnumerable());
        }
    }
}
