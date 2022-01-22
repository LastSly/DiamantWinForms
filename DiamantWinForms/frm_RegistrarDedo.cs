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
    public partial class frm_RegistrarDedo : Form
    {

        int cadenaCod;
        int dedoIzq;
        int dedoDer;
        private DPFP.Template Template;
        EntregaProductoEntities coneccion;
        
        public frm_RegistrarDedo()
        {
            coneccion = new EntregaProductoEntities();
            InitializeComponent();
        }

        public void rescateCodDedoSocio(int rescateCod,int dedIzq, int dedDer)
        {
            cadenaCod = rescateCod;
            dedoIzq = dedIzq;
            dedoDer = dedDer;
        }

        private void abrirCapturaHuella()
        {
            Frm_capturarHuella capturar = new Frm_capturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        private void btn_indiceIzq_Click(object sender, EventArgs e)
        {
            abrirCapturaHuella();
            agregarHuellaIzq();
        }

        private void btn_indiceDer_Click(object sender, EventArgs e)
        {
            abrirCapturaHuella();
            agregarHuellaDer();
        }

        private void agregarHuellaIzq()
        {

            try
            {
                
                //esto te ingresa una nueva huella izq, pero falta revisar si ya hay una para sobreescribir
                byte[] streamHuella = Template.Bytes;
                
                dedo_Socio registro = new dedo_Socio()
                {
                    dedsoc_socio = cadenaCod,
                    dedsoc_dedo = 1,
                    dedsoc_info = streamHuella
                };
                coneccion.dedo_Socio.Add(registro);
                coneccion.SaveChanges();
                MessageBox.Show("Registro huella Izq ingresada con exito");
                registro = null;
                Template = null;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void agregarHuellaDer()
        {

            try
            {
                //esto te ingresa una nueva huella Der, pero falta revisar si ya hay una para sobreescribir
                byte[] streamHuella = Template.Bytes;
                dedo_Socio registro = new dedo_Socio()
                {
                    dedsoc_socio = cadenaCod,
                    dedsoc_dedo = 2,
                    dedsoc_info = streamHuella
                };
                coneccion.dedo_Socio.Add(registro);
                coneccion.SaveChanges();
                MessageBox.Show("Registro huella Der ingresada con exito");
                registro = null;
                Template = null;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
