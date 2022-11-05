using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NumeroTelefone { get; set; }

    }
}
