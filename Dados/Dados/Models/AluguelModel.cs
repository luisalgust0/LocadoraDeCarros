using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
    class AluguelModel
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Efetivado { get; set; }
    }
}
