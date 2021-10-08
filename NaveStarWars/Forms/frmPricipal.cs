using NaveStarWars.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaveStarWars.Forms
{
    public partial class frmPricipal : Form
    {
        public frmPricipal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private async void bntSincronizar_Click(object sender, EventArgs e)
        {
            var sincronizador = new SincronizadorService();

            Cursor = Cursors.WaitCursor;
            await sincronizador.Sincronizar();
            Cursor = Cursors.Default;
            MessageBox.Show("Sincronização finalizada com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmControleNaves();
            frm.ShowDialog();
        }
    }
}
