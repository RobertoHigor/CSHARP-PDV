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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.LvwConsulta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "acoes com usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "acoes com produto";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 24);
            this.button5.TabIndex = 6;
            this.button5.Text = "Trocar senha";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(305, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 24);
            this.button6.TabIndex = 7;
            this.button6.Text = "Bloquear usuarios";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(682, 35);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 24);
            this.button9.TabIndex = 11;
            this.button9.Text = "Pesquisar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(601, 35);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 24);
            this.button11.TabIndex = 9;
            this.button11.Text = "Remover";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(486, 35);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 24);
            this.button12.TabIndex = 8;
            this.button12.Text = "Adicionar / Alterar";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // LvwConsulta
            // 
            this.LvwConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LvwConsulta.FullRowSelect = true;
            this.LvwConsulta.GridLines = true;
            this.LvwConsulta.HideSelection = false;
            this.LvwConsulta.Location = new System.Drawing.Point(486, 65);
            this.LvwConsulta.Name = "LvwConsulta";
            this.LvwConsulta.Size = new System.Drawing.Size(547, 455);
            this.LvwConsulta.TabIndex = 19;
            this.LvwConsulta.TileSize = new System.Drawing.Size(1, 1);
            this.LvwConsulta.UseCompatibleStateImageBehavior = false;
            this.LvwConsulta.View = System.Windows.Forms.View.Details;
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
            this.columnHeader4.Width = 260;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "preco";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 426);
            this.listView1.TabIndex = 20;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.columnHeader8.Width = 67;
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
            this.columnHeader11.Width = 76;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(763, 38);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(268, 20);
            this.txtCodProduto.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 24);
            this.button1.TabIndex = 23;
            this.button1.Text = "Adicionar / Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LvwConsulta);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "TelaAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.TelaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ListView LvwConsulta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}