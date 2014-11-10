namespace OrdemServico.Forms
{
    partial class form_CadastroCliente
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.gp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.gp_DadosOrdemServico = new System.Windows.Forms.GroupBox();
            this.lbl_DataEntrega = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.MaskedTextBox();
            this.txt_DataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.txt_Instrumento = new System.Windows.Forms.TextBox();
            this.txt_NumeroSerial = new System.Windows.Forms.TextBox();
            this.lbl_Instrumento = new System.Windows.Forms.Label();
            this.lbl_Serial = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Servicos = new System.Windows.Forms.Label();
            this.lbl_Observacao = new System.Windows.Forms.Label();
            this.lbl_ProblemaReclamado = new System.Windows.Forms.Label();
            this.txt_Servicos = new System.Windows.Forms.TextBox();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.txt_ProblemaReclamado = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.gp_DadosPessoais.SuspendLayout();
            this.gp_DadosOrdemServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Nome.Location = new System.Drawing.Point(260, 62);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(553, 34);
            this.txt_Nome.TabIndex = 2;
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(21, 42);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(34, 17);
            this.lbl_CPF.TabIndex = 1;
            this.lbl_CPF.Text = "CPF";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Celular.Location = new System.Drawing.Point(21, 116);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(80, 17);
            this.lbl_Celular.TabIndex = 1;
            this.lbl_Celular.Text = "Tel. Celular";
            // 
            // txt_Celular
            // 
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Celular.Location = new System.Drawing.Point(24, 135);
            this.txt_Celular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Celular.Mask = "(00) 0000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(220, 34);
            this.txt_Celular.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tel. Fixo";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Telefone.Location = new System.Drawing.Point(260, 135);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telefone.Mask = "(00) 0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(195, 34);
            this.txt_Telefone.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Email.Location = new System.Drawing.Point(470, 135);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(343, 34);
            this.txt_Email.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(467, 115);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 17);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email";
            // 
            // gp_DadosPessoais
            // 
            this.gp_DadosPessoais.Controls.Add(this.txt_CPF);
            this.gp_DadosPessoais.Controls.Add(this.lbl_Nome);
            this.gp_DadosPessoais.Controls.Add(this.txt_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.txt_Nome);
            this.gp_DadosPessoais.Controls.Add(this.txt_Celular);
            this.gp_DadosPessoais.Controls.Add(this.label1);
            this.gp_DadosPessoais.Controls.Add(this.lbl_CPF);
            this.gp_DadosPessoais.Controls.Add(this.lbl_Email);
            this.gp_DadosPessoais.Controls.Add(this.lbl_Celular);
            this.gp_DadosPessoais.Controls.Add(this.txt_Email);
            this.gp_DadosPessoais.Location = new System.Drawing.Point(36, 34);
            this.gp_DadosPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_DadosPessoais.Name = "gp_DadosPessoais";
            this.gp_DadosPessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_DadosPessoais.Size = new System.Drawing.Size(851, 205);
            this.gp_DadosPessoais.TabIndex = 20;
            this.gp_DadosPessoais.TabStop = false;
            this.gp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CPF.Location = new System.Drawing.Point(24, 61);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(220, 34);
            this.txt_CPF.TabIndex = 1;
            this.txt_CPF.TextChanged += new System.EventHandler(this.txt_CPF_TextChanged);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(257, 43);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(45, 17);
            this.lbl_Nome.TabIndex = 8;
            this.lbl_Nome.Text = "Nome";
            // 
            // gp_DadosOrdemServico
            // 
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_DataEntrega);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_Valor);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_DataEntrega);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_Instrumento);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_NumeroSerial);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_Instrumento);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_Serial);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_Valor);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_Servicos);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_Observacao);
            this.gp_DadosOrdemServico.Controls.Add(this.lbl_ProblemaReclamado);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_Servicos);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_Observacao);
            this.gp_DadosOrdemServico.Controls.Add(this.txt_ProblemaReclamado);
            this.gp_DadosOrdemServico.Location = new System.Drawing.Point(36, 261);
            this.gp_DadosOrdemServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_DadosOrdemServico.Name = "gp_DadosOrdemServico";
            this.gp_DadosOrdemServico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_DadosOrdemServico.Size = new System.Drawing.Size(851, 244);
            this.gp_DadosOrdemServico.TabIndex = 22;
            this.gp_DadosOrdemServico.TabStop = false;
            this.gp_DadosOrdemServico.Text = "Dados do Ordem de Servico";
            // 
            // lbl_DataEntrega
            // 
            this.lbl_DataEntrega.AutoSize = true;
            this.lbl_DataEntrega.Location = new System.Drawing.Point(467, 156);
            this.lbl_DataEntrega.Name = "lbl_DataEntrega";
            this.lbl_DataEntrega.Size = new System.Drawing.Size(136, 17);
            this.lbl_DataEntrega.TabIndex = 22;
            this.lbl_DataEntrega.Text = "Previsão de entrega";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(648, 175);
            this.txt_Valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(174, 34);
            this.txt_Valor.TabIndex = 11;
            // 
            // txt_DataEntrega
            // 
            this.txt_DataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataEntrega.Location = new System.Drawing.Point(470, 175);
            this.txt_DataEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DataEntrega.Mask = "00/00/0000";
            this.txt_DataEntrega.Name = "txt_DataEntrega";
            this.txt_DataEntrega.Size = new System.Drawing.Size(162, 34);
            this.txt_DataEntrega.TabIndex = 11;
            this.txt_DataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Instrumento
            // 
            this.txt_Instrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Instrumento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Instrumento.Location = new System.Drawing.Point(24, 175);
            this.txt_Instrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Instrumento.Name = "txt_Instrumento";
            this.txt_Instrumento.Size = new System.Drawing.Size(250, 34);
            this.txt_Instrumento.TabIndex = 9;
            // 
            // txt_NumeroSerial
            // 
            this.txt_NumeroSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroSerial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_NumeroSerial.Location = new System.Drawing.Point(294, 175);
            this.txt_NumeroSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NumeroSerial.Name = "txt_NumeroSerial";
            this.txt_NumeroSerial.Size = new System.Drawing.Size(161, 34);
            this.txt_NumeroSerial.TabIndex = 10;
            // 
            // lbl_Instrumento
            // 
            this.lbl_Instrumento.AutoSize = true;
            this.lbl_Instrumento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Instrumento.Location = new System.Drawing.Point(21, 156);
            this.lbl_Instrumento.Name = "lbl_Instrumento";
            this.lbl_Instrumento.Size = new System.Drawing.Size(82, 17);
            this.lbl_Instrumento.TabIndex = 18;
            this.lbl_Instrumento.Text = "Instrumento";
            // 
            // lbl_Serial
            // 
            this.lbl_Serial.AutoSize = true;
            this.lbl_Serial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Serial.Location = new System.Drawing.Point(291, 156);
            this.lbl_Serial.Name = "lbl_Serial";
            this.lbl_Serial.Size = new System.Drawing.Size(44, 17);
            this.lbl_Serial.TabIndex = 19;
            this.lbl_Serial.Text = "Serial";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Valor.Location = new System.Drawing.Point(645, 156);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(41, 17);
            this.lbl_Valor.TabIndex = 1;
            this.lbl_Valor.Text = "Valor";
            // 
            // lbl_Servicos
            // 
            this.lbl_Servicos.AutoSize = true;
            this.lbl_Servicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Servicos.Location = new System.Drawing.Point(291, 47);
            this.lbl_Servicos.Name = "lbl_Servicos";
            this.lbl_Servicos.Size = new System.Drawing.Size(62, 17);
            this.lbl_Servicos.TabIndex = 1;
            this.lbl_Servicos.Text = "Serviços";
            // 
            // lbl_Observacao
            // 
            this.lbl_Observacao.AutoSize = true;
            this.lbl_Observacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Observacao.Location = new System.Drawing.Point(569, 47);
            this.lbl_Observacao.Name = "lbl_Observacao";
            this.lbl_Observacao.Size = new System.Drawing.Size(85, 17);
            this.lbl_Observacao.TabIndex = 1;
            this.lbl_Observacao.Text = "Observação";
            // 
            // lbl_ProblemaReclamado
            // 
            this.lbl_ProblemaReclamado.AutoSize = true;
            this.lbl_ProblemaReclamado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_ProblemaReclamado.Location = new System.Drawing.Point(22, 44);
            this.lbl_ProblemaReclamado.Name = "lbl_ProblemaReclamado";
            this.lbl_ProblemaReclamado.Size = new System.Drawing.Size(143, 17);
            this.lbl_ProblemaReclamado.TabIndex = 1;
            this.lbl_ProblemaReclamado.Text = "Problema Reclamado";
            // 
            // txt_Servicos
            // 
            this.txt_Servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_Servicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Servicos.Location = new System.Drawing.Point(294, 66);
            this.txt_Servicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Servicos.Multiline = true;
            this.txt_Servicos.Name = "txt_Servicos";
            this.txt_Servicos.Size = new System.Drawing.Size(257, 73);
            this.txt_Servicos.TabIndex = 7;
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_Observacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Observacao.Location = new System.Drawing.Point(572, 66);
            this.txt_Observacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Observacao.Multiline = true;
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(250, 73);
            this.txt_Observacao.TabIndex = 8;
            // 
            // txt_ProblemaReclamado
            // 
            this.txt_ProblemaReclamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_ProblemaReclamado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ProblemaReclamado.Location = new System.Drawing.Point(24, 66);
            this.txt_ProblemaReclamado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ProblemaReclamado.Multiline = true;
            this.txt_ProblemaReclamado.Name = "txt_ProblemaReclamado";
            this.txt_ProblemaReclamado.Size = new System.Drawing.Size(250, 73);
            this.txt_ProblemaReclamado.TabIndex = 6;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(476, 537);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(125, 42);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(330, 537);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(125, 42);
            this.btn_Salvar.TabIndex = 13;
            this.btn_Salvar.Text = "Gerar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // form_CadastroCliente
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 620);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.gp_DadosOrdemServico);
            this.Controls.Add(this.gp_DadosPessoais);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_CadastroCliente_FormClosed);
            this.Click += new System.EventHandler(this.btn_Salvar_Click);
            this.gp_DadosPessoais.ResumeLayout(false);
            this.gp_DadosPessoais.PerformLayout();
            this.gp_DadosOrdemServico.ResumeLayout(false);
            this.gp_DadosOrdemServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.GroupBox gp_DadosPessoais;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.GroupBox gp_DadosOrdemServico;
        private System.Windows.Forms.Label lbl_DataEntrega;
        private System.Windows.Forms.MaskedTextBox txt_DataEntrega;
        private System.Windows.Forms.TextBox txt_Instrumento;
        private System.Windows.Forms.TextBox txt_NumeroSerial;
        private System.Windows.Forms.Label lbl_Instrumento;
        private System.Windows.Forms.Label lbl_Serial;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Servicos;
        private System.Windows.Forms.Label lbl_Observacao;
        private System.Windows.Forms.Label lbl_ProblemaReclamado;
        private System.Windows.Forms.TextBox txt_Servicos;
        private System.Windows.Forms.TextBox txt_Observacao;
        private System.Windows.Forms.TextBox txt_ProblemaReclamado;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.MaskedTextBox txt_Valor;
    }
}

