using Negocio.Models;
using Negocio.RepositorioNegocio;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Dados.Contexts;
using Dados.Models;
using System.Linq;

namespace Dados.RepositorioDados
{
    public class TelefoneRepositorio : ITelefoneRepositorio
    {
        private readonly IMapper _mapper;
        private readonly LocadoraDbContext _context;
        public TelefoneRepositorio(IMapper mapper,LocadoraDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool InserirTelefone(Telefone telefone)
        {
          _context.Telefone.Add(_mapper.Map<TelefoneModel>(telefone));
          _context.SaveChanges();
          return true;
        }

        public Telefone ObterTelefonePorId(int id)
        {
            return _mapper.Map<Telefone>(_context.Telefone.FirstOrDefault(x => x.Id == id)); 
        }

        public List<Telefone> OebterListaTelefone()
        {
            return _mapper.Map<List<Telefone>>(_context.Telefone.AsEnumerable());
        }

        public bool RemoverTelefone(Telefone telefone)
        {
            TelefoneModel telefoneModel = _mapper.Map<TelefoneModel>(telefone);
            _context.Telefone.Remove(telefoneModel);
            _context.SaveChanges();
            return true;
        }
    }
}
