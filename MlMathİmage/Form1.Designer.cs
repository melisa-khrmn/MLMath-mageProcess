namespace MlMathİmage
{
    partial class form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.txtMatrixResult = new System.Windows.Forms.TextBox();
            this.btnML = new System.Windows.Forms.Button();
            this.lblMLGirdisi = new System.Windows.Forms.Label();
            this.lblMatrixSonucu = new System.Windows.Forms.Label();
            this.txtMLİnput = new System.Windows.Forms.TextBox();
            this.txtMLOutput = new System.Windows.Forms.TextBox();
            this.lblTahminSonucu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(83, 290);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Resim Yükle";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(193, 290);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(119, 23);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "Gri Tona Çevir";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(427, 290);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(114, 23);
            this.btnMatrix.TabIndex = 4;
            this.btnMatrix.Text = "Matris Oluştur";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // txtMatrixResult
            // 
            this.txtMatrixResult.Location = new System.Drawing.Point(48, 398);
            this.txtMatrixResult.Multiline = true;
            this.txtMatrixResult.Name = "txtMatrixResult";
            this.txtMatrixResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrixResult.Size = new System.Drawing.Size(280, 150);
            this.txtMatrixResult.TabIndex = 5;
            // 
            // btnML
            // 
            this.btnML.Location = new System.Drawing.Point(547, 290);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(99, 23);
            this.btnML.TabIndex = 6;
            this.btnML.Text = "Tahmin Yap";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.btnML_Click);
            // 
            // lblMLGirdisi
            // 
            this.lblMLGirdisi.AutoSize = true;
            this.lblMLGirdisi.Location = new System.Drawing.Point(361, 378);
            this.lblMLGirdisi.Name = "lblMLGirdisi";
            this.lblMLGirdisi.Size = new System.Drawing.Size(71, 17);
            this.lblMLGirdisi.TabIndex = 7;
            this.lblMLGirdisi.Text = "ML Girdisi";
            // 
            // lblMatrixSonucu
            // 
            this.lblMatrixSonucu.AutoSize = true;
            this.lblMatrixSonucu.Location = new System.Drawing.Point(54, 378);
            this.lblMatrixSonucu.Name = "lblMatrixSonucu";
            this.lblMatrixSonucu.Size = new System.Drawing.Size(98, 17);
            this.lblMatrixSonucu.TabIndex = 8;
            this.lblMatrixSonucu.Text = "Matris Sonucu";
            // 
            // txtMLİnput
            // 
            this.txtMLİnput.Location = new System.Drawing.Point(364, 398);
            this.txtMLİnput.Name = "txtMLİnput";
            this.txtMLİnput.Size = new System.Drawing.Size(300, 22);
            this.txtMLİnput.TabIndex = 9;
            // 
            // txtMLOutput
            // 
            this.txtMLOutput.Location = new System.Drawing.Point(364, 526);
            this.txtMLOutput.Name = "txtMLOutput";
            this.txtMLOutput.Size = new System.Drawing.Size(300, 22);
            this.txtMLOutput.TabIndex = 10;
            // 
            // lblTahminSonucu
            // 
            this.lblTahminSonucu.AutoSize = true;
            this.lblTahminSonucu.Location = new System.Drawing.Point(361, 506);
            this.lblTahminSonucu.Name = "lblTahminSonucu";
            this.lblTahminSonucu.Size = new System.Drawing.Size(107, 17);
            this.lblTahminSonucu.TabIndex = 11;
            this.lblTahminSonucu.Text = "Tahmin Sonucu";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 569);
            this.Controls.Add(this.lblTahminSonucu);
            this.Controls.Add(this.txtMLOutput);
            this.Controls.Add(this.txtMLİnput);
            this.Controls.Add(this.lblMatrixSonucu);
            this.Controls.Add(this.lblMLGirdisi);
            this.Controls.Add(this.btnML);
            this.Controls.Add(this.txtMatrixResult);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.TextBox txtMatrixResult;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Label lblMLGirdisi;
        private System.Windows.Forms.Label lblMatrixSonucu;
        private System.Windows.Forms.TextBox txtMLİnput;
        private System.Windows.Forms.TextBox txtMLOutput;
        private System.Windows.Forms.Label lblTahminSonucu;
    }
}

