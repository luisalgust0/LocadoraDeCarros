using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string CartaoDeCredito { get; set; }
        public string CarteiraDeMotorista { get; set; }


        //construtores e injeções
        private readonly IClienteServico _clienteServico;
        public Cliente()
        {

        }
        public Cliente(int id, string nome, string email, int telefone, string endereco, string cartaoDeCredito, string carteiraDeMotorista, IClienteServico clienteServico)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            CartaoDeCredito = cartaoDeCredito;
            CarteiraDeMotorista = carteiraDeMotorista;
            _clienteServico = clienteServico;
        }

        //metodos
        public bool EmailEstaDuplicado()
        {
            return _clienteServico.ObterClientePorEmail(Email) != null;
        }

    }

}
