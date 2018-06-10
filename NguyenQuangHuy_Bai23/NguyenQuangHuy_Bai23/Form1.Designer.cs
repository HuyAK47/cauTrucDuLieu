namespace NguyenQuangHuy_Bai23
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPostfixBT = new System.Windows.Forms.RadioButton();
            this.rbtnPrefixBT = new System.Windows.Forms.RadioButton();
            this.rbtnInfixBT = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnPostfixCD = new System.Windows.Forms.RadioButton();
            this.rbtnPrefixCD = new System.Windows.Forms.RadioButton();
            this.rbtnInfixCD = new System.Windows.Forms.RadioButton();
            this.txtChuyenDoi = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnPostfixBT);
            this.groupBox1.Controls.Add(this.rbtnPrefixBT);
            this.groupBox1.Controls.Add(this.rbtnInfixBT);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập biểu thức";
            // 
            // rbtnPostfixBT
            // 
            this.rbtnPostfixBT.AutoSize = true;
            this.rbtnPostfixBT.Location = new System.Drawing.Point(41, 216);
            this.rbtnPostfixBT.Name = "rbtnPostfixBT";
            this.rbtnPostfixBT.Size = new System.Drawing.Size(112, 33);
            this.rbtnPostfixBT.TabIndex = 3;
            this.rbtnPostfixBT.TabStop = true;
            this.rbtnPostfixBT.Text = "Postfix";
            this.rbtnPostfixBT.UseVisualStyleBackColor = true;
            // 
            // rbtnPrefixBT
            // 
            this.rbtnPrefixBT.AutoSize = true;
            this.rbtnPrefixBT.Location = new System.Drawing.Point(41, 159);
            this.rbtnPrefixBT.Name = "rbtnPrefixBT";
            this.rbtnPrefixBT.Size = new System.Drawing.Size(101, 33);
            this.rbtnPrefixBT.TabIndex = 2;
            this.rbtnPrefixBT.TabStop = true;
            this.rbtnPrefixBT.Text = "Prefix";
            this.rbtnPrefixBT.UseVisualStyleBackColor = true;
            // 
            // rbtnInfixBT
            // 
            this.rbtnInfixBT.AutoSize = true;
            this.rbtnInfixBT.Location = new System.Drawing.Point(41, 110);
            this.rbtnInfixBT.Name = "rbtnInfixBT";
            this.rbtnInfixBT.Size = new System.Drawing.Size(81, 33);
            this.rbtnInfixBT.TabIndex = 1;
            this.rbtnInfixBT.TabStop = true;
            this.rbtnInfixBT.Text = "Infix";
            this.rbtnInfixBT.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhap.Location = new System.Drawing.Point(6, 39);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(358, 48);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.Text = "5+7/9*3-4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHUYỂN ĐỔI BIỂU THỨC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnPostfixCD);
            this.groupBox2.Controls.Add(this.rbtnPrefixCD);
            this.groupBox2.Controls.Add(this.rbtnInfixCD);
            this.groupBox2.Controls.Add(this.txtChuyenDoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(455, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 319);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển đổi biểu thức";
            // 
            // rbtnPostfixCD
            // 
            this.rbtnPostfixCD.AutoSize = true;
            this.rbtnPostfixCD.Location = new System.Drawing.Point(39, 216);
            this.rbtnPostfixCD.Name = "rbtnPostfixCD";
            this.rbtnPostfixCD.Size = new System.Drawing.Size(112, 33);
            this.rbtnPostfixCD.TabIndex = 7;
            this.rbtnPostfixCD.Text = "Postfix";
            this.rbtnPostfixCD.UseVisualStyleBackColor = true;
            // 
            // rbtnPrefixCD
            // 
            this.rbtnPrefixCD.AutoSize = true;
            this.rbtnPrefixCD.Location = new System.Drawing.Point(39, 159);
            this.rbtnPrefixCD.Name = "rbtnPrefixCD";
            this.rbtnPrefixCD.Size = new System.Drawing.Size(101, 33);
            this.rbtnPrefixCD.TabIndex = 6;
            this.rbtnPrefixCD.Text = "Prefix";
            this.rbtnPrefixCD.UseVisualStyleBackColor = true;
            // 
            // rbtnInfixCD
            // 
            this.rbtnInfixCD.AutoSize = true;
            this.rbtnInfixCD.Location = new System.Drawing.Point(39, 110);
            this.rbtnInfixCD.Name = "rbtnInfixCD";
            this.rbtnInfixCD.Size = new System.Drawing.Size(81, 33);
            this.rbtnInfixCD.TabIndex = 5;
            this.rbtnInfixCD.Text = "Infix";
            this.rbtnInfixCD.UseVisualStyleBackColor = true;
            // 
            // txtChuyenDoi
            // 
            this.txtChuyenDoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtChuyenDoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChuyenDoi.Enabled = false;
            this.txtChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenDoi.Location = new System.Drawing.Point(6, 39);
            this.txtChuyenDoi.Multiline = true;
            this.txtChuyenDoi.Name = "txtChuyenDoi";
            this.txtChuyenDoi.Size = new System.Drawing.Size(358, 48);
            this.txtChuyenDoi.TabIndex = 4;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(334, 475);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(166, 30);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.Text = "              Kết quả";
            // 
            // btnKetQua
            // 
            this.btnKetQua.BackColor = System.Drawing.Color.Transparent;
            this.btnKetQua.BackgroundImage = global::NguyenQuangHuy_Bai23.Properties.Resources._1000px_HILLBLU_button_background_svg;
            this.btnKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKetQua.Location = new System.Drawing.Point(334, 521);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(166, 41);
            this.btnKetQua.TabIndex = 4;
            this.btnKetQua.Text = "Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = false;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NguyenQuangHuy_Bai23.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 577);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnPostfixBT;
        private System.Windows.Forms.RadioButton rbtnPrefixBT;
        private System.Windows.Forms.RadioButton rbtnInfixBT;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.RadioButton rbtnPostfixCD;
        private System.Windows.Forms.RadioButton rbtnPrefixCD;
        private System.Windows.Forms.RadioButton rbtnInfixCD;
        private System.Windows.Forms.TextBox txtChuyenDoi;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnKetQua;
    }
}

