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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblGirisBilgi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGiris.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnKayitOl);
            this.gbGiris.Controls.Add(this.btnGiris);
            this.gbGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbGiris.Location = new System.Drawing.Point(152, 114);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(343, 168);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Silver;
            this.btnKayitOl.Location = new System.Drawing.Point(185, 45);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(130, 81);
            this.btnKayitOl.TabIndex = 0;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Silver;
            this.btnGiris.Location = new System.Drawing.Point(26, 45);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 81);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGirisBilgi
            // 
            this.lblGirisBilgi.AutoSize = true;
            this.lblGirisBilgi.Location = new System.Drawing.Point(188, 60);
            this.lblGirisBilgi.Name = "lblGirisBilgi";
            this.lblGirisBilgi.Size = new System.Drawing.Size(0, 13);
            this.lblGirisBilgi.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.siparişlerToolStripMenuItem1,
            this.müşterilerToolStripMenuItem,
            this.repolarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 338);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem1
            // 
            this.siparişlerToolStripMenuItem1.Name = "siparişlerToolStripMenuItem1";
            this.siparişlerToolStripMenuItem1.Size = new System.Drawing.Size(113, 19);
            this.siparişlerToolStripMenuItem1.Text = "Siparişler";
            this.siparişlerToolStripMenuItem1.Click += new System.EventHandler(this.siparişlerToolStripMenuItem1_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // repolarToolStripMenuItem
            // 
            this.repolarToolStripMenuItem.Name = "repolarToolStripMenuItem";
            this.repolarToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.repolarToolStripMenuItem.Text = "Repolar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 338);
            this.Controls.Add(this.lblGirisBilgi);
            this.Controls.Add(this.gbGiris);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbGiris.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblGirisBilgi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repolarToolStripMenuItem;
    }
}

