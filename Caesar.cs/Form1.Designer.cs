namespace DemoCeasar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblBest = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnBrute = new System.Windows.Forms.Button();
            this.btnNapTuDien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInput.Location = new System.Drawing.Point(101, 16);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(512, 201);
            this.txtInput.TabIndex = 0;
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 17;
            this.lstResults.Location = new System.Drawing.Point(633, 133);
            this.lstResults.Margin = new System.Windows.Forms.Padding(2);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(948, 412);
            this.lstResults.TabIndex = 2;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBest.Location = new System.Drawing.Point(633, 110);
            this.lblBest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(193, 19);
            this.lblBest.TabIndex = 15;
            this.lblBest.Text = "hiển thị kết quả rõ đúng nhất:";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOutput.Location = new System.Drawing.Point(101, 231);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(512, 200);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Enter += new System.EventHandler(this.txtOutput_Enter);
            this.txtOutput.Leave += new System.EventHandler(this.txtOutput_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnHuongDan);
            this.groupBox1.Controls.Add(this.btnBrute);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.btnNapTuDien);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(617, 491);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều Khiển";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Image = global::DemoCeasar.Properties.Resources.instructions_19;
            this.btnHuongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuongDan.Location = new System.Drawing.Point(11, 57);
            this.btnHuongDan.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(86, 36);
            this.btnHuongDan.TabIndex = 11;
            this.btnHuongDan.Text = "Hướng Dẫn";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnBrute
            // 
            this.btnBrute.Image = global::DemoCeasar.Properties.Resources.hammer_19;
            this.btnBrute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrute.Location = new System.Drawing.Point(11, 231);
            this.btnBrute.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrute.Name = "btnBrute";
            this.btnBrute.Size = new System.Drawing.Size(86, 36);
            this.btnBrute.TabIndex = 5;
            this.btnBrute.Text = "Giải Mã";
            this.btnBrute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrute.UseVisualStyleBackColor = true;
            this.btnBrute.Click += new System.EventHandler(this.btnBrute_Click);
            // 
            // btnNapTuDien
            // 
            this.btnNapTuDien.Image = global::DemoCeasar.Properties.Resources.dictionary_19;
            this.btnNapTuDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNapTuDien.Location = new System.Drawing.Point(11, 16);
            this.btnNapTuDien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNapTuDien.Name = "btnNapTuDien";
            this.btnNapTuDien.Size = new System.Drawing.Size(86, 37);
            this.btnNapTuDien.TabIndex = 1;
            this.btnNapTuDien.Text = "Tải từ điển";
            this.btnNapTuDien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNapTuDien.UseVisualStyleBackColor = true;
            this.btnNapTuDien.Click += new System.EventHandler(this.btnNapTuDien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(589, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ứng dụng mã hóa Cipher Brute-force";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(113, 556);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 31);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(483, 556);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 31);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::DemoCeasar.Properties.Resources.exit_19;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1520, 585);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(61, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoCeasar.Properties.Resources.Logo_STU;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1616, 628);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.lstResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Ứng dụng mã hóa Cipher Brute-force";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNapTuDien;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnThoat;
    }
}
