using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using System.IO;

namespace DiamantWinForms
{
    public partial class ScanIdle : CaptureForm
    {

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private EntregaProductoEntities coneccion;

        public ScanIdle()
        {
            InitializeComponent();
        }

        private void btn_ofrecerAyuda_Click(object sender, EventArgs e)
        {
            frm_IngresarCodigoSocio ingresaCod = new frm_IngresarCodigoSocio();
            ingresaCod.ShowDialog();
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }


        protected override void Init()
        {
            base.Init();
            base.Text = "Verificacion de huella digital";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("false accept rate (FAR) = {0}", FAR));
        }

        protected override void Process(Sample Sample)
        {
            base.Process(Sample);

            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                //esta imagen es el que buscaremos en la BD
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                //Esta imagen es la que rescataremos de la BD y compararemos
                DPFP.Template template = new DPFP.Template();
                Stream stream;

                foreach (var ded in coneccion.dedo_Socio)
                {
                    stream = new MemoryStream(ded.dedsoc_info);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        //MessageBox.Show("la huella le pertenece a: " + ded.dedsoc_socio);
                        frm_EntregaProducto entrega = new frm_EntregaProducto();
                        entrega.rescateCodSocio(ded.dedsoc_socio.Value);
                        entrega.ShowDialog();
                        //stream = null;
                        break;
                    }
                }
                //this.Close();
            }
        }

        private void ScanIdle_Load(object sender, EventArgs e)
        {
            coneccion = new EntregaProductoEntities();
        }
    }
}
