namespace DOTI_Projeto
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFundoBusca = new System.Windows.Forms.Label();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnProcessos = new System.Windows.Forms.Button();
            this.btnLido = new System.Windows.Forms.Button();
            this.btnInstrutores = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.dgvBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.lblFundoBusca);
            this.pnlBuscar.Location = new System.Drawing.Point(283, 8);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(559, 266);
            this.pnlBuscar.TabIndex = 8;
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToAddRows = false;
            this.dgvBuscar.AllowUserToDeleteRows = false;
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(0, 36);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(559, 230);
            this.dgvBuscar.TabIndex = 9;
            this.dgvBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellClick);
            this.dgvBuscar.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBuscar_ColumnHeaderMouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.txtBuscar.Location = new System.Drawing.Point(75, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(479, 19);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(189)))), ((int)(((byte)(48)))));
            this.lblBuscar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(2, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // lblFundoBusca
            // 
            this.lblFundoBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(189)))), ((int)(((byte)(48)))));
            this.lblFundoBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFundoBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFundoBusca.Location = new System.Drawing.Point(0, 0);
            this.lblFundoBusca.Name = "lblFundoBusca";
            this.lblFundoBusca.Size = new System.Drawing.Size(559, 37);
            this.lblFundoBusca.TabIndex = 4;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(189)))), ((int)(((byte)(48)))));
            this.lblAulas.Enabled = false;
            this.lblAulas.Font = new System.Drawing.Font("Cambria", 33F);
            this.lblAulas.Location = new System.Drawing.Point(300, 306);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(95, 52);
            this.lblAulas.TabIndex = 10;
            this.lblAulas.Text = "100";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(189)))), ((int)(((byte)(48)))));
            this.lblAlunos.Enabled = false;
            this.lblAlunos.Font = new System.Drawing.Font("Cambria", 33F);
            this.lblAlunos.Location = new System.Drawing.Point(445, 306);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(95, 52);
            this.lblAlunos.TabIndex = 11;
            this.lblAlunos.Text = "100";
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(714, 280);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(128, 126);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.BackgroundImage")));
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(426, 280);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(128, 126);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.AutoSize = true;
            this.btnAprovar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAprovar.BackgroundImage")));
            this.btnAprovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAprovar.FlatAppearance.BorderSize = 0;
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Location = new System.Drawing.Point(283, 280);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(128, 126);
            this.btnAprovar.TabIndex = 6;
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnProcessos
            // 
            this.btnProcessos.AutoSize = true;
            this.btnProcessos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcessos.BackgroundImage")));
            this.btnProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcessos.FlatAppearance.BorderSize = 0;
            this.btnProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessos.Location = new System.Drawing.Point(144, 280);
            this.btnProcessos.Name = "btnProcessos";
            this.btnProcessos.Size = new System.Drawing.Size(128, 126);
            this.btnProcessos.TabIndex = 5;
            this.btnProcessos.UseVisualStyleBackColor = true;
            this.btnProcessos.Click += new System.EventHandler(this.btnProcessos_Click);
            // 
            // btnLido
            // 
            this.btnLido.AutoSize = true;
            this.btnLido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLido.BackgroundImage")));
            this.btnLido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLido.FlatAppearance.BorderSize = 0;
            this.btnLido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLido.Location = new System.Drawing.Point(570, 280);
            this.btnLido.Name = "btnLido";
            this.btnLido.Size = new System.Drawing.Size(128, 126);
            this.btnLido.TabIndex = 4;
            this.btnLido.UseVisualStyleBackColor = true;
            this.btnLido.Click += new System.EventHandler(this.btnLido_Click);
            // 
            // btnInstrutores
            // 
            this.btnInstrutores.AutoSize = true;
            this.btnInstrutores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstrutores.BackgroundImage")));
            this.btnInstrutores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstrutores.FlatAppearance.BorderSize = 0;
            this.btnInstrutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrutores.Location = new System.Drawing.Point(6, 280);
            this.btnInstrutores.Name = "btnInstrutores";
            this.btnInstrutores.Size = new System.Drawing.Size(128, 126);
            this.btnInstrutores.TabIndex = 3;
            this.btnInstrutores.UseVisualStyleBackColor = true;
            this.btnInstrutores.Click += new System.EventHandler(this.btnInstrutores_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.AutoSize = true;
            this.btnAulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAulas.BackgroundImage")));
            this.btnAulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAulas.Location = new System.Drawing.Point(144, 148);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(128, 126);
            this.btnAulas.TabIndex = 2;
            this.btnAulas.UseVisualStyleBackColor = true;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.AutoSize = true;
            this.btnAlunos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlunos.BackgroundImage")));
            this.btnAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Location = new System.Drawing.Point(6, 148);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(128, 126);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.AutoSize = true;
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogo.Enabled = false;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(6, 7);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(266, 135);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(849, 414);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.btnProcessos);
            this.Controls.Add(this.btnLido);
            this.Controls.Add(this.btnInstrutores);
            this.Controls.Add(this.btnAulas);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnInstrutores;
        private System.Windows.Forms.Button btnProcessos;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFundoBusca;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLido;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Label lblAlunos;
    }
}