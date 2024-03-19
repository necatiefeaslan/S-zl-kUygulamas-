namespace SözlükUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btndegistir = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtboxDil1 = new System.Windows.Forms.TextBox();
            this.txtboxDil2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Türkçe"});
            this.comboBox1.Location = new System.Drawing.Point(62, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "İngilizce";
            // 
            // btndegistir
            // 
            this.btndegistir.Location = new System.Drawing.Point(257, 97);
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.Size = new System.Drawing.Size(31, 41);
            this.btndegistir.TabIndex = 2;
            this.btndegistir.Text = "---><---";
            this.btndegistir.UseVisualStyleBackColor = true;
            this.btndegistir.Click += new System.EventHandler(this.btndegistir_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(257, 154);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(39, 47);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtboxDil1
            // 
            this.txtboxDil1.Location = new System.Drawing.Point(41, 75);
            this.txtboxDil1.Multiline = true;
            this.txtboxDil1.Name = "txtboxDil1";
            this.txtboxDil1.Size = new System.Drawing.Size(174, 199);
            this.txtboxDil1.TabIndex = 5;
            this.txtboxDil1.TextChanged += new System.EventHandler(this.txtboxDil1_TextChanged);
            // 
            // txtboxDil2
            // 
            this.txtboxDil2.Location = new System.Drawing.Point(324, 75);
            this.txtboxDil2.Multiline = true;
            this.txtboxDil2.Name = "txtboxDil2";
            this.txtboxDil2.Size = new System.Drawing.Size(174, 199);
            this.txtboxDil2.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "İngilizce"});
            this.comboBox2.Location = new System.Drawing.Point(345, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Türkçe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 311);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtboxDil2);
            this.Controls.Add(this.txtboxDil1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btndegistir);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "çeviri 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btndegistir;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtboxDil1;
        private System.Windows.Forms.TextBox txtboxDil2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

