namespace OrdemServico.Forms
{
    partial class form_Pesquisa
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
            this.dgv_Membros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Situacao = new System.Windows.Forms.ComboBox();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.lbl_NumeroOS = new System.Windows.Forms.Label();
            this.txt_NumeroOS = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarMinisterio = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Membros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Membros
            // 
            this.dgv_Membros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Membros.Location = new System.Drawing.Point(28, 23);
            this.dgv_Membros.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Membros.Name = "dgv_Membros";
            this.dgv_Membros.Size = new System.Drawing.Size(718, 405);
            this.dgv_Membros.TabIndex = 22;
            this.dgv_Membros.DoubleClick += new System.EventHandler(this.dgv_Membros_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Membros);
            this.groupBox1.Location = new System.Drawing.Point(29, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(775, 436);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(249, 30);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(34, 17);
            this.lbl_CPF.TabIndex = 1;
            this.lbl_CPF.Text = "CPF";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.Location = new System.Drawing.Point(252, 49);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CPF.Mask = "999.999.999-99";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(173, 30);
            this.txt_CPF.TabIndex = 3;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(328, 180);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(186, 46);
            this.btn_Pesquisar.TabIndex = 24;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Situacao);
            this.groupBox2.Controls.Add(this.txt_CPF);
            this.groupBox2.Controls.Add(this.lbl_Situacao);
            this.groupBox2.Controls.Add(this.lbl_CPF);
            this.groupBox2.Controls.Add(this.lbl_NumeroOS);
            this.groupBox2.Controls.Add(this.txt_NumeroOS);
            this.groupBox2.Location = new System.Drawing.Point(29, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(775, 114);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos de Pesquisa";
            // 
            // cb_Situacao
            // 
            this.cb_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cb_Situacao.FormattingEnabled = true;
            this.cb_Situacao.Location = new System.Drawing.Point(464, 46);
            this.cb_Situacao.Name = "cb_Situacao";
            this.cb_Situacao.Size = new System.Drawing.Size(224, 33);
            this.cb_Situacao.TabIndex = 4;
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Location = new System.Drawing.Point(461, 26);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(63, 17);
            this.lbl_Situacao.TabIndex = 1;
            this.lbl_Situacao.Text = "Situação";
            // 
            // lbl_NumeroOS
            // 
            this.lbl_NumeroOS.AutoSize = true;
            this.lbl_NumeroOS.Location = new System.Drawing.Point(54, 30);
            this.lbl_NumeroOS.Name = "lbl_NumeroOS";
            this.lbl_NumeroOS.Size = new System.Drawing.Size(82, 17);
            this.lbl_NumeroOS.TabIndex = 1;
            this.lbl_NumeroOS.Text = "Número OS";
            // 
            // txt_NumeroOS
            // 
            this.txt_NumeroOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroOS.Location = new System.Drawing.Point(58, 49);
            this.txt_NumeroOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NumeroOS.Name = "txt_NumeroOS";
            this.txt_NumeroOS.Size = new System.Drawing.Size(162, 30);
            this.txt_NumeroOS.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarMinisterio});
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(84, 24);
            this.menuCadastrar.Text = "Cadastrar";
            // 
            // menuCadastrarMinisterio
            // 
            this.menuCadastrarMinisterio.Name = "menuCadastrarMinisterio";
            this.menuCadastrarMinisterio.Size = new System.Drawing.Size(124, 24);
            this.menuCadastrarMinisterio.Text = "Cliente";
            this.menuCadastrarMinisterio.Click += new System.EventHandler(this.menuCadastrarCliente_Click);
            // 
            // form_Pesquisa
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 683);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_Pesquisa";
            this.Text = "Pesquisa de Membros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Membros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Membros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarMinisterio;
        private System.Windows.Forms.Label lbl_NumeroOS;
        private System.Windows.Forms.TextBox txt_NumeroOS;
        private System.Windows.Forms.ComboBox cb_Situacao;
        private System.Windows.Forms.Label lbl_Situacao;
    }
}

