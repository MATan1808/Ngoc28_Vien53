namespace Bai_2_28_KimNgoc
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
            this.sox = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.son = new System.Windows.Forms.TextBox();
            this.luythua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kq";
            // 
            // sox
            // 
            this.sox.Location = new System.Drawing.Point(339, 70);
            this.sox.Name = "sox";
            this.sox.Size = new System.Drawing.Size(330, 31);
            this.sox.TabIndex = 3;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(339, 199);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(330, 31);
            this.kq.TabIndex = 4;
            this.kq.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // son
            // 
            this.son.Location = new System.Drawing.Point(339, 134);
            this.son.Name = "son";
            this.son.Size = new System.Drawing.Size(330, 31);
            this.son.TabIndex = 5;
            // 
            // luythua
            // 
            this.luythua.Location = new System.Drawing.Point(279, 303);
            this.luythua.Name = "luythua";
            this.luythua.Size = new System.Drawing.Size(301, 91);
            this.luythua.TabIndex = 6;
            this.luythua.Text = "Tinh luy thua";
            this.luythua.UseVisualStyleBackColor = true;
            this.luythua.Click += new System.EventHandler(this.bang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 566);
            this.Controls.Add(this.luythua);
            this.Controls.Add(this.son);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.sox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "28_KimNgoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sox;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.TextBox son;
        private System.Windows.Forms.Button luythua;
    }
}

