using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmChamadoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmChamadoCadastrar(AcaoNaTela acaoNaTela, Chamado chamado)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if(acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Chamado";
            }
            else if(acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Chamado";

                textBoxCodigo.Text = chamado.IdChamados.ToString();
                textBoxNomeDoSolicitante.Text = chamado.NomeDoSolicitante;
                textBoxTipoDoChamado.Text = chamado.TipoDeChamado;
                dateDataDoChamado.Value = chamado.DataDoChamado;
                richTextBoxDescricao.Text = chamado.DescricaoDoChamado;
                if (chamado.Situacao == true)
                    radioResolvido.Checked = true;
                else
                    radioPendente.Checked = true;
            }
            else if(acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Chamado";

                //Carregar campos da tela

                textBoxCodigo.Text = chamado.IdChamados.ToString();
                textBoxNomeDoSolicitante.Text = chamado.NomeDoSolicitante;
                textBoxTipoDoChamado.Text = chamado.TipoDeChamado;
                dateDataDoChamado.Value = chamado.DataDoChamado;
                richTextBoxDescricao.Text = chamado.DescricaoDoChamado;
                if (chamado.Situacao == true)
                    radioResolvido.Checked = true;
                else
                    radioPendente.Checked = true;

                //Desabilitar Campos da Tela

                textBoxNomeDoSolicitante.ReadOnly = true;
                textBoxNomeDoSolicitante.TabStop = false;

                textBoxTipoDoChamado.ReadOnly = true;
                textBoxTipoDoChamado.TabStop = false;

                dateDataDoChamado.Enabled = false;

                richTextBoxDescricao.ReadOnly = true;
                richTextBoxDescricao.TabStop = false;

                radioPendente.Enabled = false;
                radioResolvido.Enabled = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";

                buttonCancelar.Focus();
                
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.No;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração

            if(acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Chamado chamado = new Chamado();
                chamado.NomeDoSolicitante = textBoxNomeDoSolicitante.Text;
                chamado.TipoDeChamado = textBoxTipoDoChamado.Text;
                chamado.DataDoChamado = dateDataDoChamado.Value;
                chamado.DescricaoDoChamado = richTextBoxDescricao.Text;
                if (radioResolvido.Checked == true)
                    chamado.Situacao = true;
                else
                    chamado.Situacao = false;

                ChamadoNegocios chamadoNegocios = new ChamadoNegocios();
                string retorno = chamadoNegocios.Inserir(chamado);

                //Tenta converter para inteiro 
                try
                {
                    int idChamado = Convert.ToInt32(retorno);

                    MessageBox.Show("Chamado inserido com Sucesso! Código: " + idChamado.ToString());

                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir! Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                //Crio um Chamado

                Chamado chamado = new Chamado();

                //Colocar os campos na tela no objeto chamado, e alterar no banco

                chamado.IdChamados = Convert.ToInt32(textBoxCodigo.Text);
                chamado.NomeDoSolicitante = textBoxNomeDoSolicitante.Text;
                chamado.TipoDeChamado = textBoxTipoDoChamado.Text;
                chamado.DataDoChamado = dateDataDoChamado.Value;
                chamado.DescricaoDoChamado = richTextBoxDescricao.Text;
                if (radioResolvido.Checked == true)
                    chamado.Situacao = true;
                else
                    chamado.Situacao = false;

                ChamadoNegocios chamadoNegocios = new ChamadoNegocios();
                string retorno = chamadoNegocios.Alterar(chamado);

                //Tenta converter para inteiro 

                try
                {
                    int idChamado = Convert.ToInt32(retorno);

                    MessageBox.Show("Chamado alterado com Sucesso! Código: " + idChamado.ToString());

                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar! Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }

        }
    }
}
