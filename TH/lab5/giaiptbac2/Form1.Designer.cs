
namespace ptBac2_FORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesoa = new System.Windows.Forms.TextBox();
            this.txtHesob = new System.Windows.Forms.TextBox();
            this.txtHesoc = new System.Windows.Forms.TextBox();
            this.btngiai = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnketqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập hệ số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập hệ số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "nhập hệ số c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(330, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "nghiệm của phương trình:";
            // 
            // txtHesoa
            // 
            this.txtHesoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHesoa.Location = new System.Drawing.Point(145, 50);
            this.txtHesoa.Name = "txtHesoa";
            this.txtHesoa.Size = new System.Drawing.Size(148, 26);
            this.txtHesoa.TabIndex = 4;
            this.txtHesoa.TextChanged += new System.EventHandler(this.txtHesoa_TextChanged);
            // 
            // txtHesob
            // 
            this.txtHesob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHesob.Location = new System.Drawing.Point(145, 107);
            this.txtHesob.Name = "txtHesob";
            this.txtHesob.Size = new System.Drawing.Size(148, 26);
            this.txtHesob.TabIndex = 5;
            this.txtHesob.TextChanged += new System.EventHandler(this.txtHesob_TextChanged);
            // 
            // txtHesoc
            // 
            this.txtHesoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHesoc.Location = new System.Drawing.Point(145, 164);
            this.txtHesoc.Name = "txtHesoc";
            this.txtHesoc.Size = new System.Drawing.Size(148, 26);
            this.txtHesoc.TabIndex = 6;
            this.txtHesoc.TextChanged += new System.EventHandler(this.txtHesoc_TextChanged);
            // 
            // btngiai
            // 
            this.btngiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btngiai.Location = new System.Drawing.Point(30, 233);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(126, 67);
            this.btngiai.TabIndex = 7;
            this.btngiai.Text = "giải";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnclose.Location = new System.Drawing.Point(162, 233);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(131, 67);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "thoát";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnketqua
            // 
            this.btnketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnketqua.Location = new System.Drawing.Point(334, 107);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(337, 193);
            this.btnketqua.TabIndex = 9;
            this.btnketqua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.txtHesoc);
            this.Controls.Add(this.txtHesob);
            this.Controls.Add(this.txtHesoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesoa;
        private System.Windows.Forms.TextBox txtHesob;
        private System.Windows.Forms.TextBox txtHesoc;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnketqua;
    }
}

