using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    class Aluguel
    {
        public int Id { get; private set; }
        public int CarroId { get; private set; }
        public int ClienteId { get; private set; }
        public DateTime DataReserva { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public bool Efetivado { get; private set; }
    }
}
