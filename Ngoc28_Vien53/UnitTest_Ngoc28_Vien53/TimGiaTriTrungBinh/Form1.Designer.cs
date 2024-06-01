namespace TimGiaTriTrungBinh
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
            this.soa = new System.Windows.Forms.TextBox();
            this.soc = new System.Windows.Forms.TextBox();
            this.sob = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soa
            // 
            this.soa.Location = new System.Drawing.Point(551, 88);
            this.soa.Name = "soa";
            this.soa.Size = new System.Drawing.Size(100, 31);
            this.soa.TabIndex = 0;
            // 
            // soc
            // 
            this.soc.Location = new System.Drawing.Point(551, 230);
            this.soc.Name = "soc";
            this.soc.Size = new System.Drawing.Size(100, 31);
            this.soc.TabIndex = 1;
            // 
            // sob
            // 
            this.sob.Location = new System.Drawing.Point(551, 159);
            this.sob.Name = "sob";
            this.sob.Size = new System.Drawing.Size(100, 31);
            this.sob.TabIndex = 2;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(551, 314);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(100, 31);
            this.kq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "So a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "so b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "so c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "kq";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(421, 419);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(130, 64);
            this.tb.TabIndex = 8;
            this.tb.Text = "tinh tb";
            this.tb.UseVisualStyleBackColor = true;
            this.tb.Click += new System.EventHandler(this.tb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 802);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.sob);
            this.Controls.Add(this.soc);
            this.Controls.Add(this.soa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soa;
        private System.Windows.Forms.TextBox soc;
        private System.Windows.Forms.TextBox sob;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tb;
    }
}

