namespace ProjetoPAV
{
    partial class TelaAdmin
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
            this.btnRemoverUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBloquearUsuario = new System.Windows.Forms.Button();
            this.btnProdutoPesquisar = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.lvwProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwUsuarios = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxProdutoFiltro = new System.Windows.Forms.TextBox();
            this.tbxUsuarioFiltro = new System.Windows.Forms.TextBox();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoverUsuario
            // 
            this.btnRemoverUsuario.Location = new System.Drawing.Point(96, 35);
            this.btnRemoverUsuario.Name = "btnRemoverUsuario";
            this.btnRemoverUsuario.Size = new System.Drawing.Size(75, 24);
            this.btnRemoverUsuario.TabIndex = 1;
            this.btnRemoverUsuario.Text = "Remover";
            this.btnRemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBloquearUsuario
            // 
            this.btnBloquearUsuario.Location = new System.Drawing.Point(177, 35);
            this.btnBloquearUsuario.Name = "btnBloquearUsuario";
            this.btnBloquearUsuario.Size = new System.Drawing.Size(102, 24);
            this.btnBloquearUsuario.TabIndex = 7;
            this.btnBloquearUsuario.Text = "Bloquear";
            this.btnBloquearUsuario.UseVisualStyleBackColor = true;
            // 
            // btnProdutoPesquisar
            // 
            this.btnProdutoPesquisar.Location = new System.Drawing.Point(798, 32);
            this.btnProdutoPesquisar.Name = "btnProdutoPesquisar";
            this.btnProdutoPesquisar.Size = new System.Drawing.Size(75, 24);
            this.btnProdutoPesquisar.TabIndex = 11;
            this.btnProdutoPesquisar.Text = "Pesquisar";
            this.btnProdutoPesquisar.UseVisualStyleBackColor = true;
            this.btnProdutoPesquisar.Click += new System.EventHandler(this.btnProdutoPesquisar_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(717, 32);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 24);
            this.btnRemoverProduto.TabIndex = 9;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Location = new System.Drawing.Point(628, 32);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(83, 24);
            this.btnCadastroProduto.TabIndex = 8;
            this.btnCadastroProduto.Text = "Cadastrar";
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            // 
            // lvwProdutos
            // 
            this.lvwProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwProdutos.FullRowSelect = true;
            this.lvwProdutos.GridLines = true;
            this.lvwProdutos.HideSelection = false;
            this.lvwProdutos.Location = new System.Drawing.Point(531, 65);
            this.lvwProdutos.Name = "lvwProdutos";
            this.lvwProdutos.Size = new System.Drawing.Size(502, 455);
            this.lvwProdutos.TabIndex = 19;
            this.lvwProdutos.TileSize = new System.Drawing.Size(1, 1);
            this.lvwProdutos.UseCompatibleStateImageBehavior = false;
            this.lvwProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Codigo";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descricao";
            this.columnHeader4.Width = 212;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "preco";
            this.columnHeader5.Width = 63;
            // 
            // lvwUsuarios
            // 
            this.lvwUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwUsuarios.FullRowSelect = true;
            this.lvwUsuarios.GridLines = true;
            this.lvwUsuarios.HideSelection = false;
            this.lvwUsuarios.Location = new System.Drawing.Point(12, 65);
            this.lvwUsuarios.Name = "lvwUsuarios";
            this.lvwUsuarios.Size = new System.Drawing.Size(513, 455);
            this.lvwUsuarios.TabIndex = 20;
            this.lvwUsuarios.TileSize = new System.Drawing.Size(1, 1);
            this.lvwUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvwUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "#";
            this.columnHeader6.Width = 26;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nome";
            this.columnHeader7.Width = 133;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CPF";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Login";
            this.columnHeader9.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Senha";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Perfil";
            this.columnHeader11.Width = 46;
            // 
            // tbxProdutoFiltro
            // 
            this.tbxProdutoFiltro.Location = new System.Drawing.Point(879, 32);
            this.tbxProdutoFiltro.Name = "tbxProdutoFiltro";
            this.tbxProdutoFiltro.Size = new System.Drawing.Size(152, 20);
            this.tbxProdutoFiltro.TabIndex = 21;
            this.tbxProdutoFiltro.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            // 
            // tbxUsuarioFiltro
            // 
            this.tbxUsuarioFiltro.Location = new System.Drawing.Point(366, 39);
            this.tbxUsuarioFiltro.Name = "tbxUsuarioFiltro";
            this.tbxUsuarioFiltro.Size = new System.Drawing.Size(159, 20);
            this.tbxUsuarioFiltro.TabIndex = 22;
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Location = new System.Drawing.Point(15, 35);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(75, 24);
            this.btnCadastroUsuario.TabIndex = 23;
            this.btnCadastroUsuario.Text = "Cadastrar";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 532);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.tbxUsuarioFiltro);
            this.Controls.Add(this.tbxProdutoFiltro);
            this.Controls.Add(this.lvwUsuarios);
            this.Controls.Add(this.lvwProdutos);
            this.Controls.Add(this.btnProdutoPesquisar);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnBloquearUsuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoverUsuario);
            this.Name = "TelaAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.TelaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoverUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBloquearUsuario;
        private System.Windows.Forms.Button btnProdutoPesquisar;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.ListView lvwProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvwUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox tbxProdutoFiltro;
        private System.Windows.Forms.TextBox tbxUsuarioFiltro;
        private System.Windows.Forms.Button btnCadastroUsuario;
    }
}