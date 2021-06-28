using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.CompromissoModule
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto;
        public string Local;
        public DateTime Data;
        public TimeSpan HoraInicio;
        public TimeSpan HoraTermino;
        public string LinkOnline;
        public Contato contato;

        public Compromisso(string assunto, string local, string linkOnline, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            LinkOnline = linkOnline;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            this.contato = contato;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
