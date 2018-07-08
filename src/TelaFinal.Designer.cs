namespace ProjetoPAV.src
{
    partial class TelaFinal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LvwConsulta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxPrecoFinal = new System.Windows.Forms.TextBox();
            this.tbxValorPago = new System.Windows.Forms.TextBox();
            this.tbxTroco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos Comprados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preco Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Troco";
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
            this.LvwConsulta.Location = new System.Drawing.Point(12, 25);
            this.LvwConsulta.Name = "LvwConsulta";
            this.LvwConsulta.Size = new System.Drawing.Size(246, 404);
            this.LvwConsulta.TabIndex = 19;
            this.LvwConsulta.TileSize = new System.Drawing.Size(1, 1);
            this.LvwConsulta.UseCompatibleStateImageBehavior = false;
            this.LvwConsulta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Codigo";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descricao";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço";
            // 
            // tbxPrecoFinal
            // 
            this.tbxPrecoFinal.Location = new System.Drawing.Point(265, 239);
            this.tbxPrecoFinal.Name = "tbxPrecoFinal";
            this.tbxPrecoFinal.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecoFinal.TabIndex = 20;
            // 
            // tbxValorPago
            // 
            this.tbxValorPago.Location = new System.Drawing.Point(265, 318);
            this.tbxValorPago.Name = "tbxValorPago";
            this.tbxValorPago.Size = new System.Drawing.Size(100, 20);
            this.tbxValorPago.TabIndex = 21;
            // 
            // tbxTroco
            // 
            this.tbxTroco.Location = new System.Drawing.Point(265, 389);
            this.tbxTroco.Name = "tbxTroco";
            this.tbxTroco.Size = new System.Drawing.Size(100, 20);
            this.tbxTroco.TabIndex = 22;
            this.tbxTroco.TextChanged += new System.EventHandler(this.tbxTroco_TextChanged);
            // 
            // TelaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.tbxTroco);
            this.Controls.Add(this.tbxValorPago);
            this.Controls.Add(this.tbxPrecoFinal);
            this.Controls.Add(this.LvwConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaFinal";
            this.Text = "Tela Final";
            this.Load += new System.EventHandler(this.TelaFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LvwConsulta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox tbxPrecoFinal;
        private System.Windows.Forms.TextBox tbxValorPago;
        private System.Windows.Forms.TextBox tbxTroco;
    }
}