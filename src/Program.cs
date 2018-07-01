using ProjetoPAV.src;
using System;
using System.Windows.Forms;

namespace ProjetoPAV
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteBD bd = new SQLiteBD();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Executar a tela de login
            TelaSplash.Executar(1000);
            //Application.Run(new TelaLogin());
            Application.Run(new TelaAdmin());
        }
    }
}
