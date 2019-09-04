namespace Sy.Forms
{
    partial class OrderForm
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.nAlısFiyati = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nEklenecekMiktar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAlısFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEklenecekMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 40);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(151, 225);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            this.lstUrunler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstUrunler_KeyUp);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 10);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(151, 20);
            this.txtAra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nEklenecekMiktar);
            this.groupBox1.Controls.Add(this.nAlısFiyati);
            this.groupBox1.Controls.Add(this.lblStokMiktari);
            this.groupBox1.Controls.Add(this.lblUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(207, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Detay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alış Fiyatı :";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(98, 34);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(55, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "lblUrunAdi";
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(98, 69);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(70, 13);
            this.lblStokMiktari.TabIndex = 1;
            this.lblStokMiktari.Text = "lblStokMiktari";
            // 
            // nAlısFiyati
            // 
            this.nAlısFiyati.DecimalPlaces = 2;
            this.nAlısFiyati.Location = new System.Drawing.Point(120, 126);
            this.nAlısFiyati.Name = "nAlısFiyati";
            this.nAlısFiyati.Size = new System.Drawing.Size(103, 20);
            this.nAlısFiyati.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eklenecek Miktar :";
            // 
            // nEklenecekMiktar
            // 
            this.nEklenecekMiktar.Location = new System.Drawing.Point(120, 98);
            this.nEklenecekMiktar.Name = "nEklenecekMiktar";
            this.nEklenecekMiktar.Size = new System.Drawing.Size(103, 20);
            this.nEklenecekMiktar.TabIndex = 2;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrunler);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAlısFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEklenecekMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nAlısFiyati;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nEklenecekMiktar;
        private System.Windows.Forms.Label label4;
    }
}