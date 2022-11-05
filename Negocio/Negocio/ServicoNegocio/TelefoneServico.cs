using Negocio.Models;
using Negocio.RepositorioNegocio;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ServicoNegocio
{
    public class TelefoneServico : ITelefoneServico
    {
        private readonly ITelefoneRepositorio _telefoneRepositorio;

        public TelefoneServico(ITelefoneRepositorio telefoneRepositorio)
        {
            _telefoneRepositorio = telefoneRepositorio;
        }


        public bool InserirTelefone(Telefone telefone)
        {
            return _telefoneRepositorio.InserirTelefone(telefone);
        }

        public List<Telefone> ObterListaTelefone()
        {
            return _telefoneRepositorio.OebterListaTelefone();
        }

        public Telefone ObterTelefonePorId(int id)
        {
            return _telefoneRepositorio.ObterTelefonePorId(id);
        }

        public bool RemoverTelefone(Telefone telefone)
        {
            return _telefoneRepositorio.RemoverTelefone(telefone);
        }
    }
}
