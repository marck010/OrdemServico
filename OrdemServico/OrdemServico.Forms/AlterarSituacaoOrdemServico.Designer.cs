namespace OrdemServico.Forms
{
    partial class form_AlterarSituacaoOrdemServico
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
            this.lbl_Observacao = new System.Windows.Forms.Label();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.cb_Situacao = new System.Windows.Forms.ComboBox();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Observacao
            // 
            this.lbl_Observacao.AutoSize = true;
            this.lbl_Observacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Observacao.Location = new System.Drawing.Point(39, 136);
            this.lbl_Observacao.Name = "lbl_Observacao";
            this.lbl_Observacao.Size = new System.Drawing.Size(85, 17);
            this.lbl_Observacao.TabIndex = 1;
            this.lbl_Observacao.Text = "Observação";
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_Observacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Observacao.Location = new System.Drawing.Point(42, 155);
            this.txt_Observacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Observacao.Multiline = true;
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(431, 94);
            this.txt_Observacao.TabIndex = 8;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(268, 291);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 42);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(122, 291);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(125, 42);
            this.btn_Alterar.TabIndex = 13;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // cb_Situacao
            // 
            this.cb_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cb_Situacao.FormattingEnabled = true;
            this.cb_Situacao.Location = new System.Drawing.Point(42, 63);
            this.cb_Situacao.Name = "cb_Situacao";
            this.cb_Situacao.Size = new System.Drawing.Size(224, 33);
            this.cb_Situacao.TabIndex = 16;
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Location = new System.Drawing.Point(39, 43);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(63, 17);
            this.lbl_Situacao.TabIndex = 15;
            this.lbl_Situacao.Text = "Situação";
            // 
            // form_AlterarSituacaoOrdemServico
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 367);
            this.Controls.Add(this.cb_Situacao);
            this.Controls.Add(this.lbl_Situacao);
            this.Controls.Add(this.lbl_Observacao);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Observacao);
            this.Controls.Add(this.btn_Alterar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_AlterarSituacaoOrdemServico";
            this.Text = "Cadastro de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_AlterarSituacaoOrdemServico_FormClosed);
            this.Click += new System.EventHandler(this.btn_Salvar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Observacao;
        private System.Windows.Forms.TextBox txt_Observacao;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.ComboBox cb_Situacao;
        private System.Windows.Forms.Label lbl_Situacao;
    }
}

