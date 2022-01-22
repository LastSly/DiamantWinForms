
namespace DiamantWinForms
{
    partial class frm_RegistrarDedo
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
            this.btn_indiceIzq = new System.Windows.Forms.Button();
            this.btn_indiceDer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_indiceIzq
            // 
            this.btn_indiceIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_indiceIzq.BackgroundImage = global::DiamantWinForms.Properties.Resources.BotoPress;
            this.btn_indiceIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_indiceIzq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_indiceIzq.Location = new System.Drawing.Point(233, 463);
            this.btn_indiceIzq.Name = "btn_indiceIzq";
            this.btn_indiceIzq.Size = new System.Drawing.Size(68, 64);
            this.btn_indiceIzq.TabIndex = 0;
            this.btn_indiceIzq.UseVisualStyleBackColor = false;
            this.btn_indiceIzq.Click += new System.EventHandler(this.btn_indiceIzq_Click);
            // 
            // btn_indiceDer
            // 
            this.btn_indiceDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_indiceDer.BackgroundImage = global::DiamantWinForms.Properties.Resources.BotoPress;
            this.btn_indiceDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_indiceDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_indiceDer.Location = new System.Drawing.Point(449, 463);
            this.btn_indiceDer.Name = "btn_indiceDer";
            this.btn_indiceDer.Size = new System.Drawing.Size(68, 64);
            this.btn_indiceDer.TabIndex = 1;
            this.btn_indiceDer.UseVisualStyleBackColor = false;
            this.btn_indiceDer.Click += new System.EventHandler(this.btn_indiceDer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 65);
            this.label1.TabIndex = 51;
            this.label1.Text = "Seleccione dedo a enrrolar:";
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
            this.btn_Salir.TabIndex = 52;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DiamantWinForms.Properties.Resources.ManoIzq;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(124, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 319);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DiamantWinForms.Properties.Resources.ManoDer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(364, 448);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 319);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // frm_RegistrarDedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiamantWinForms.Properties.Resources.GUIBorroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 868);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_indiceDer);
            this.Controls.Add(this.btn_indiceIzq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegistrarDedo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_RegistrarDedo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_indiceIzq;
        private System.Windows.Forms.Button btn_indiceDer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}