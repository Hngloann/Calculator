
namespace Calculator
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
            this.lbTinhToan = new System.Windows.Forms.Label();
            this.lbSoa = new System.Windows.Forms.Label();
            this.lbSob = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTinhToan
            // 
            this.lbTinhToan.AutoSize = true;
            this.lbTinhToan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTinhToan.Location = new System.Drawing.Point(151, 20);
            this.lbTinhToan.Name = "lbTinhToan";
            this.lbTinhToan.Size = new System.Drawing.Size(134, 30);
            this.lbTinhToan.TabIndex = 0;
            this.lbTinhToan.Text = "TÍNH TOÁN";
            // 
            // lbSoa
            // 
            this.lbSoa.AutoSize = true;
            this.lbSoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSoa.Location = new System.Drawing.Point(12, 63);
            this.lbSoa.Name = "lbSoa";
            this.lbSoa.Size = new System.Drawing.Size(54, 28);
            this.lbSoa.TabIndex = 0;
            this.lbSoa.Text = "Số a:";
            // 
            // lbSob
            // 
            this.lbSob.AutoSize = true;
            this.lbSob.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSob.Location = new System.Drawing.Point(12, 102);
            this.lbSob.Name = "lbSob";
            this.lbSob.Size = new System.Drawing.Size(56, 28);
            this.lbSob.TabIndex = 0;
            this.lbSob.Text = "Số b:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKQ.Location = new System.Drawing.Point(12, 141);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(83, 28);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "Kết quả:";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(103, 71);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(288, 23);
            this.txtSoa.TabIndex = 1;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(103, 107);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(288, 23);
            this.txtSob.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(103, 146);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(288, 23);
            this.txtKetQua.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(289, 190);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 38);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 269);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbSob);
            this.Controls.Add(this.lbSoa);
            this.Controls.Add(this.lbTinhToan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTinhToan;
        private System.Windows.Forms.Label lbSoa;
        private System.Windows.Forms.Label lbSob;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btCong;
    }
}

