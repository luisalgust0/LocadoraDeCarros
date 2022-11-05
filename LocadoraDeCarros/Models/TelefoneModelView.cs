using LocadoraDeCarros.Models.Base;

namespace LocadoraDeCarros.Models
{
    public class TelefoneModelView : BaseModelView
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NumeroTelefone { get; set; }

    }
}
