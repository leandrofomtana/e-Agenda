﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Controladores;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;

namespace WindowsFormsApp2
{
    public partial class FormInicio : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        public FormInicio()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormTarefa formTarefa = new FormTarefa();
            formTarefa.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormContato formContato = new FormContato();
            formContato.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCompromisso formCompromisso = new FormCompromisso();
            formCompromisso.Visible = true;
        }
    }
}
