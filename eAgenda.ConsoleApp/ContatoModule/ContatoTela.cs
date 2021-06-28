using eAgenda.Controladores;
using eAgenda.Dominio;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.ContatoModule
{
    public class TelaContato : TelaCadastroBasico<Contato>, ICadastravel
    {
        public readonly ControladorContato controladorContato;

        public TelaContato(ControladorContato controladorContato)
            : base("Cadastro de Tarefas", controladorContato)
        {
            this.controladorContato = controladorContato;
        }

        public override void ApresentarTabela(List<Contato> registros)
        {
            string configuracaColunasTabela = "{0,-5} | {1,-20} | {2,-25} | {3, -20} | {4,-25} | {5,-10}";

            MontarCabecalhoTabela(configuracaColunasTabela, "Id", "Nome", "Empresa", "Cargo", "Email", "Telefone");

            foreach (Contato contato in registros)
            {
                Console.WriteLine(configuracaColunasTabela, contato.Id, contato.Nome, contato.Empresa, contato.Cargo, contato.Email, contato.Telefone);

            }
            Console.ReadLine();
        }

        public override Contato ObterRegistro(TipoAcao tipoAcao)
        {
        Console.Write("Digite o nome do contato: ");
        string nome = Console.ReadLine();


        string email;
        do
        {
            Console.Write("Digite o email do contato: ");
            email = Console.ReadLine();

            if (!email.Contains(".com"))
                ApresentarMensagem("Por favor digite um endereço de email válido!", TipoMensagem.Atencao);

        } while (!email.Contains(".com"));

        Console.Write("Digite o número de telefone do contato: ");
        string telefone = Console.ReadLine();

        Console.Write("Digite o nome da empresa do contato: ");
        string empresa = Console.ReadLine();

        Console.Write("Digite o cargo do contato: ");
        string cargo = Console.ReadLine(); ;

        return new Contato(nome, email, telefone, empresa, cargo);
    }
    }
}