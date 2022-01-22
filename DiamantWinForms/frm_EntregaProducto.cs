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
    public partial class frm_EntregaProducto : Form
    {
        int cadenaCod;
        EntregaProductoEntities coneccion;
        int opcion = 0;
        
        public frm_EntregaProducto()
        {
            InitializeComponent();
        }

        public void rescateCodSocio(int rescateCod)
        {
            cadenaCod = rescateCod;
        }

        private void frm_EntregaProducto_Load(object sender, EventArgs e)
        {
            coneccion = new EntregaProductoEntities();
            foreach(var soc in coneccion.socios)
            {
                if(cadenaCod == soc.soc_id)
                {
                    lbl_saludoSocio.Text = "Bienvenido: " + soc.soc_nombre + " " +
                        soc.soc_ape_paterno + " " + soc.soc_ape_materno;
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ticket = "aqui se escribe el ticket" ;
            coneccion = new EntregaProductoEntities();
            int i = 0;

            if (opcion == 0) //click en toalla
            {
                foreach (var bol in coneccion.boletas)
                {
                    i = bol.bol_serie;
                }

                foreach (var bol in coneccion.boletas)
                {
                    if( i == bol.bol_serie)
                    {
                        ticket = "Codigo Socio: " + bol.bolsoc_id + "\n" +
                             "Producto: " + "Toalla" + "\n" +
                             "Codigo Lugar: " + bol.bollug_id + "\n" +
                             "Fecha: " + bol.bol_fecha;
                    }
                    
                }
            }

            if(opcion == 1) //click en sabanilla
            {
                foreach (var bol in coneccion.boletas)
                {
                    i = bol.bol_serie;
                }

                foreach (var bol in coneccion.boletas)
                {
                    if (i == bol.bol_serie)
                    {
                        ticket = "Codigo Socio: " + bol.bolsoc_id + "\n" +
                             "Producto: " + "Sabanilla" + "\n" +
                             "Codigo Lugar: " + bol.bollug_id + "\n" +
                             "Fecha: " + bol.bol_fecha;
                    }

                }
            }
            
            e.Graphics.DrawString(ticket,
                new Font("Times New Roman", 14, FontStyle.Bold),
                Brushes.Black, new PointF(50, 50));

        }

        private void Imprimir()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }


        private void btn_toalla_Click(object sender, EventArgs e)
        {
            opcion = 0;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            try
            {
                boleta pedido = new boleta()
                {
                    bolsoc_id = cadenaCod,
                    bollug_id = 1,
                    bolpro_id = 1,
                    bol_fecha = myDateTime
                };
                coneccion.boletas.Add(pedido);
                coneccion.SaveChanges();
                Imprimir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_sabanilla_Click(object sender, EventArgs e)
        {
            opcion = 1;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            try
            {
                boleta pedido = new boleta()
                {
                    bolsoc_id = cadenaCod,
                    bollug_id = 1,
                    bolpro_id = 2,
                    bol_fecha = myDateTime
                };
                coneccion.boletas.Add(pedido);
                coneccion.SaveChanges();
                Imprimir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
