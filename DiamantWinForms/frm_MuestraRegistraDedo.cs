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
    public partial class frm_MuestraRegistraDedo : Form
    {

        int cadenaCod;
        int dedoIzq = 0;
        int dedoDer = 0;
        EntregaProductoEntities coneccion;
        
        public frm_MuestraRegistraDedo()
        {
            coneccion = new EntregaProductoEntities();
            InitializeComponent();
            
        }

        public void rescateCodSocio(int rescateCod)
        {
            cadenaCod = rescateCod;
        }

        private void chekeoDedosSocio(int socio)
        {

            foreach (var soc in coneccion.dedo_Socio)
            {
                if(socio == soc.dedsoc_socio)
                {
                    if(soc.dedsoc_dedo == 1)
                    {
                        //MessageBox.Show("El socio tiene registrada la huella Izquierda");
                        dedoIzq = 1;
                    }

                    if (soc.dedsoc_dedo == 2)
                    {
                        //MessageBox.Show("El socio tiene registrada la huella Derecha");
                        dedoDer = 2;
                    }

                }
            }

            if(dedoIzq == 1)
            {
                lbl_dedosRegistrados.Text = "El Socio tiene registrada la huella indice Izquierda";
            }

            if(dedoDer == 2)
            {
                lbl_dedosRegistrados.Text = "El Socio tiene registrada la huella indice Derecha";
            }

            if(dedoIzq == 1 && dedoDer == 2)
            {
                lbl_dedosRegistrados.Text = "El Socio tiene Registrada las huellas indice Izquierda y Derecha";
            }

            if (dedoIzq == 0 && dedoDer == 0)
            {
                lbl_dedosRegistrados.Text = "El Socio no tiene huellas Registradas";
            }

        }

        private void btn_registrarHuella_Click(object sender, EventArgs e)
        {
            frm_RegistrarDedo registraDedo = new frm_RegistrarDedo();
            registraDedo.rescateCodDedoSocio(cadenaCod,dedoIzq,dedoDer);
            registraDedo.ShowDialog();
            this.Close();
        }

        private void frm_MuestraRegistraDedo_Load(object sender, EventArgs e)
        {
            chekeoDedosSocio(cadenaCod);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
