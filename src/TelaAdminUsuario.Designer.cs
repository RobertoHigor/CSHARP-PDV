namespace ProjetoPAV.src
{
    partial class TelaAdminUsuario
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
            this.btnUsuarioAlterar = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.lvwUsuarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBloquearUsuario = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnRemoverUsuario = new System.Windows.Forms.Button();
            this.tbxUsuarioFiltro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUsuarioAlterar
            // 
            this.btnUsuarioAlterar.Location = new System.Drawing.Point(242, 12);
            this.btnUsuarioAlterar.Name = "btnUsuarioAlterar";
            this.btnUsuarioAlterar.Size = new System.Drawing.Size(69, 24);
            this.btnUsuarioAlterar.TabIndex = 33;
            this.btnUsuarioAlterar.Text = "Alterar";
            this.btnUsuarioAlterar.UseVisualStyleBackColor = true;
            this.btnUsuarioAlterar.Click += new System.EventHandler(this.BtnUsuarioAlterar_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(75, 24);
            this.btnCadastroUsuario.TabIndex = 32;
            this.btnCadastroUsuario.Text = "Cadastrar";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.BtnCadastroUsuario_Click);
            // 
            // lvwUsuarios
            // 
            this.lvwUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwUsuarios.FullRowSelect = true;
            this.lvwUsuarios.GridLines = true;
            this.lvwUsuarios.HideSelection = false;
            this.lvwUsuarios.Location = new System.Drawing.Point(14, 40);
            this.lvwUsuarios.Name = "lvwUsuarios";
            this.lvwUsuarios.Size = new System.Drawing.Size(630, 405);
            this.lvwUsuarios.TabIndex = 30;
            this.lvwUsuarios.TileSize = new System.Drawing.Size(1, 1);
            this.lvwUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvwUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Senha";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 199;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Perfil";
            this.columnHeader5.Width = 46;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CPF";
            this.columnHeader6.Width = 121;
            // 
            // btnBloquearUsuario
            // 
            this.btnBloquearUsuario.Location = new System.Drawing.Point(174, 12);
            this.btnBloquearUsuario.Name = "btnBloquearUsuario";
            this.btnBloquearUsuario.Size = new System.Drawing.Size(62, 24);
            this.btnBloquearUsuario.TabIndex = 29;
            this.btnBloquearUsuario.Text = "Bloquear";
            this.btnBloquearUsuario.UseVisualStyleBackColor = true;
            this.btnBloquearUsuario.Click += new System.EventHandler(this.BtnBloquearUsuario_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(317, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnRemoverUsuario
            // 
            this.btnRemoverUsuario.Location = new System.Drawing.Point(93, 12);
            this.btnRemoverUsuario.Name = "btnRemoverUsuario";
            this.btnRemoverUsuario.Size = new System.Drawing.Size(75, 24);
            this.btnRemoverUsuario.TabIndex = 26;
            this.btnRemoverUsuario.Text = "Remover";
            this.btnRemoverUsuario.UseVisualStyleBackColor = true;
            this.btnRemoverUsuario.Click += new System.EventHandler(this.BtnRemoverUsuario_Click);
            // 
            // tbxUsuarioFiltro
            // 
            this.tbxUsuarioFiltro.Location = new System.Drawing.Point(409, 14);
            this.tbxUsuarioFiltro.Name = "tbxUsuarioFiltro";
            this.tbxUsuarioFiltro.Size = new System.Drawing.Size(233, 20);
            this.tbxUsuarioFiltro.TabIndex = 34;
            // 
            // TelaAdminUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 451);
            this.Controls.Add(this.tbxUsuarioFiltro);
            this.Controls.Add(this.btnUsuarioAlterar);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.lvwUsuarios);
            this.Controls.Add(this.btnBloquearUsuario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnRemoverUsuario);
            this.Name = "TelaAdminUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarioAlterar;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.ListView lvwUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBloquearUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnRemoverUsuario;
        private System.Windows.Forms.TextBox tbxUsuarioFiltro;
    }
}