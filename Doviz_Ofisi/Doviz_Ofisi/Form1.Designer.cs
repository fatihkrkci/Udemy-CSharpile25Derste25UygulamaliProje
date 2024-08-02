namespace Doviz_Ofisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDolarAlis = new System.Windows.Forms.Button();
            this.btnDolarSatis = new System.Windows.Forms.Button();
            this.btnEuroSatis = new System.Windows.Forms.Button();
            this.btnEuroAlis = new System.Windows.Forms.Button();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIslem1 = new System.Windows.Forms.Button();
            this.btnIslem2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.Location = new System.Drawing.Point(147, 24);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(20, 22);
            this.lblDolarAlis.TabIndex = 1;
            this.lblDolarAlis.Text = "0";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.Location = new System.Drawing.Point(147, 56);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(20, 22);
            this.lblDolarSatis.TabIndex = 3;
            this.lblDolarSatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(51, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış:";
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.Location = new System.Drawing.Point(375, 56);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(20, 22);
            this.lblEuroSatis.TabIndex = 7;
            this.lblEuroSatis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(283, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış:";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.Location = new System.Drawing.Point(375, 24);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(20, 22);
            this.lblEuroAlis.TabIndex = 5;
            this.lblEuroAlis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(294, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnIslem2);
            this.groupBox1.Controls.Add(this.btnIslem1);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(11, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(75, 21);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(341, 28);
            this.txtKur.TabIndex = 1;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(75, 55);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(341, 28);
            this.txtMiktar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Miktar:";
            // 
            // btnDolarAlis
            // 
            this.btnDolarAlis.Location = new System.Drawing.Point(12, 22);
            this.btnDolarAlis.Name = "btnDolarAlis";
            this.btnDolarAlis.Size = new System.Drawing.Size(33, 26);
            this.btnDolarAlis.TabIndex = 9;
            this.btnDolarAlis.Text = "···";
            this.btnDolarAlis.UseVisualStyleBackColor = true;
            this.btnDolarAlis.Click += new System.EventHandler(this.btnDolarAlis_Click);
            // 
            // btnDolarSatis
            // 
            this.btnDolarSatis.Location = new System.Drawing.Point(12, 54);
            this.btnDolarSatis.Name = "btnDolarSatis";
            this.btnDolarSatis.Size = new System.Drawing.Size(33, 26);
            this.btnDolarSatis.TabIndex = 10;
            this.btnDolarSatis.Text = "···";
            this.btnDolarSatis.UseVisualStyleBackColor = true;
            this.btnDolarSatis.Click += new System.EventHandler(this.btnDolarSatis_Click);
            // 
            // btnEuroSatis
            // 
            this.btnEuroSatis.Location = new System.Drawing.Point(244, 54);
            this.btnEuroSatis.Name = "btnEuroSatis";
            this.btnEuroSatis.Size = new System.Drawing.Size(33, 26);
            this.btnEuroSatis.TabIndex = 12;
            this.btnEuroSatis.Text = "···";
            this.btnEuroSatis.UseVisualStyleBackColor = true;
            this.btnEuroSatis.Click += new System.EventHandler(this.btnEuroSatis_Click);
            // 
            // btnEuroAlis
            // 
            this.btnEuroAlis.Location = new System.Drawing.Point(244, 22);
            this.btnEuroAlis.Name = "btnEuroAlis";
            this.btnEuroAlis.Size = new System.Drawing.Size(33, 26);
            this.btnEuroAlis.TabIndex = 11;
            this.btnEuroAlis.Text = "···";
            this.btnEuroAlis.UseVisualStyleBackColor = true;
            this.btnEuroAlis.Click += new System.EventHandler(this.btnEuroAlis_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(75, 123);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(341, 28);
            this.txtKalan.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Kalan:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(75, 89);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(341, 28);
            this.txtTutar.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tutar:";
            // 
            // btnIslem1
            // 
            this.btnIslem1.Location = new System.Drawing.Point(75, 158);
            this.btnIslem1.Name = "btnIslem1";
            this.btnIslem1.Size = new System.Drawing.Size(152, 32);
            this.btnIslem1.TabIndex = 13;
            this.btnIslem1.Text = "İşlem 1";
            this.btnIslem1.UseVisualStyleBackColor = true;
            this.btnIslem1.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnIslem2
            // 
            this.btnIslem2.Location = new System.Drawing.Point(264, 158);
            this.btnIslem2.Name = "btnIslem2";
            this.btnIslem2.Size = new System.Drawing.Size(152, 32);
            this.btnIslem2.TabIndex = 14;
            this.btnIslem2.Text = "İşlem 2";
            this.btnIslem2.UseVisualStyleBackColor = true;
            this.btnIslem2.Click += new System.EventHandler(this.btnIslem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(445, 470);
            this.Controls.Add(this.btnEuroSatis);
            this.Controls.Add(this.btnEuroAlis);
            this.Controls.Add(this.btnDolarSatis);
            this.Controls.Add(this.btnDolarAlis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDolarAlis;
        private System.Windows.Forms.Button btnDolarSatis;
        private System.Windows.Forms.Button btnEuroSatis;
        private System.Windows.Forms.Button btnEuroAlis;
        private System.Windows.Forms.Button btnIslem1;
        private System.Windows.Forms.Button btnIslem2;
    }
}

