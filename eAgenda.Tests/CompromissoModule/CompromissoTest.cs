using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveValidar_Campos()
        {
            Compromisso compromisso = new Compromisso("limpar a casa", "casa", null,
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");

        }

        [TestMethod]
        public void DeveValidar_Assunto()
        {
            Compromisso compromisso = new Compromisso(null, "a", null,
                new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Assunto é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_Data()
        {

            Compromisso compromisso = new Compromisso("Valida", "Data", null,
                DateTime.MinValue, new TimeSpan(0, 15, 30), new TimeSpan(0, 19, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Data é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_HoraInicio()
        {

            Compromisso compromisso = new Compromisso("Valida", "Horainicio", null,
               new DateTime(2021, 07, 01), TimeSpan.MinValue, new TimeSpan(0, 19, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Início é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_HoraFim()
        {

            Compromisso compromisso = new Compromisso("Valida", "Horafim", null,
               new DateTime(2021, 07, 01), new TimeSpan(0, 15, 30), TimeSpan.MinValue, null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Término é obrigatório");

        }
    }
}