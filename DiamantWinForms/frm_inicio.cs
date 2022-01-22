using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiamantWinForms
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_ofrecerAyuda_Click(object sender, EventArgs e)
        {
            frm_IngresarCodigoSocio ingresaCod = new frm_IngresarCodigoSocio();
            ingresaCod.ShowDialog();
        }

        private void btn_pideProd_Click(object sender, EventArgs e)
        {
            ScanIdle escanear = new ScanIdle();
            escanear.ShowDialog();
        }

    }
}
