using eAgenda.Controladores.ContatoModule;
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
    public partial class FormContato : Form
    {
        ControladorContato controlador = new ControladorContato();
        Contato contatoClicado;
        public FormContato()
        {
            InitializeComponent();
            CarregarContatos();
        }

        private void dGVContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarContatos()
        {
            tbContato.Clear();
            List<Contato> contatos = controlador.SelecionarTodos();
            foreach (var item in contatos)
            {
                DataRow registro = tbContato.NewRow();
                registro["Id"] = item.Id;
                registro["Nome"] = item.Nome;
                registro["Email"] = item.Email;
                registro["Telefone"] = item.Telefone;
                registro["Cargo"] = item.Cargo;
                registro["Empresa"] = item.Empresa;
                tbContato.Rows.Add(registro);
            }
        }

            private void btnCadastrar_Click(object sender, EventArgs e)
            {
                Cadastrar();
                CarregarContatos();
                MessageBox.Show("Contato cadastrado com sucesso", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            private void Cadastrar()
            {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;
            string cargo = textBoxCargo.Text;
            string empresa = textBoxEmpresa.Text;
            Contato contato = new Contato(nome, email, telefone, cargo, empresa);
            controlador.InserirNovo(contato);

            }

            private void btnEditar_Click(object sender, EventArgs e)
            {
                Editar();
                CarregarContatos();
                MessageBox.Show("Contato editado com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            private void Editar()
            {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;
            string cargo = textBoxCargo.Text;
            string empresa = textBoxEmpresa.Text;
            Contato contato = new Contato(nome, email, telefone, cargo, empresa);
            controlador.Editar(contatoClicado.Id, contato);
            }

            private void btnExcluir_Click(object sender, EventArgs e)
            {
                Excluir();
                CarregarContatos();
                MessageBox.Show("Contato excluído com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            private void Excluir()
            {
                controlador.Excluir(contatoClicado.Id);
            }


            private void PreencherCampos()
            {
            textBoxNome.Text = contatoClicado.Nome;
            textBoxEmail.Text = contatoClicado.Email;
            textBoxTelefone.Text = contatoClicado.Telefone;
            textBoxCargo.Text = contatoClicado.Cargo;
            textBoxEmpresa.Text = contatoClicado.Empresa;
        }

        private void dGVContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVContatos.CurrentCell.Value != DBNull.Value)
            {
                int id = Convert.ToInt32(dGVContatos.CurrentRow.Cells[0].Value);
                contatoClicado = controlador.SelecionarPorId(id);
                PreencherCampos();
            }
        }
    }
}
