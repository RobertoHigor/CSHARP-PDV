namespace ProjetoPAV.src
{
    partial class TelaVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.LvwConsulta = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(8, 44);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(98, 20);
            this.txtCodProduto.TabIndex = 2;
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.Location = new System.Drawing.Point(8, 106);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(98, 23);
            this.btnConsultarProduto.TabIndex = 3;
            this.btnConsultarProduto.Text = "Consultar produto";
            this.btnConsultarProduto.UseVisualStyleBackColor = true;
            this.btnConsultarProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sub Total:";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(675, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Confirmar compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(88, 189);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Unitario";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(555, 359);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(107, 20);
            this.txtSubTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(88, 216);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 14;
            this.txtQuantidade.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lista de compras";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.Silver;
            this.btnRemoverProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverProduto.ForeColor = System.Drawing.Color.Red;
            this.btnRemoverProduto.Location = new System.Drawing.Point(8, 308);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(160, 35);
            this.btnRemoverProduto.TabIndex = 16;
            this.btnRemoverProduto.Text = "Remover produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(119, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(69, 23);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // LvwConsulta
            // 
            this.LvwConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LvwConsulta.FullRowSelect = true;
            this.LvwConsulta.GridLines = true;
            this.LvwConsulta.HideSelection = false;
            this.LvwConsulta.Location = new System.Drawing.Point(235, 28);
            this.LvwConsulta.Name = "LvwConsulta";
            this.LvwConsulta.Size = new System.Drawing.Size(553, 315);
            this.LvwConsulta.TabIndex = 19;
            this.LvwConsulta.TileSize = new System.Drawing.Size(1, 1);
            this.LvwConsulta.UseCompatibleStateImageBehavior = false;
            this.LvwConsulta.View = System.Windows.Forms.View.Details;
            this.LvwConsulta.SelectedIndexChanged += new System.EventHandler(this.LvwConsulta_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "#";
            this.columnHeader3.Width = 26;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Codigo";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descricao";
            this.columnHeader6.Width = 269;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.LvwConsulta);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultarProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label1);
            this.Name = "TelaVenda";
            this.Text = "Tela de Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView LvwConsulta;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}