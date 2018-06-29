using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPAV.src
{
    public partial class TelaSplash : Form
    {
        private int progresso = 0;
        public TelaSplash()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }   

        private static TelaSplash instancia = null;
        public static void Executar (int tempo)
        {
            if (instancia == null)
                instancia = new TelaSplash();
            instancia.progresso = 0;
            instancia.timer1.Interval = tempo / 100;
            instancia.timer1.Enabled = true;
            instancia.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progresso++;
            progressBar1.Width = (int)(progresso / 35.0f * 165);
            if (progresso >= 100)
            {
                Close();
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

