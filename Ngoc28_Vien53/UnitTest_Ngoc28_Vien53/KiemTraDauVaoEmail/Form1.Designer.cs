namespace KiemTraDauVaoEmail
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
            this.nhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kiemtra = new System.Windows.Forms.Button();
            this.kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(328, 121);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(356, 31);
            this.nhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // kiemtra
            // 
            this.kiemtra.Location = new System.Drawing.Point(105, 211);
            this.kiemtra.Name = "kiemtra";
            this.kiemtra.Size = new System.Drawing.Size(198, 73);
            this.kiemtra.TabIndex = 2;
            this.kiemtra.Text = "Kiem tra";
            this.kiemtra.UseVisualStyleBackColor = true;
            this.kiemtra.Click += new System.EventHandler(this.kiemtra_Click);
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(328, 253);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(356, 31);
            this.kq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 755);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.kiemtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kiemtra;
        private System.Windows.Forms.TextBox kq;
    }
}

