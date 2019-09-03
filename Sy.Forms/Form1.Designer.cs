namespace Sy.Forms
{
    partial class Form1
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
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblGirisBilgi = new System.Windows.Forms.Label();
            this.gbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnKayitOl);
            this.gbGiris.Controls.Add(this.btnGiris);
            this.gbGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbGiris.Location = new System.Drawing.Point(45, 90);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(291, 120);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Silver;
            this.btnGiris.Location = new System.Drawing.Point(26, 29);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(106, 65);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Silver;
            this.btnKayitOl.Location = new System.Drawing.Point(159, 29);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(107, 65);
            this.btnKayitOl.TabIndex = 0;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lblGirisBilgi
            // 
            this.lblGirisBilgi.AutoSize = true;
            this.lblGirisBilgi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBilgi.ForeColor = System.Drawing.Color.Red;
            this.lblGirisBilgi.Location = new System.Drawing.Point(105, 48);
            this.lblGirisBilgi.Name = "lblGirisBilgi";
            this.lblGirisBilgi.Size = new System.Drawing.Size(162, 18);
            this.lblGirisBilgi.TabIndex = 1;
            this.lblGirisBilgi.Text = "Hoşgeldin : Kamil Fıdıl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 279);
            this.Controls.Add(this.lblGirisBilgi);
            this.Controls.Add(this.gbGiris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblGirisBilgi;
    }
}

