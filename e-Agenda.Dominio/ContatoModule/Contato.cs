using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.ContatoModule
{
    public class Contato : EntidadeBase
    {
        private string nome;
        private string empresa;
        private string cargo;
        private string email;
        private string telefone;

        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Empresa = empresa;
            this.Cargo = cargo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
