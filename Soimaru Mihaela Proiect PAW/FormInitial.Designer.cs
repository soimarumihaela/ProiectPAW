namespace ProiectPAWWWWWWW
{
    partial class FormInitial
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
            this.btnSofer = new System.Windows.Forms.Button();
            this.btnMasina = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSofer
            // 
            this.btnSofer.BackColor = System.Drawing.Color.Salmon;
            this.btnSofer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSofer.Location = new System.Drawing.Point(59, 169);
            this.btnSofer.Name = "btnSofer";
            this.btnSofer.Size = new System.Drawing.Size(167, 96);
            this.btnSofer.TabIndex = 0;
            this.btnSofer.Text = "Sofer";
            this.btnSofer.UseVisualStyleBackColor = false;
            this.btnSofer.Click += new System.EventHandler(this.btnSofer_Click);
            // 
            // btnMasina
            // 
            this.btnMasina.BackColor = System.Drawing.Color.Salmon;
            this.btnMasina.Location = new System.Drawing.Point(291, 169);
            this.btnMasina.Name = "btnMasina";
            this.btnMasina.Size = new System.Drawing.Size(175, 96);
            this.btnMasina.TabIndex = 1;
            this.btnMasina.Text = "Masina";
            this.btnMasina.UseVisualStyleBackColor = false;
            this.btnMasina.Click += new System.EventHandler(this.btnMasina_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.Salmon;
            this.btnRuta.Location = new System.Drawing.Point(513, 169);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(167, 96);
            this.btnRuta.TabIndex = 2;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = global::ProiectPAWWWWWWW.Properties.Resources.rent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnMasina);
            this.Controls.Add(this.btnSofer);
            this.Name = "FormInitial";
            this.Text = "FormInitial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSofer;
        private System.Windows.Forms.Button btnMasina;
        private System.Windows.Forms.Button btnRuta;
    }
}

