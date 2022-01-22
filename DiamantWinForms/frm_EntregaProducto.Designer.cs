
namespace DiamantWinForms
{
    partial class frm_EntregaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EntregaProducto));
            this.lbl_saludoSocio = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_sabanilla = new System.Windows.Forms.Button();
            this.btn_toalla = new System.Windows.Forms.Button();
            this.lbl_Intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_saludoSocio
            // 
            this.lbl_saludoSocio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saludoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludoSocio.Location = new System.Drawing.Point(301, 12);
            this.lbl_saludoSocio.Name = "lbl_saludoSocio";
            this.lbl_saludoSocio.Size = new System.Drawing.Size(419, 95);
            this.lbl_saludoSocio.TabIndex = 0;
            this.lbl_saludoSocio.Text = "Bienvenido ~Nombre y apellido socio ~";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.BackgroundImage = global::DiamantWinForms.Properties.Resources.Icono_salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(12, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(50, 50);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_sabanilla
            // 
            this.btn_sabanilla.BackColor = System.Drawing.Color.Transparent;
            this.btn_sabanilla.BackgroundImage = global::DiamantWinForms.Properties.Resources.IconoSabanilla;
            this.btn_sabanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sabanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sabanilla.Location = new System.Drawing.Point(383, 468);
            this.btn_sabanilla.Name = "btn_sabanilla";
            this.btn_sabanilla.Size = new System.Drawing.Size(222, 214);
            this.btn_sabanilla.TabIndex = 2;
            this.btn_sabanilla.UseVisualStyleBackColor = false;
            this.btn_sabanilla.Click += new System.EventHandler(this.btn_sabanilla_Click);
            // 
            // btn_toalla
            // 
            this.btn_toalla.BackColor = System.Drawing.Color.Transparent;
            this.btn_toalla.BackgroundImage = global::DiamantWinForms.Properties.Resources.IconoToalla;
            this.btn_toalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_toalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toalla.Location = new System.Drawing.Point(111, 468);
            this.btn_toalla.Name = "btn_toalla";
            this.btn_toalla.Size = new System.Drawing.Size(222, 214);
            this.btn_toalla.TabIndex = 1;
            this.btn_toalla.UseVisualStyleBackColor = false;
            this.btn_toalla.Click += new System.EventHandler(this.btn_toalla_Click);
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intro.Location = new System.Drawing.Point(377, 329);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(337, 62);
            this.lbl_Intro.TabIndex = 6;
            this.lbl_Intro.Text = "Seleccione un producto";
            this.lbl_Intro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_EntregaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiamantWinForms.Properties.Resources.GUIBorroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 868);
            this.Controls.Add(this.lbl_Intro);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_sabanilla);
            this.Controls.Add(this.btn_toalla);
            this.Controls.Add(this.lbl_saludoSocio);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EntregaProducto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EntregaProducto";
            this.Load += new System.EventHandler(this.frm_EntregaProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_saludoSocio;
        private System.Windows.Forms.Button btn_toalla;
        private System.Windows.Forms.Button btn_sabanilla;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Intro;
    }
}