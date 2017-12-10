namespace Database_First_App
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
            this.components = new System.ComponentModel.Container();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKad = new System.Windows.Forms.TextBox();
            this.rtxtKacik = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGnc = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrnad = new System.Windows.Forms.TextBox();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblFyt = new System.Windows.Forms.Label();
            this.cbSatisDurum = new System.Windows.Forms.CheckBox();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnuEkle = new System.Windows.Forms.Button();
            this.cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.ContextMenuStrip = this.cmsSil;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(12, 12);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(210, 433);
            this.lstCategory.TabIndex = 0;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(250, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(260, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // txtKad
            // 
            this.txtKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKad.Location = new System.Drawing.Point(374, 12);
            this.txtKad.Name = "txtKad";
            this.txtKad.Size = new System.Drawing.Size(186, 30);
            this.txtKad.TabIndex = 3;
            // 
            // rtxtKacik
            // 
            this.rtxtKacik.Location = new System.Drawing.Point(374, 61);
            this.rtxtKacik.Name = "rtxtKacik";
            this.rtxtKacik.Size = new System.Drawing.Size(186, 96);
            this.rtxtKacik.TabIndex = 4;
            this.rtxtKacik.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(374, 163);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(186, 52);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGnc
            // 
            this.btnGnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnc.Location = new System.Drawing.Point(374, 221);
            this.btnGnc.Name = "btnGnc";
            this.btnGnc.Size = new System.Drawing.Size(186, 52);
            this.btnGnc.TabIndex = 7;
            this.btnGnc.Text = "Güncelle";
            this.btnGnc.UseVisualStyleBackColor = true;
            this.btnGnc.Click += new System.EventHandler(this.btnGnc_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.ContextMenuStrip = this.cmsSil;
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.Location = new System.Drawing.Point(580, 13);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(202, 433);
            this.lstProduct.TabIndex = 8;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(792, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Urun Adı : ";
            // 
            // txtUrnad
            // 
            this.txtUrnad.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrnad.Location = new System.Drawing.Point(923, 12);
            this.txtUrnad.Name = "txtUrnad";
            this.txtUrnad.Size = new System.Drawing.Size(120, 33);
            this.txtUrnad.TabIndex = 10;
            this.txtUrnad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numFiyat
            // 
            this.numFiyat.DecimalPlaces = 2;
            this.numFiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numFiyat.Location = new System.Drawing.Point(923, 60);
            this.numFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(120, 33);
            this.numFiyat.TabIndex = 11;
            this.numFiyat.ValueChanged += new System.EventHandler(this.numFiyat_ValueChanged);
            // 
            // lblFyt
            // 
            this.lblFyt.AutoSize = true;
            this.lblFyt.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFyt.Location = new System.Drawing.Point(798, 64);
            this.lblFyt.Name = "lblFyt";
            this.lblFyt.Size = new System.Drawing.Size(71, 23);
            this.lblFyt.TabIndex = 12;
            this.lblFyt.Text = "Fiyat : ";
            // 
            // cbSatisDurum
            // 
            this.cbSatisDurum.AutoSize = true;
            this.cbSatisDurum.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSatisDurum.Location = new System.Drawing.Point(885, 100);
            this.cbSatisDurum.Name = "cbSatisDurum";
            this.cbSatisDurum.Size = new System.Drawing.Size(146, 27);
            this.cbSatisDurum.TabIndex = 13;
            this.cbSatisDurum.Text = "Satis Durumu";
            this.cbSatisDurum.UseVisualStyleBackColor = true;
            // 
            // numStok
            // 
            this.numStok.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStok.Location = new System.Drawing.Point(923, 124);
            this.numStok.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(120, 33);
            this.numStok.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(798, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stok : ";
            // 
            // btnuEkle
            // 
            this.btnuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuEkle.Location = new System.Drawing.Point(856, 170);
            this.btnuEkle.Name = "btnuEkle";
            this.btnuEkle.Size = new System.Drawing.Size(163, 52);
            this.btnuEkle.TabIndex = 16;
            this.btnuEkle.Text = "Ekle";
            this.btnuEkle.UseVisualStyleBackColor = true;
            this.btnuEkle.Click += new System.EventHandler(this.btnuEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 464);
            this.Controls.Add(this.btnuEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStok);
            this.Controls.Add(this.cbSatisDurum);
            this.Controls.Add(this.lblFyt);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.txtUrnad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.btnGnc);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rtxtKacik);
            this.Controls.Add(this.txtKad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKad;
        private System.Windows.Forms.RichTextBox rtxtKacik;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnGnc;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrnad;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.Label lblFyt;
        private System.Windows.Forms.CheckBox cbSatisDurum;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnuEkle;
    }
}

