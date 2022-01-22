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
    public partial class frm_IngresaRutSocio : Form
    {

        string entradaDigito = "";
        string cadenaCod = "";
        string cadenaRut = "";
        EntregaProductoEntities coneccion;

        public frm_IngresaRutSocio()
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

            if (cadenaRut.Length < 9)
            {
                switch (entradaDigito)
                {
                    case "0":
                        cadenaRut += "0";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "1":
                        cadenaRut += "1";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "2":
                        cadenaRut += "2";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "3":
                        cadenaRut += "3";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "4":
                        cadenaRut += "4";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "5":
                        cadenaRut += "5";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "6":
                        cadenaRut += "6";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "7":
                        cadenaRut += "7";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "8":
                        cadenaRut += "8";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "9":
                        cadenaRut += "9";
                        lbl_display.Text = cadenaRut;
                        break;
                    case "ka":
                        cadenaRut += "k";
                        lbl_display.Text = cadenaRut;
                        break;
                }
            }

            switch (entradaDigito)
            {
                case "borrar":
                    lbl_display.Text = "";
                    cadenaRut = "";
                    break;
                case "enter":
                    if (cadenaRut.Length > 8)
                    {
                        checkResultado(int.Parse(cadenaCod), cadenaRut);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese rut valido porfavor");
                    }
                    break;
            }

        }

        private void checkResultado(int cadenaID,string cadenaRUT)
        {
            
            int llave = 0;
            foreach (var soc in coneccion.socios)
            {
                if (soc.soc_id == cadenaID)
                {
                    if (soc.soc_rut == cadenaRUT)
                    {
                        //MessageBox.Show("Socio: " + soc.soc_nombre + " coincide con el rut: " + soc.soc_rut);
                        llave = 1;
                        //ahora abrir la siguiente pagina y enviarle el codigo de socio
                        frm_IngresaFechaSocio ingresoFecha = new frm_IngresaFechaSocio();
                        ingresoFecha.rescateCodSocio(cadenaID);
                        ingresoFecha.ShowDialog();
                        this.Close();
                        break;
                    }
                }
            }

            if (llave == 0)
            {
                MessageBox.Show("rut ingresado no es el esperado");
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

        private void btn_ka_Click(object sender, EventArgs e)
        {
            entradaDigito = "ka";
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
