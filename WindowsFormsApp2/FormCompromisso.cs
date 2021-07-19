using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCompromisso : Form
    {
        ControladorCompromisso controlador = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        Compromisso compromissoClicado;
        public FormCompromisso()
        {
            InitializeComponent();
            CarregarCompromissos();
            CarregarContatos();
        }
        
        private void CarregarCompromissos()
        {
           
            dtPassados.Clear();
            dtFuturos.Clear();
            List<Compromisso> contatos = controlador.SelecionarCompromissosPassados(DateTime.Now);
            foreach (var item in contatos)
            {
                DataRow registro = dtPassados.NewRow();
                registro["Id"] = item.Id;
                registro["Assunto"] = item.Assunto;
                registro["Data"] = item.Data;
                registro["HoraInicio"] = item.HoraInicio;
                registro["HoraTermino"] = item.HoraTermino;
                registro["Local"] = item.Local;
                registro["Link"] = item.Link;
                registro["Contato"] = item.Contato;
                dtPassados.Rows.Add(registro);
            }
            contatos = controlador.SelecionarCompromissosFuturos(DateTime.Now, DateTime.Now+new TimeSpan(90,0,0,0));
            foreach (var item in contatos)
            {
                DataRow registro = dtFuturos.NewRow();
                registro["Id"] = item.Id;
                registro["Assunto"] = item.Assunto;
                registro["Data"] = item.Data;
                registro["HoraInicio"] = item.HoraInicio;
                registro["HoraTermino"] = item.HoraTermino;
                registro["Local"] = item.Local;
                registro["Link"] = item.Link;
                registro["Contato"] = item.Contato;
                dtFuturos.Rows.Add(registro);
            }
        }

        private void CarregarContatos()
        {
            cbContatos.Items.Add("Sem Contato");
            var contatos = controladorContato.SelecionarTodos();
            foreach (var contato in contatos)
                cbContatos.Items.Add(contato);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            CarregarCompromissos();
            MessageBox.Show("Compromisso cadastrada com sucesso", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Cadastrar()
        {
    
            string assunto = textBoxAssunto.Text;
            DateTime data = dataPickerData.Value;
            TimeSpan horaInicio = pickerInicio.Value.TimeOfDay;
            TimeSpan horaTermino = pickerTermino.Value.TimeOfDay;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            Contato contato = cbContatos.SelectedItem is Contato ? (Contato)cbContatos.SelectedItem : null;
            Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            MessageBox.Show(controlador.InserirNovo(compromisso));

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
            CarregarCompromissos();
            MessageBox.Show("Compromisso editada com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Editar()
        {
            string assunto = textBoxAssunto.Text;
            DateTime data = dataPickerData.Value;
            TimeSpan horaInicio = pickerInicio.Value.TimeOfDay;
            TimeSpan horaTermino = pickerTermino.Value.TimeOfDay;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            Contato contato = cbContatos.SelectedItem is Contato ? (Contato)cbContatos.SelectedItem : null;
            Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            controlador.Editar(compromissoClicado.Id, compromisso);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            CarregarCompromissos();
            MessageBox.Show("Compromisso excluída com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Excluir()
        {
            controlador.Excluir(compromissoClicado.Id);
        }

        private void dGVPassados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVPassados.CurrentCell.Value != DBNull.Value)
            {
                int id = Convert.ToInt32(dGVPassados.CurrentRow.Cells[0].Value);
                compromissoClicado = controlador.SelecionarPorId(id);
                PreencherCampos();
            }
        }

        private void dGVFuturos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVFuturos.CurrentCell.Value != DBNull.Value)
            {
                int id = Convert.ToInt32(dGVFuturos.CurrentRow.Cells[0].Value);
                compromissoClicado = controlador.SelecionarPorId(id);
                PreencherCampos();
            }
        }

        private void PreencherCampos()
        {
            textBoxAssunto.Text = compromissoClicado.Assunto;
            textBoxLocal.Text = compromissoClicado.Local;
            textBoxLink.Text = compromissoClicado.Link;
            dataPickerData.Value = compromissoClicado.Data;
            cbContatos.Text = compromissoClicado.Contato == null ? "Sem contato" : compromissoClicado.Contato.ToString();
        }
    }
}
