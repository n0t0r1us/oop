
namespace TinhGiaXe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.loaixe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xe4cho = new System.Windows.Forms.RadioButton();
            this.txtQd = new System.Windows.Forms.TextBox();
            this.checkGiamgia = new System.Windows.Forms.CheckBox();
            this.Xe7cho = new System.Windows.Forms.RadioButton();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loaixe.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loaixe
            // 
            this.loaixe.Controls.Add(this.label2);
            this.loaixe.Controls.Add(this.txtKQ);
            this.loaixe.Controls.Add(this.Xe7cho);
            this.loaixe.Controls.Add(this.xe4cho);
            this.loaixe.Location = new System.Drawing.Point(42, 100);
            this.loaixe.Name = "loaixe";
            this.loaixe.Size = new System.Drawing.Size(294, 278);
            this.loaixe.TabIndex = 1;
            this.loaixe.TabStop = false;
            this.loaixe.Text = "Loại xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quảng đường (km)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // xe4cho
            // 
            this.xe4cho.AutoSize = true;
            this.xe4cho.Location = new System.Drawing.Point(29, 87);
            this.xe4cho.Name = "xe4cho";
            this.xe4cho.Size = new System.Drawing.Size(70, 19);
            this.xe4cho.TabIndex = 3;
            this.xe4cho.TabStop = true;
            this.xe4cho.Text = "Xe 4 chổ";
            this.xe4cho.UseVisualStyleBackColor = true;
            // 
            // txtQd
            // 
            this.txtQd.Location = new System.Drawing.Point(207, 49);
            this.txtQd.Name = "txtQd";
            this.txtQd.Size = new System.Drawing.Size(129, 23);
            this.txtQd.TabIndex = 4;
            this.txtQd.TextChanged += new System.EventHandler(this.txtQd_TextChanged);
            // 
            // checkGiamgia
            // 
            this.checkGiamgia.AutoSize = true;
            this.checkGiamgia.Location = new System.Drawing.Point(342, 188);
            this.checkGiamgia.Name = "checkGiamgia";
            this.checkGiamgia.Size = new System.Drawing.Size(76, 19);
            this.checkGiamgia.TabIndex = 5;
            this.checkGiamgia.Text = "Giảm giá ";
            this.checkGiamgia.UseVisualStyleBackColor = true;
            this.checkGiamgia.CheckedChanged += new System.EventHandler(this.checkGiamgia_CheckedChanged);
            // 
            // Xe7cho
            // 
            this.Xe7cho.AutoSize = true;
            this.Xe7cho.Location = new System.Drawing.Point(150, 87);
            this.Xe7cho.Name = "Xe7cho";
            this.Xe7cho.Size = new System.Drawing.Size(70, 19);
            this.Xe7cho.TabIndex = 6;
            this.Xe7cho.TabStop = true;
            this.Xe7cho.Text = "Xe 7 chổ";
            this.Xe7cho.UseVisualStyleBackColor = true;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(29, 231);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(194, 23);
            this.txtKQ.TabIndex = 6;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số tiền thanh toán :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkGiamgia);
            this.Controls.Add(this.txtQd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loaixe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bảng giá";
            this.loaixe.ResumeLayout(false);
            this.loaixe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox loaixe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.RadioButton Xe7cho;
        private System.Windows.Forms.RadioButton xe4cho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQd;
        private System.Windows.Forms.CheckBox checkGiamgia;
    }
}

