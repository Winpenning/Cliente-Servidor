namespace Escola.view
{
    partial class FAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaonovo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.datafu = new System.Windows.Forms.ComboBox();
            this.datacity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataarea = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.datanumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataaddres = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.datacell = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.datarg = new System.Windows.Forms.TextBox();
            this.dataemail = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.datacep = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.datacpf = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataname = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dataid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueryDataGridView = new System.Windows.Forms.DataGridView();
            this.QuerySearch = new System.Windows.Forms.Button();
            this.QueryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Alunos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botaoeditar);
            this.panel2.Controls.Add(this.botaoexcluir);
            this.panel2.Controls.Add(this.botaosalvar);
            this.panel2.Controls.Add(this.botaonovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 81);
            this.panel2.TabIndex = 1;
            // 
            // botaoeditar
            // 
            this.botaoeditar.BackColor = System.Drawing.Color.Cyan;
            this.botaoeditar.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoeditar.Location = new System.Drawing.Point(547, 15);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(105, 43);
            this.botaoeditar.TabIndex = 3;
            this.botaoeditar.Text = "E&ditar";
            this.botaoeditar.UseVisualStyleBackColor = false;
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.BackColor = System.Drawing.Color.Cyan;
            this.botaoexcluir.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoexcluir.Location = new System.Drawing.Point(419, 15);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(105, 43);
            this.botaoexcluir.TabIndex = 2;
            this.botaoexcluir.Text = "&Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = false;
            // 
            // botaosalvar
            // 
            this.botaosalvar.BackColor = System.Drawing.Color.Cyan;
            this.botaosalvar.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaosalvar.Location = new System.Drawing.Point(297, 15);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(105, 43);
            this.botaosalvar.TabIndex = 1;
            this.botaosalvar.Text = "&Salvar";
            this.botaosalvar.UseVisualStyleBackColor = false;
            this.botaosalvar.Click += new System.EventHandler(this.botaosalvar_Click);
            // 
            // botaonovo
            // 
            this.botaonovo.BackColor = System.Drawing.Color.Cyan;
            this.botaonovo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaonovo.Location = new System.Drawing.Point(167, 15);
            this.botaonovo.Name = "botaonovo";
            this.botaonovo.Size = new System.Drawing.Size(105, 43);
            this.botaonovo.TabIndex = 0;
            this.botaonovo.Text = "&Novo";
            this.botaonovo.UseVisualStyleBackColor = false;
            this.botaonovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 474);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.datafu);
            this.tabPage1.Controls.Add(this.datacity);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dataarea);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.datanumber);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.dataaddres);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.datacell);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.datarg);
            this.tabPage1.Controls.Add(this.dataemail);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.datacep);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.datacpf);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.dataname);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.dataid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(443, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "UF:";
            // 
            // datafu
            // 
            this.datafu.FormattingEnabled = true;
            this.datafu.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.datafu.Location = new System.Drawing.Point(476, 289);
            this.datafu.Name = "datafu";
            this.datafu.Size = new System.Drawing.Size(121, 21);
            this.datafu.TabIndex = 48;
            // 
            // datacity
            // 
            this.datacity.Location = new System.Drawing.Point(237, 289);
            this.datacity.Name = "datacity";
            this.datacity.Size = new System.Drawing.Size(183, 20);
            this.datacity.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(188, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Cidade:";
            // 
            // dataarea
            // 
            this.dataarea.Location = new System.Drawing.Point(237, 251);
            this.dataarea.Name = "dataarea";
            this.dataarea.Size = new System.Drawing.Size(261, 20);
            this.dataarea.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(187, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Bairro:";
            // 
            // datanumber
            // 
            this.datanumber.Location = new System.Drawing.Point(552, 213);
            this.datanumber.Name = "datanumber";
            this.datanumber.Size = new System.Drawing.Size(50, 20);
            this.datanumber.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(522, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Nº:";
            // 
            // dataaddres
            // 
            this.dataaddres.Location = new System.Drawing.Point(255, 213);
            this.dataaddres.Name = "dataaddres";
            this.dataaddres.Size = new System.Drawing.Size(261, 20);
            this.dataaddres.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(188, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Endereço:";
            // 
            // datacell
            // 
            this.datacell.Location = new System.Drawing.Point(420, 178);
            this.datacell.Mask = "(##) # ####-####";
            this.datacell.Name = "datacell";
            this.datacell.Size = new System.Drawing.Size(100, 20);
            this.datacell.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(370, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Celular:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(514, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "RG:";
            // 
            // datarg
            // 
            this.datarg.Location = new System.Drawing.Point(563, 106);
            this.datarg.Name = "datarg";
            this.datarg.Size = new System.Drawing.Size(129, 20);
            this.datarg.TabIndex = 36;
            // 
            // dataemail
            // 
            this.dataemail.Location = new System.Drawing.Point(417, 141);
            this.dataemail.Name = "dataemail";
            this.dataemail.Size = new System.Drawing.Size(185, 20);
            this.dataemail.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(370, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Email:";
            // 
            // datacep
            // 
            this.datacep.Location = new System.Drawing.Point(242, 178);
            this.datacep.Mask = "##.###-###";
            this.datacep.Name = "datacep";
            this.datacep.Size = new System.Drawing.Size(100, 20);
            this.datacep.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(190, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "CEP:";
            // 
            // datacpf
            // 
            this.datacpf.Location = new System.Drawing.Point(242, 140);
            this.datacpf.Mask = "###.###.###-##";
            this.datacpf.Name = "datacpf";
            this.datacpf.Size = new System.Drawing.Size(100, 20);
            this.datacpf.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(191, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "CPF:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(192, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Nome:";
            // 
            // dataname
            // 
            this.dataname.Location = new System.Drawing.Point(242, 106);
            this.dataname.Name = "dataname";
            this.dataname.Size = new System.Drawing.Size(261, 20);
            this.dataname.TabIndex = 28;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(193, 81);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "ID:";
            // 
            // dataid
            // 
            this.dataid.Location = new System.Drawing.Point(242, 78);
            this.dataid.Name = "dataid";
            this.dataid.Size = new System.Drawing.Size(50, 20);
            this.dataid.TabIndex = 26;
            this.dataid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.QueryDataGridView);
            this.tabPage2.Controls.Add(this.QuerySearch);
            this.tabPage2.Controls.Add(this.QueryName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // QueryDataGridView
            // 
            this.QueryDataGridView.AllowUserToAddRows = false;
            this.QueryDataGridView.AllowUserToDeleteRows = false;
            this.QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryDataGridView.Location = new System.Drawing.Point(13, 71);
            this.QueryDataGridView.Name = "QueryDataGridView";
            this.QueryDataGridView.ReadOnly = true;
            this.QueryDataGridView.Size = new System.Drawing.Size(828, 371);
            this.QueryDataGridView.TabIndex = 5;
            this.QueryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // QuerySearch
            // 
            this.QuerySearch.BackColor = System.Drawing.Color.Cyan;
            this.QuerySearch.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuerySearch.Location = new System.Drawing.Point(543, 13);
            this.QuerySearch.Name = "QuerySearch";
            this.QuerySearch.Size = new System.Drawing.Size(105, 43);
            this.QuerySearch.TabIndex = 4;
            this.QuerySearch.Text = "Pesquisar";
            this.QuerySearch.UseVisualStyleBackColor = false;
            // 
            // QueryName
            // 
            this.QueryName.Location = new System.Drawing.Point(66, 26);
            this.QueryName.Name = "QueryName";
            this.QueryName.Size = new System.Drawing.Size(442, 20);
            this.QueryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // FAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.FAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botaonovo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox datafu;
        private System.Windows.Forms.TextBox datacity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox dataarea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox datanumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dataaddres;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox datacell;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox datarg;
        private System.Windows.Forms.TextBox dataemail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox datacep;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox datacpf;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox dataname;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox dataid;
        private System.Windows.Forms.Button QuerySearch;
        private System.Windows.Forms.TextBox QueryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView QueryDataGridView;
    }
}