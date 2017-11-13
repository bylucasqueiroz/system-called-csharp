namespace Apresentacao
{
    partial class FrmChamadoCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNomeDoSolicitante = new System.Windows.Forms.Label();
            this.labelTipoDoChamado = new System.Windows.Forms.Label();
            this.labelDataDoChamado = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelSituação = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.dateDataDoChamado = new System.Windows.Forms.DateTimePicker();
            this.radioResolvido = new System.Windows.Forms.RadioButton();
            this.radioPendente = new System.Windows.Forms.RadioButton();
            this.textBoxNomeDoSolicitante = new System.Windows.Forms.TextBox();
            this.textBoxTipoDoChamado = new System.Windows.Forms.TextBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(10, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";
            // 
            // labelNomeDoSolicitante
            // 
            this.labelNomeDoSolicitante.AutoSize = true;
            this.labelNomeDoSolicitante.Location = new System.Drawing.Point(155, 37);
            this.labelNomeDoSolicitante.Name = "labelNomeDoSolicitante";
            this.labelNomeDoSolicitante.Size = new System.Drawing.Size(38, 13);
            this.labelNomeDoSolicitante.TabIndex = 7;
            this.labelNomeDoSolicitante.Text = "Nome:";
            // 
            // labelTipoDoChamado
            // 
            this.labelTipoDoChamado.AutoSize = true;
            this.labelTipoDoChamado.Location = new System.Drawing.Point(10, 64);
            this.labelTipoDoChamado.Name = "labelTipoDoChamado";
            this.labelTipoDoChamado.Size = new System.Drawing.Size(93, 13);
            this.labelTipoDoChamado.TabIndex = 9;
            this.labelTipoDoChamado.Text = "Tipo do Problema:";
            // 
            // labelDataDoChamado
            // 
            this.labelDataDoChamado.AutoSize = true;
            this.labelDataDoChamado.Location = new System.Drawing.Point(10, 37);
            this.labelDataDoChamado.Name = "labelDataDoChamado";
            this.labelDataDoChamado.Size = new System.Drawing.Size(33, 13);
            this.labelDataDoChamado.TabIndex = 5;
            this.labelDataDoChamado.Text = "Data:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(10, 90);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 11;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelSituação
            // 
            this.labelSituação.AutoSize = true;
            this.labelSituação.Location = new System.Drawing.Point(155, 9);
            this.labelSituação.Name = "labelSituação";
            this.labelSituação.Size = new System.Drawing.Size(52, 13);
            this.labelSituação.TabIndex = 2;
            this.labelSituação.Text = "Situação:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(61, 6);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(88, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TabStop = false;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateDataDoChamado
            // 
            this.dateDataDoChamado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataDoChamado.Location = new System.Drawing.Point(53, 35);
            this.dateDataDoChamado.Name = "dateDataDoChamado";
            this.dateDataDoChamado.Size = new System.Drawing.Size(96, 20);
            this.dateDataDoChamado.TabIndex = 6;
            // 
            // radioResolvido
            // 
            this.radioResolvido.AutoSize = true;
            this.radioResolvido.Checked = true;
            this.radioResolvido.Location = new System.Drawing.Point(213, 7);
            this.radioResolvido.Name = "radioResolvido";
            this.radioResolvido.Size = new System.Drawing.Size(72, 17);
            this.radioResolvido.TabIndex = 3;
            this.radioResolvido.TabStop = true;
            this.radioResolvido.Text = "Resolvido";
            this.radioResolvido.UseVisualStyleBackColor = true;
            // 
            // radioPendente
            // 
            this.radioPendente.AutoSize = true;
            this.radioPendente.Location = new System.Drawing.Point(291, 7);
            this.radioPendente.Name = "radioPendente";
            this.radioPendente.Size = new System.Drawing.Size(71, 17);
            this.radioPendente.TabIndex = 4;
            this.radioPendente.Text = "Pendente";
            this.radioPendente.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeDoSolicitante
            // 
            this.textBoxNomeDoSolicitante.Location = new System.Drawing.Point(200, 34);
            this.textBoxNomeDoSolicitante.Name = "textBoxNomeDoSolicitante";
            this.textBoxNomeDoSolicitante.Size = new System.Drawing.Size(162, 20);
            this.textBoxNomeDoSolicitante.TabIndex = 8;
            // 
            // textBoxTipoDoChamado
            // 
            this.textBoxTipoDoChamado.Location = new System.Drawing.Point(112, 61);
            this.textBoxTipoDoChamado.Name = "textBoxTipoDoChamado";
            this.textBoxTipoDoChamado.Size = new System.Drawing.Size(250, 20);
            this.textBoxTipoDoChamado.TabIndex = 10;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(13, 106);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(349, 170);
            this.richTextBoxDescricao.TabIndex = 12;
            this.richTextBoxDescricao.Text = "";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(206, 282);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(287, 282);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmChamadoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 313);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.textBoxTipoDoChamado);
            this.Controls.Add(this.textBoxNomeDoSolicitante);
            this.Controls.Add(this.radioPendente);
            this.Controls.Add(this.radioResolvido);
            this.Controls.Add(this.dateDataDoChamado);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelSituação);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelDataDoChamado);
            this.Controls.Add(this.labelTipoDoChamado);
            this.Controls.Add(this.labelNomeDoSolicitante);
            this.Controls.Add(this.labelCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChamadoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNomeDoSolicitante;
        private System.Windows.Forms.Label labelTipoDoChamado;
        private System.Windows.Forms.Label labelDataDoChamado;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelSituação;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.DateTimePicker dateDataDoChamado;
        private System.Windows.Forms.RadioButton radioResolvido;
        private System.Windows.Forms.RadioButton radioPendente;
        private System.Windows.Forms.TextBox textBoxNomeDoSolicitante;
        private System.Windows.Forms.TextBox textBoxTipoDoChamado;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}