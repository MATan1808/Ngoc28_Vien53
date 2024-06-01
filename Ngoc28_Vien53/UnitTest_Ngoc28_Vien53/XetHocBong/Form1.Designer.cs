namespace XetHocBong
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
            this.diem1 = new System.Windows.Forms.TextBox();
            this.diem2 = new System.Windows.Forms.TextBox();
            this.diem3 = new System.Windows.Forms.TextBox();
            this.dtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ktra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.renluyen = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // diem1
            // 
            this.diem1.Location = new System.Drawing.Point(305, 69);
            this.diem1.Name = "diem1";
            this.diem1.Size = new System.Drawing.Size(100, 31);
            this.diem1.TabIndex = 0;
            // 
            // diem2
            // 
            this.diem2.Location = new System.Drawing.Point(305, 141);
            this.diem2.Name = "diem2";
            this.diem2.Size = new System.Drawing.Size(100, 31);
            this.diem2.TabIndex = 1;
            // 
            // diem3
            // 
            this.diem3.Location = new System.Drawing.Point(305, 210);
            this.diem3.Name = "diem3";
            this.diem3.Size = new System.Drawing.Size(100, 31);
            this.diem3.TabIndex = 2;
            // 
            // dtb
            // 
            this.dtb.Location = new System.Drawing.Point(305, 285);
            this.dtb.Name = "dtb";
            this.dtb.Size = new System.Drawing.Size(214, 31);
            this.dtb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "d1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "d2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "d3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "DTB";
            // 
            // ktra
            // 
            this.ktra.Location = new System.Drawing.Point(166, 442);
            this.ktra.Name = "ktra";
            this.ktra.Size = new System.Drawing.Size(201, 65);
            this.ktra.TabIndex = 8;
            this.ktra.Text = "Ket qua";
            this.ktra.UseVisualStyleBackColor = true;
            this.ktra.Click += new System.EventHandler(this.ktra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "RL";
            // 
            // renluyen
            // 
            this.renluyen.Location = new System.Drawing.Point(305, 345);
            this.renluyen.Name = "renluyen";
            this.renluyen.Size = new System.Drawing.Size(100, 31);
            this.renluyen.TabIndex = 10;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(433, 476);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(305, 31);
            this.kq.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 664);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.renluyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ktra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb);
            this.Controls.Add(this.diem3);
            this.Controls.Add(this.diem2);
            this.Controls.Add(this.diem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diem1;
        private System.Windows.Forms.TextBox diem2;
        private System.Windows.Forms.TextBox diem3;
        private System.Windows.Forms.TextBox dtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ktra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox renluyen;
        private System.Windows.Forms.TextBox kq;
    }
}

