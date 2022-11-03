using System.Collections.Generic;

namespace LocadoraDeCarros.Models.Base
{
    public class ListaViewModel <T> : BaseModelView
    {
        public IEnumerable<T> Lista { get; set; }
    }
}
