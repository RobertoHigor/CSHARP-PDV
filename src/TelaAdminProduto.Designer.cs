namespace ProjetoPAV.src
{
    partial class TelaAdminProduto
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
            this.btnProdutoAlterar = new System.Windows.Forms.Button();
            this.tbxProdutoFiltro = new System.Windows.Forms.TextBox();
            this.lvwProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProdutoPesquisar = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdutoAlterar
            // 
            this.btnProdutoAlterar.Location = new System.Drawing.Point(109, 8);
            this.btnProdutoAlterar.Name = "btnProdutoAlterar";
            this.btnProdutoAlterar.Size = new System.Drawing.Size(83, 24);
            this.btnProdutoAlterar.TabIndex = 31;
            this.btnProdutoAlterar.Text = "Alterar";
            this.btnProdutoAlterar.UseVisualStyleBackColor = true;
            this.btnProdutoAlterar.Click += new System.EventHandler(this.BtnProdutoAlterar_Click);
            // 
            // tbxProdutoFiltro
            // 
            this.tbxProdutoFiltro.Location = new System.Drawing.Point(360, 11);
            this.tbxProdutoFiltro.Name = "tbxProdutoFiltro";
            this.tbxProdutoFiltro.Size = new System.Drawing.Size(252, 20);
            this.tbxProdutoFiltro.TabIndex = 30;
            // 
            // lvwProdutos
            // 
            this.lvwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwProdutos.FullRowSelect = true;
            this.lvwProdutos.GridLines = true;
            this.lvwProdutos.HideSelection = false;
            this.lvwProdutos.Location = new System.Drawing.Point(12, 38);
            this.lvwProdutos.Name = "lvwProdutos";
            this.lvwProdutos.Size = new System.Drawing.Size(652, 396);
            this.lvwProdutos.TabIndex = 29;
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
            this.columnHeader3.Width = 183;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descricao";
            this.columnHeader4.Width = 308;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "preco";
            this.columnHeader5.Width = 63;
            // 
            // btnProdutoPesquisar
            // 
            this.btnProdutoPesquisar.Location = new System.Drawing.Point(279, 8);
            this.btnProdutoPesquisar.Name = "btnProdutoPesquisar";
            this.btnProdutoPesquisar.Size = new System.Drawing.Size(75, 24);
            this.btnProdutoPesquisar.TabIndex = 28;
            this.btnProdutoPesquisar.Text = "Pesquisar";
            this.btnProdutoPesquisar.UseVisualStyleBackColor = true;
            this.btnProdutoPesquisar.Click += new System.EventHandler(this.BtnProdutoPesquisar_Click_1);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(198, 8);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 24);
            this.btnRemoverProduto.TabIndex = 27;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Location = new System.Drawing.Point(12, 8);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(83, 24);
            this.btnCadastroProduto.TabIndex = 26;
            this.btnCadastroProduto.Text = "Cadastrar";
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.BtnCadastroProduto_Click);
            // 
            // TelaAdminProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 446);
            this.Controls.Add(this.btnProdutoAlterar);
            this.Controls.Add(this.tbxProdutoFiltro);
            this.Controls.Add(this.lvwProdutos);
            this.Controls.Add(this.btnProdutoPesquisar);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnCadastroProduto);
            this.Name = "TelaAdminProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdutoAlterar;
        private System.Windows.Forms.TextBox tbxProdutoFiltro;
        private System.Windows.Forms.ListView lvwProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnProdutoPesquisar;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnCadastroProduto;
    }
}