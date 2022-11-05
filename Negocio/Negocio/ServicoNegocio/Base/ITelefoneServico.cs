using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ServicoNegocio.Base
{
    public interface ITelefoneServico
    {
        bool InserirTelefone(Telefone telefone);
        bool RemoverTelefone(Telefone telefone);
        Telefone ObterTelefonePorId(int id);
        List<Telefone> ObterListaTelefone();
    }
}
