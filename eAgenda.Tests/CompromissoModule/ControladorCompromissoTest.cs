using System;

using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {

        ControladorCompromisso controlador = null;


        public ControladorCompromissoTest()
        {
            controlador = new ControladorCompromisso();

            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");

        }

        [TestMethod]
        public void DeveInserir_Compromisso()
        {
            //arrange

            Compromisso novoCompromisso = new Compromisso("limpar a casa", "casa", "",
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);


            //action
            controlador.InserirNovo(novoCompromisso);

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato();

            //arrange
            Contato contato = new Contato("Joao", "joao@gmail.com", "11112222", "Joao LTDA", "Desenvolvedor");
            controladorContato.InserirNovo(contato);


            Compromisso novoCompromisso = new Compromisso("limpar a casa", "casa", "",
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);

            //action
            controlador.InserirNovo(novoCompromisso);


            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveEditar_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato();

            //arrange
            Contato contato = new Contato("Joao", "joao@gmail.com", "11112222", "Joao LTDA", "Desenvolvedor");
            controladorContato.InserirNovo(contato);


            Compromisso novoCompromisso = new Compromisso("limpar a casa", "casa", "",
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);

            Compromisso compromissoEditado = new Compromisso("limpar o banheiro", "banheiro", "",
               new DateTime(2021, 12, 12), new TimeSpan(12, 12, 00), new TimeSpan(13, 13, 00), controladorContato.SelecionarPorId(contato.Id));


            //action
            controlador.InserirNovo(novoCompromisso);
            controlador.Editar(controlador.SelecionarPorId(novoCompromisso.Id).Id, compromissoEditado);


            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromissoEditado.Id);
            compromissoEncontrado.Should().Be(compromissoEditado);
        }

        [TestMethod]
        public void DeveExcluir_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato();

            //arrange
            Contato contato = new Contato("Joao", "joao@gmail.com", "11112222", "Joao LTDA", "Desenvolvedor");
            controladorContato.InserirNovo(contato);


            Compromisso novoCompromisso = new Compromisso("limpar a casa", "casa", null,
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);


            //action
            controlador.InserirNovo(novoCompromisso);
            bool excluir = controlador.Excluir(novoCompromisso.Id);


            //assert

            excluir.Should().Be(true);
        }
    }
}