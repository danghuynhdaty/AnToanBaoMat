namespace AnToanBaoMat
{
    partial class frmMain
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
            this.btnExcute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAlgorithm = new System.Windows.Forms.ComboBox();
            this.cbxProgress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbxKey = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(338, 199);
            this.btnExcute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(100, 28);
            this.btnExcute.TabIndex = 0;
            this.btnExcute.Text = "Thực hiện";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thuật toán mã hóa";
            // 
            // cbxAlgorithm
            // 
            this.cbxAlgorithm.FormattingEnabled = true;
            this.cbxAlgorithm.Items.AddRange(new object[] {
            "Ceasar",
            "Playfair"});
            this.cbxAlgorithm.Location = new System.Drawing.Point(172, 52);
            this.cbxAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAlgorithm.Name = "cbxAlgorithm";
            this.cbxAlgorithm.Size = new System.Drawing.Size(266, 24);
            this.cbxAlgorithm.TabIndex = 2;
            // 
            // cbxProgress
            // 
            this.cbxProgress.FormattingEnabled = true;
            this.cbxProgress.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cbxProgress.Location = new System.Drawing.Point(172, 167);
            this.cbxProgress.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProgress.Name = "cbxProgress";
            this.cbxProgress.Size = new System.Drawing.Size(266, 24);
            this.cbxProgress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiến trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dữ liệu";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(169, 21);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(17, 16);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "...";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(391, 15);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(47, 28);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khóa";
            // 
            // rtbxKey
            // 
            this.rtbxKey.Location = new System.Drawing.Point(172, 83);
            this.rtbxKey.Name = "rtbxKey";
            this.rtbxKey.Size = new System.Drawing.Size(266, 77);
            this.rtbxKey.TabIndex = 9;
            this.rtbxKey.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 237);
            this.Controls.Add(this.rtbxKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAlgorithm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "An toàn bảo mật hệ thống thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAlgorithm;
        private System.Windows.Forms.ComboBox cbxProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbxKey;
    }
}

