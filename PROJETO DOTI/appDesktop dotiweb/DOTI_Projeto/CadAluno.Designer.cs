namespace DOTI_Projeto
{
    partial class frmCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAluno));
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataCad = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TelefoneContato = new System.Windows.Forms.Panel();
            this.dgvFone = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.frmCadFone = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnPSalvar = new System.Windows.Forms.Button();
            this.btnPFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCodAlun = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoFone = new System.Windows.Forms.TextBox();
            this.lblStatusAlun = new System.Windows.Forms.Label();
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefoneContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.frmCadFone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(649, 443);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(138, 45);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 75);
            this.label1.TabIndex = 47;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblCodigo.Location = new System.Drawing.Point(12, 82);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 22);
            this.lblCodigo.TabIndex = 48;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblCpf.Location = new System.Drawing.Point(12, 137);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(47, 22);
            this.lblCpf.TabIndex = 50;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(16, 104);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(176, 30);
            this.txtCodigo.TabIndex = 51;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(202, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(585, 30);
            this.txtNome.TabIndex = 52;
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCpf.Location = new System.Drawing.Point(16, 159);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(176, 30);
            this.txtCpf.TabIndex = 54;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.ValidatingType = typeof(System.DateTime);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 213);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(176, 30);
            this.cmbStatus.TabIndex = 55;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 192);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 22);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblNome.Location = new System.Drawing.Point(198, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 22);
            this.lblNome.TabIndex = 57;
            this.lblNome.Text = "NOME:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblEmail.Location = new System.Drawing.Point(198, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 22);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(202, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(585, 30);
            this.txtEmail.TabIndex = 62;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataCad.Location = new System.Drawing.Point(202, 213);
            this.txtDataCad.Mask = "00/00/0000";
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(182, 30);
            this.txtDataCad.TabIndex = 72;
            this.txtDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(198, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 71;
            this.label2.Text = "DATA DE CADASTRO:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(441, 443);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 45);
            this.btnSalvar.TabIndex = 73;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(373, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 45);
            this.lblTitulo.TabIndex = 78;
            this.lblTitulo.Text = "CADASTRO DO ALUNO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelefoneContato
            // 
            this.TelefoneContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.TelefoneContato.BackgroundImage = global::DOTI_Projeto.Properties.Resources.teste2;
            this.TelefoneContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelefoneContato.Controls.Add(this.dgvFone);
            this.TelefoneContato.Controls.Add(this.btnAlterar);
            this.TelefoneContato.Controls.Add(this.btnAdicionar);
            this.TelefoneContato.Controls.Add(this.btnExcluir);
            this.TelefoneContato.Enabled = false;
            this.TelefoneContato.Location = new System.Drawing.Point(16, 268);
            this.TelefoneContato.Name = "TelefoneContato";
            this.TelefoneContato.Size = new System.Drawing.Size(406, 220);
            this.TelefoneContato.TabIndex = 70;
            // 
            // dgvFone
            // 
            this.dgvFone.AllowUserToAddRows = false;
            this.dgvFone.AllowUserToDeleteRows = false;
            this.dgvFone.BackgroundColor = System.Drawing.Color.White;
            this.dgvFone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFone.Location = new System.Drawing.Point(13, 32);
            this.dgvFone.Name = "dgvFone";
            this.dgvFone.ReadOnly = true;
            this.dgvFone.Size = new System.Drawing.Size(379, 130);
            this.dgvFone.TabIndex = 46;
            this.dgvFone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFone_CellClick);
            this.dgvFone.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFone_ColumnHeaderMouseClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnAlterar.Location = new System.Drawing.Point(150, 168);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 40);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnAdicionar.Location = new System.Drawing.Point(13, 168);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 40);
            this.btnAdicionar.TabIndex = 44;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnExcluir.Location = new System.Drawing.Point(282, 168);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 74);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblSenha.Location = new System.Drawing.Point(390, 191);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(75, 22);
            this.lblSenha.TabIndex = 80;
            this.lblSenha.Text = "SENHA:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(394, 213);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(393, 30);
            this.txtSenha.TabIndex = 79;
            // 
            // txtFoto
            // 
            this.txtFoto.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.Location = new System.Drawing.Point(441, 407);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(346, 30);
            this.txtFoto.TabIndex = 108;
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImage = global::DOTI_Projeto.Properties.Resources.foto;
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto.Location = new System.Drawing.Point(537, 251);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(150, 150);
            this.pctFoto.TabIndex = 107;
            this.pctFoto.TabStop = false;
            this.pctFoto.Click += new System.EventHandler(this.pctFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(437, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 106;
            this.label4.Text = "FOTO:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmCadFone
            // 
            this.frmCadFone.Controls.Add(this.label8);
            this.frmCadFone.Controls.Add(this.cmbTipo);
            this.frmCadFone.Controls.Add(this.btnPSalvar);
            this.frmCadFone.Controls.Add(this.btnPFechar);
            this.frmCadFone.Controls.Add(this.label3);
            this.frmCadFone.Controls.Add(this.pictureBox2);
            this.frmCadFone.Controls.Add(this.button1);
            this.frmCadFone.Controls.Add(this.button2);
            this.frmCadFone.Controls.Add(this.lblCodAlun);
            this.frmCadFone.Controls.Add(this.label5);
            this.frmCadFone.Controls.Add(this.txtCodigoFone);
            this.frmCadFone.Controls.Add(this.lblStatusAlun);
            this.frmCadFone.Controls.Add(this.cmbDesc);
            this.frmCadFone.Controls.Add(this.mtxtNumero);
            this.frmCadFone.Controls.Add(this.label7);
            this.frmCadFone.Location = new System.Drawing.Point(16, 82);
            this.frmCadFone.Name = "frmCadFone";
            this.frmCadFone.Size = new System.Drawing.Size(771, 406);
            this.frmCadFone.TabIndex = 109;
            this.frmCadFone.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(306, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 140;
            this.label8.Text = "TIPO:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "CELULAR",
            "RECADO",
            "FIXO"});
            this.cmbTipo.Location = new System.Drawing.Point(310, 297);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 30);
            this.cmbTipo.TabIndex = 139;
            // 
            // btnPSalvar
            // 
            this.btnPSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnPSalvar.FlatAppearance.BorderSize = 0;
            this.btnPSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSalvar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPSalvar.ForeColor = System.Drawing.Color.White;
            this.btnPSalvar.Location = new System.Drawing.Point(231, 354);
            this.btnPSalvar.Name = "btnPSalvar";
            this.btnPSalvar.Size = new System.Drawing.Size(138, 45);
            this.btnPSalvar.TabIndex = 138;
            this.btnPSalvar.Text = "SALVAR";
            this.btnPSalvar.UseVisualStyleBackColor = false;
            this.btnPSalvar.Click += new System.EventHandler(this.btnPSalvar_Click);
            // 
            // btnPFechar
            // 
            this.btnPFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btnPFechar.FlatAppearance.BorderSize = 0;
            this.btnPFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPFechar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPFechar.ForeColor = System.Drawing.Color.White;
            this.btnPFechar.Location = new System.Drawing.Point(425, 354);
            this.btnPFechar.Name = "btnPFechar";
            this.btnPFechar.Size = new System.Drawing.Size(138, 45);
            this.btnPFechar.TabIndex = 137;
            this.btnPFechar.Text = "FECHAR";
            this.btnPFechar.UseVisualStyleBackColor = false;
            this.btnPFechar.Click += new System.EventHandler(this.btnPFechar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 69);
            this.label3.TabIndex = 136;
            this.label3.Text = "ADICIONAR TELEFONE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 74);
            this.pictureBox2.TabIndex = 122;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.button1.Location = new System.Drawing.Point(450, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 135;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.button2.Location = new System.Drawing.Point(638, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 123;
            this.button2.Text = "FECHAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblCodAlun
            // 
            this.lblCodAlun.AutoSize = true;
            this.lblCodAlun.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAlun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblCodAlun.Location = new System.Drawing.Point(306, 87);
            this.lblCodAlun.Name = "lblCodAlun";
            this.lblCodAlun.Size = new System.Drawing.Size(84, 22);
            this.lblCodAlun.TabIndex = 125;
            this.lblCodAlun.Text = "CÓDIGO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(306, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 126;
            this.label5.Text = "NUMERO:";
            // 
            // txtCodigoFone
            // 
            this.txtCodigoFone.Enabled = false;
            this.txtCodigoFone.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFone.Location = new System.Drawing.Point(310, 109);
            this.txtCodigoFone.Name = "txtCodigoFone";
            this.txtCodigoFone.Size = new System.Drawing.Size(173, 30);
            this.txtCodigoFone.TabIndex = 127;
            // 
            // lblStatusAlun
            // 
            this.lblStatusAlun.AutoSize = true;
            this.lblStatusAlun.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAlun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.lblStatusAlun.Location = new System.Drawing.Point(306, 210);
            this.lblStatusAlun.Name = "lblStatusAlun";
            this.lblStatusAlun.Size = new System.Drawing.Size(116, 22);
            this.lblStatusAlun.TabIndex = 131;
            this.lblStatusAlun.Text = "DESCRIÇÃO:";
            // 
            // cmbDesc
            // 
            this.cmbDesc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Items.AddRange(new object[] {
            "CLARO",
            "OI",
            "VIVO",
            "TIM",
            "NEXTEL"});
            this.cmbDesc.Location = new System.Drawing.Point(310, 232);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(173, 30);
            this.cmbDesc.TabIndex = 130;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtNumero.Location = new System.Drawing.Point(310, 168);
            this.mtxtNumero.Mask = "(99) 90000-0000";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(173, 30);
            this.mtxtNumero.TabIndex = 129;
            this.mtxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(771, 76);
            this.label7.TabIndex = 124;
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(189)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.frmCadFone);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelefoneContato);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadAluno";
            this.Load += new System.EventHandler(this.frmCadAluno_Load);
            this.TelefoneContato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.frmCadFone.ResumeLayout(false);
            this.frmCadFone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel TelefoneContato;
        private System.Windows.Forms.DataGridView dgvFone;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txtDataCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Panel frmCadFone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnPSalvar;
        private System.Windows.Forms.Button btnPFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCodAlun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoFone;
        private System.Windows.Forms.Label lblStatusAlun;
        private System.Windows.Forms.ComboBox cmbDesc;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.Label label7;
    }
}