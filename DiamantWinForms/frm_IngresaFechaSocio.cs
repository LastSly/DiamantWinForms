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
    public partial class frm_IngresaFechaSocio : Form
    {

        string entradaDigito = "";
        string cadenaCod = "";
        string cadenaFecha = "";
        EntregaProductoEntities coneccion;


        public frm_IngresaFechaSocio()
        {
            coneccion = new EntregaProductoEntities();
            InitializeComponent();
        }

        public void rescateCodSocio(int rescateCod)
        {
            cadenaCod = rescateCod.ToString();
        }

        private void agregarDigitosSecuencia(string entradaDigito)
        {

            if (cadenaFecha.Length < 8)
            {
                switch (entradaDigito)
                {
                    case "0":
                        cadenaFecha += "0";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "1":
                        cadenaFecha += "1";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "2":
                        cadenaFecha += "2";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "3":
                        cadenaFecha += "3";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "4":
                        cadenaFecha += "4";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "5":
                        cadenaFecha += "5";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "6":
                        cadenaFecha += "6";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "7":
                        cadenaFecha += "7";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "8":
                        cadenaFecha += "8";
                        lbl_display.Text = cadenaFecha;
                        break;
                    case "9":
                        cadenaFecha += "9";
                        lbl_display.Text = cadenaFecha;
                        break;
                    
                }
            }

            switch (entradaDigito)
            {
                case "borrar":
                    lbl_display.Text = "";
                    cadenaFecha = "";
                    break;
                case "enter":
                    if (cadenaFecha.Length > 7)
                    {
                        checkResultado(int.Parse(cadenaCod), cadenaFecha);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese fecha valida porfavor");
                    }
                    break;
            }

        }


        private void checkResultado(int cadenaID, string cadenaFecha)
        {

            int llave = 0;
            foreach (var soc in coneccion.socios)
            {
                if (soc.soc_id == cadenaID)
                {
                    if (soc.soc_cumple == cadenaFecha)
                    {
                        //MessageBox.Show("Socio: " + soc.soc_nombre + " coincide con cumpleaños: " + soc.soc_cumple);
                        llave = 1;
                        //ahora abrir la siguiente pagina y enviarle el codigo de socio
                        frm_MuestraRegistraDedo muestraHuella = new frm_MuestraRegistraDedo();
                        muestraHuella.rescateCodSocio(cadenaID);
                        muestraHuella.ShowDialog();
                        this.Close();
                        break;
                    }
                }
            }

            if (llave == 0)
            {
                MessageBox.Show("cumple años ingresado no es el esperado");
            }
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            entradaDigito = "1";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            entradaDigito = "2";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            entradaDigito = "3";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            entradaDigito = "4";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            entradaDigito = "5";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            entradaDigito = "6";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            entradaDigito = "7";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            entradaDigito = "8";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            entradaDigito = "9";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            entradaDigito = "0";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            entradaDigito = "enter";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            entradaDigito = "borrar";
            agregarDigitosSecuencia(entradaDigito);
            entradaDigito = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
