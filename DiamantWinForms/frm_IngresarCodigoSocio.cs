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
    public partial class frm_IngresarCodigoSocio : Form
    {

        string entradaDigito = "";
        string cadenaCod = "";
        EntregaProductoEntities coneccion;


        public frm_IngresarCodigoSocio()
        {
            coneccion = new EntregaProductoEntities();
            InitializeComponent();
        }


        private void agregarDigitosSecuencia(string entradaDigito)
        {

            if (cadenaCod.Length < 5)
            {
                switch (entradaDigito)
                {
                    case "0":
                        cadenaCod += "0";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "1":
                        cadenaCod += "1";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "2":
                        cadenaCod += "2";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "3":
                        cadenaCod += "3";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "4":
                        cadenaCod += "4";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "5":
                        cadenaCod += "5";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "6":
                        cadenaCod += "6";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "7":
                        cadenaCod += "7";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "8":
                        cadenaCod += "8";
                        lbl_display.Text = cadenaCod;
                        break;
                    case "9":
                        cadenaCod += "9";
                        lbl_display.Text = cadenaCod;
                        break;
                }
            }

            switch (entradaDigito)
            {
                case "borrar":
                    lbl_display.Text = "";
                    cadenaCod = "";
                    break;
                case "enter":
                    if (cadenaCod.Length > 0)
                    {
                        checkResultado(int.Parse(cadenaCod));
                    }
                    else
                    {
                        MessageBox.Show("Ingrese codigo valido porfavor");
                    }
                    break;
            }

        }

        private void checkResultado(int cadena)
        {
            int llave = 0;
            foreach(var soc in coneccion.socios)
            {
                if(soc.soc_id == cadena)
                {
                    //MessageBox.Show("Socio encontrado: " + soc.soc_nombre);
                    llave = 1;
                    //ahora abrir la siguiente pagina y enviarle el codigo de socio
                    frm_IngresaRutSocio ingresoRut = new frm_IngresaRutSocio();
                    ingresoRut.rescateCodSocio(cadena);
                    ingresoRut.ShowDialog();
                    this.Close();
                    break;
                }
            }

            if(llave == 0)
            {
                MessageBox.Show("codigo ingresado no se encuentra en base de datos");
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
