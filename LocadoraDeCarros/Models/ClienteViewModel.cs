using LocadoraDeCarros.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Models
{
    public class ClienteViewModel : BaseModelView
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string CartaoDeCredito { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string CarteiraDeMotorista { get; set; }
    }
}
