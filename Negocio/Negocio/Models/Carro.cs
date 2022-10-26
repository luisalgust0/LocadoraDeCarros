using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    class Carro
    {
        public int Id { get; private set; }
        public string Placa { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public string Categoria { get; private set; }
    }
}
