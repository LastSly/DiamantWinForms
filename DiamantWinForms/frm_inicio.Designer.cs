
namespace DiamantWinForms
{
    partial class frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.lbl_Intro = new System.Windows.Forms.Label();
            this.btn_ofrecerAyuda = new System.Windows.Forms.Button();
            this.btn_pideProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intro.Location = new System.Drawing.Point(356, 314);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(364, 120);
            this.lbl_Intro.TabIndex = 5;
            this.lbl_Intro.Text = "Toque la imagen para pedir un producto";
            this.lbl_Intro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ofrecerAyuda
            // 
            this.btn_ofrecerAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ofrecerAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ofrecerAyuda.BackgroundImage")));
            this.btn_ofrecerAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ofrecerAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ofrecerAyuda.Location = new System.Drawing.Point(12, 387);
            this.btn_ofrecerAyuda.Name = "btn_ofrecerAyuda";
            this.btn_ofrecerAyuda.Size = new System.Drawing.Size(234, 53);
            this.btn_ofrecerAyuda.TabIndex = 3;
            this.btn_ofrecerAyuda.UseVisualStyleBackColor = false;
            this.btn_ofrecerAyuda.Click += new System.EventHandler(this.btn_ofrecerAyuda_Click);
            // 
            // btn_pideProd
            // 
            this.btn_pideProd.BackColor = System.Drawing.Color.Transparent;
            this.btn_pideProd.BackgroundImage = global::DiamantWinForms.Properties.Resources.imagen_dedo;
            this.btn_pideProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pideProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pideProd.Location = new System.Drawing.Point(271, 446);
            this.btn_pideProd.Name = "btn_pideProd";
            this.btn_pideProd.Size = new System.Drawing.Size(187, 272);
            this.btn_pideProd.TabIndex = 0;
            this.btn_pideProd.UseVisualStyleBackColor = false;
            this.btn_pideProd.Click += new System.EventHandler(this.btn_pideProd_Click);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiamantWinForms.Properties.Resources.GUINormal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 868);
            this.Controls.Add(this.lbl_Intro);
            this.Controls.Add(this.btn_ofrecerAyuda);
            this.Controls.Add(this.btn_pideProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pideProd;
        private System.Windows.Forms.Button btn_ofrecerAyuda;
        private System.Windows.Forms.Label lbl_Intro;
    }
}