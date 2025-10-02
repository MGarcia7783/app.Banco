using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Banco.Formularios
{
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void iconCuentas_Click(object sender, EventArgs e)
        {
            frmMovimientoCuentas frm = new frmMovimientoCuentas();
            frm.ShowDialog();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el módulo de cuentas.");
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
