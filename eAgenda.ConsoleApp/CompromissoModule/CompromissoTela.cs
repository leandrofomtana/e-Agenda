using eAgenda.ConsoleApp.ContatoModule;
using eAgenda.Controladores;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.ConsoleApp.CompromissoModule
{
     public class TelaCompromisso : TelaCadastroBasico<Compromisso>, ICadastravel
    {
        public readonly TelaContato telaContato;
        public readonly ControladorCompromisso controladorCompromisso;
        public TelaCompromisso(TelaContato telaContato, ControladorCompromisso controladorCompromisso)
            : base("Cadastro de Tarefas", telaContato, controladorCompromisso)
        {
            this.telaContato = telaContato;
            this.controladorCompromisso = controladorCompromisso;
        }
        public override void ApresentarTabela(List<Compromisso> registros)
        {
            string configuracaColunasTabela = " {0,-2} | {1,-15} | {2,-10} | {3, -10} | {4,-10} | {5,-10}" +
                " | {6,-10} | {7,-15} | {8, -2} \n";

            MontarCabecalhoTabela(configuracaColunasTabela, "Id", "Assunto", "Local", "Link", "Data", 
                "HoraInicio", "HoraTermino","Nome Contato","Id Contato");

            foreach (Compromisso c in registros)
            {
                string contatoNome = "";
                int contatoId = 0;
                if (c.contato != null)
                {
                    contatoNome = c.contato.Nome;
                    contatoId = c.contato.Id;
                }
                Console.WriteLine(configuracaColunasTabela, c.Id, c.Assunto, c.Local, c.LinkOnline,
                    c.Data.ToShortDateString(), c.HoraInicio.ToString(@"hh\:mm"), c.HoraTermino.ToString(@"hh\:mm")
                    , contatoNome, contatoId);
            }
            Console.ReadLine();
        }

        public override bool VisualizarRegistros(TipoVisualizacao tipo)
        {
            if (tipo == TipoVisualizacao.Pesquisando)
                return base.VisualizarRegistros(TipoVisualizacao.VisualizandoTela);

            if (tipo == TipoVisualizacao.VisualizandoTela)
                ConfigurarTela(SubtituloDeVisualizacao());

            string opcao = ObterOpcao();
            if (opcao=="1")
            VisualizarCompromissosPassados();
            if(opcao=="2")
            VisualizarCompromissosFuturos();

            return true;
        }

        private void VisualizarCompromissosPassados()
        {
            Console.WriteLine("\nCompromissos Passados:\n");
            var compromissosPassados = controladorCompromisso.SelecionarTodosQueJaOcorreram();
            if (compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso passado", TipoMensagem.Atencao);
            else 
                ApresentarTabela(compromissosPassados);
        }

        private void VisualizarCompromissosFuturos()
        {
            Console.WriteLine("\nCompromissos Futuros:\n");
            var compromissosFuturos = controladorCompromisso.SelecionarTodosQueVaoOcorrer();
            if (compromissosFuturos.Count == 0)
                ApresentarMensagem("Nenhum compromisso futuro", TipoMensagem.Atencao);
            else
            {
                Console.WriteLine("Você deseja filtrar por um período?(1 se sim, outra tecla se não)");
                string filtrar = Console.ReadLine();
                if (filtrar == "1")
                {
                    Console.WriteLine("Digite a data inicial do período a ser filtrado");
                    DateTime data1 = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a data final do período a ser filtrado");
                    DateTime data2 = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine($"Mostrando compromissos entre" +
                        $" {data1.ToShortDateString()} e {data2.ToShortDateString()}");
                    ApresentarTabela(compromissosFuturos.FindAll(x => x.Data >= data1 && x.Data <= data2));

                    
                }
                else
                    ApresentarTabela(compromissosFuturos);
            }
        }

        public override Compromisso ObterRegistro(TipoAcao tipoAcao)
        {
            Console.WriteLine("Digite o assunto do compromisso: ");        
        string assunto = Console.ReadLine();

            string linkOnline = "";
            string local = "";
            int escolha;
            do
            {
                Console.WriteLine("O compromisso é presencial(digite 1) ou online(digite 0)? ");
                escolha = Int32.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Digite o local do compromisso");
                    local = Console.ReadLine();
                }
                if (escolha == 0)
                {
                    Console.WriteLine("Digite o link da reunião online");
                    linkOnline = Console.ReadLine();
                }
            } while (escolha != 1 && escolha != 0);
            Console.WriteLine("Insira a data do compromisso(dd/mm/aaaa)");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora e minuto de início do compromisso(hh:mm)");
            TimeSpan horaInicio = DateTime.Parse(Console.ReadLine()).TimeOfDay;
            Console.WriteLine("Insira a hora e minuto de término do compromisso(hh:mm)");
            TimeSpan horaTermino = DateTime.Parse(Console.ReadLine()).TimeOfDay;
            telaContato.VisualizarRegistros(TipoVisualizacao.VisualizandoTela);
            Console.ReadLine();
            Console.WriteLine("Digite o ID do contato do compromisso ou 0 para não escolher ninguém");
            int escolha2 = Int32.Parse(Console.ReadLine());
            Contato contato;
            if (escolha2 != 0) {
                if (telaContato.controladorContato.Existe(escolha2))
                    contato = telaContato.controladorContato.SelecionarPorId(escolha2);
                else
                    contato = null;
            }
            else
                contato = null;
            Compromisso compromisso = new Compromisso(assunto, local, linkOnline, data,
                horaInicio, horaTermino, contato);
            return compromisso;
        }

        private new string ObterOpcao()
        {
            Console.WriteLine("Digite 1 para ver compromissos passados");
            Console.WriteLine("Digite 2 para ver compromissos futuros");

            Console.WriteLine("Digite S para Voltar");
            Console.WriteLine();

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
