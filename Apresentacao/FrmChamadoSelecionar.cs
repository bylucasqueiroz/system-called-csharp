using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmChamadoSelecionar : Form
    {
        public FrmChamadoSelecionar()
        {
            InitializeComponent();
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            ChamadoNegocios chamadoNegocios = new ChamadoNegocios();

            ChamadoCollection chamadoCollection = new ChamadoCollection();

            chamadoCollection = chamadoNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = chamadoCollection;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se há algum registro selecionado

            if(dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Atenção! Nenhum chamado selecionado.");
                return;
            }

            //Pergunta de Exclusão 
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o Chamado selecionado no grid
            Chamado chamadoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Chamado);

            //Instanciar a regra negócio
            ChamadoNegocios chamadoNegocios = new ChamadoNegocios();

            //Chamar metódo Excluir
            string retorno = chamadoNegocios.Excluir(chamadoSelecionado);

            //Verificar se Excluiu
            //Se o retorno for um número, é porquê deu certo!
            try
            {
                int idChamado = Convert.ToInt32(retorno);

                MessageBox.Show("Chamado Excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir! Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            //Instanciar o Formulário de Cadastro

            FrmChamadoCadastrar frmChamadoCadastrar = new FrmChamadoCadastrar(AcaoNaTela.Inserir, null);
            frmChamadoCadastrar.ShowDialog();
            DialogResult dialogResult = frmChamadoCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se há algum registro selecionado

            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Atenção! Nenhum chamado selecionado.");
                return;
            }

            //Pegar o Chamado selecionado no grid
            Chamado chamadoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Chamado);

            //Instanciar o Formulário de Cadastro

            FrmChamadoCadastrar frmChamadoCadastrar = new FrmChamadoCadastrar(AcaoNaTela.Alterar, chamadoSelecionado);
            frmChamadoCadastrar.ShowDialog();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //Verificar se há algum registro selecionado

            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Atenção! Nenhum chamado selecionado.");
                return;
            }

            //Pegar o Chamado selecionado no grid
            Chamado chamadoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Chamado);

            //Instanciar o Formulário de Cadastro

            FrmChamadoCadastrar frmChamadoCadastrar = new FrmChamadoCadastrar(AcaoNaTela.Consultar, chamadoSelecionado);

            DialogResult resultado = frmChamadoCadastrar.ShowDialog();
            if(resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }
    }
}
