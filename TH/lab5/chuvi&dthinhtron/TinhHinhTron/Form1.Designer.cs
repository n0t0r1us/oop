
namespace TinhHinhTron
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BanKinh = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thoat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 46);
            this.button5.TabIndex = 1;
            this.button5.Text = "DienTich";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(58, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 46);
            this.button6.TabIndex = 2;
            this.button6.Text = "ChuVi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Vào Bán Kính Đường Tròn";
            // 
            // BanKinh
            // 
            this.BanKinh.Location = new System.Drawing.Point(224, 26);
            this.BanKinh.Name = "BanKinh";
            this.BanKinh.Size = new System.Drawing.Size(268, 20);
            this.BanKinh.TabIndex = 4;
            this.BanKinh.Text = "0";
            this.BanKinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BanKinh.TextChanged += new System.EventHandler(this.BanKinh_TextChanged);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoEllipsis = true;
            this.lblKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetqua.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.lblKetqua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblKetqua.Location = new System.Drawing.Point(58, 156);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(452, 83);
            this.lblKetqua.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(680, 321);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.BanKinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BanKinh;
        private System.Windows.Forms.Label lblKetqua;
    }
}

