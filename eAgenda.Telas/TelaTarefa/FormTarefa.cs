using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class FormTarefa : Form
    {
        ControladorTarefa controladorT = new ControladorTarefa();
        Tarefa tarefaClicada;
        public FormTarefa()
        {
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            dtTarefaPendente.Clear();
            dtTarefaConcluida.Clear();
            List<Tarefa> tarefas = controladorT.SelecionarTodasTarefasPendentes();
              foreach (var item in tarefas)
            {
                DataRow registro = dtTarefaPendente.NewRow();
                registro["Id"] = item.Id;
                registro["Titulo"] = item.Titulo;
                registro["DataCriacao"] = item.DataCriacao;
                registro["DataConclusao"] = item.DataConclusao;
                registro["Prioridade"] = item.Prioridade;
                registro["Percentual"] = item.Percentual;
                dtTarefaPendente.Rows.Add(registro);
            }
           tarefas = controladorT.SelecionarTodasTarefasConcluidas();
            foreach (var item in tarefas)
            {
                DataRow registro = dtTarefaConcluida.NewRow();
                registro["Id"] = item.Id;
                registro["Titulo"] = item.Titulo;
                registro["DataCriacao"] = item.DataCriacao;
                registro["DataConclusao"] = item.DataConclusao;
                registro["Prioridade"] = item.Prioridade;
                registro["Percentual"] = item.Percentual;
                dtTarefaConcluida.Rows.Add(registro);
                
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            CarregarTarefas();
            MessageBox.Show("Tarefa cadastrada com sucesso", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Cadastrar()
        {
            string titulo = textBoxTitulo.Text;
            string prioridadeTxt = comboBoxPrioridade.Text;
            int prioridade;
            if (prioridadeTxt == "Alta")
                prioridade = 2;
            else if (prioridadeTxt == "Média")
                prioridade = 1;
            else
                prioridade = 0;
                DateTime dataInicio = dataPickerCriacao.Value;
            int percentual = Int32.Parse(textBoxPercentual.Text);
            Tarefa tarefa = new Tarefa(titulo, dataInicio, (PrioridadeEnum)prioridade);
            controladorT.InserirNovo(tarefa);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
            CarregarTarefas();
            MessageBox.Show("Tarefa editada com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Editar()
        {
            string titulo = textBoxTitulo.Text;
            string prioridadeTxt = comboBoxPrioridade.Text;
            int prioridade;
            if (prioridadeTxt == "Alta")
                prioridade = 2;
            else if (prioridadeTxt == "Média")
                prioridade = 1;
            else
                prioridade = 0;
            DateTime dataInicio = dataPickerCriacao.Value;
            int percentual = Int32.Parse(textBoxPercentual.Text);
            Tarefa registro = new Tarefa(titulo, dataInicio, (PrioridadeEnum)prioridade);
            controladorT.Editar(tarefaClicada.Id, registro);
            controladorT.AtualizarPercentual(tarefaClicada.Id, percentual);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            CarregarTarefas();
            MessageBox.Show("Tarefa excluída com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Excluir()
        {
            controladorT.Excluir(tarefaClicada.Id);
        }

        private void dGVPendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVPendentes.CurrentCell.Value!=DBNull.Value)
            {
                int id = Convert.ToInt32(dGVPendentes.CurrentRow.Cells[0].Value);
                tarefaClicada = controladorT.SelecionarPorId(id);
                PreencherCampos();
            }
        }

        private void dGVConcluidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVConcluidas.CurrentCell.Value != DBNull.Value)
            {
                int id = Convert.ToInt32(dGVConcluidas.CurrentRow.Cells[0].Value);
            tarefaClicada = controladorT.SelecionarPorId(id);
            PreencherCampos();
            }
        }

        private void PreencherCampos()
        {
            textBoxTitulo.Text = tarefaClicada.Titulo;
            textBoxPercentual.Text = tarefaClicada.Percentual.ToString();
            comboBoxPrioridade.SelectedIndex = tarefaClicada.Prioridade.Chave;
            dataPickerCriacao.Value = tarefaClicada.DataCriacao;
        }
    }
}
