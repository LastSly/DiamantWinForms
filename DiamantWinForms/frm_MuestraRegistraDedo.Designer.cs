
namespace DiamantWinForms
{
    partial class frm_MuestraRegistraDedo
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
            this.btn_registrarHuella = new System.Windows.Forms.Button();
            this.lbl_dedosRegistrados = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registrarHuella
            // 
            this.btn_registrarHuella.Location = new System.Drawing.Point(29, 394);
            this.btn_registrarHuella.Name = "btn_registrarHuella";
            this.btn_registrarHuella.Size = new System.Drawing.Size(167, 63);
            this.btn_registrarHuella.TabIndex = 48;
            this.btn_registrarHuella.Text = "Registrar huella";
            this.btn_registrarHuella.UseVisualStyleBackColor = true;
            this.btn_registrarHuella.Click += new System.EventHandler(this.btn_registrarHuella_Click);
            // 
            // lbl_dedosRegistrados
            // 
            this.lbl_dedosRegistrados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dedosRegistrados.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dedosRegistrados.Location = new System.Drawing.Point(139, 514);
            this.lbl_dedosRegistrados.Name = "lbl_dedosRegistrados";
            this.lbl_dedosRegistrados.Size = new System.Drawing.Size(465, 113);
            this.lbl_dedosRegistrados.TabIndex = 49;
            this.lbl_dedosRegistrados.Text = "El Socio: -- tiene registrado las huellas Der y Izq\r\n";
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
            this.btn_Salir.TabIndex = 50;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_MuestraRegistraDedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiamantWinForms.Properties.Resources.GUIBorroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 868);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_dedosRegistrados);
            this.Controls.Add(this.btn_registrarHuella);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MuestraRegistraDedo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MuestraRegistraDedo";
            this.Load += new System.EventHandler(this.frm_MuestraRegistraDedo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_registrarHuella;
        private System.Windows.Forms.Label lbl_dedosRegistrados;
        private System.Windows.Forms.Button btn_Salir;
    }
}