namespace TongSoNguyenTo
{
    partial class danhsach
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
            this.batdau = new System.Windows.Forms.TextBox();
            this.ketthuc = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tinhtong = new System.Windows.Forms.Button();
            this.danhsachnguyento = new System.Windows.Forms.ListBox();
            this.sum = new System.Windows.Forms.Label();
            this.tong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // batdau
            // 
            this.batdau.Location = new System.Drawing.Point(184, 74);
            this.batdau.Name = "batdau";
            this.batdau.Size = new System.Drawing.Size(100, 31);
            this.batdau.TabIndex = 0;
            // 
            // ketthuc
            // 
            this.ketthuc.Location = new System.Drawing.Point(184, 131);
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.Size = new System.Drawing.Size(100, 31);
            this.ketthuc.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(84, 80);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(89, 25);
            this.Start.TabIndex = 2;
            this.Start.Text = "Bat Dau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ket thuc";
            // 
            // tinhtong
            // 
            this.tinhtong.Location = new System.Drawing.Point(99, 243);
            this.tinhtong.Name = "tinhtong";
            this.tinhtong.Size = new System.Drawing.Size(113, 52);
            this.tinhtong.TabIndex = 4;
            this.tinhtong.Text = "Tinh tong";
            this.tinhtong.UseVisualStyleBackColor = true;
            this.tinhtong.Click += new System.EventHandler(this.tinhtong_Click);
            // 
            // danhsachnguyento
            // 
            this.danhsachnguyento.FormattingEnabled = true;
            this.danhsachnguyento.ItemHeight = 25;
            this.danhsachnguyento.Location = new System.Drawing.Point(758, 104);
            this.danhsachnguyento.Name = "danhsachnguyento";
            this.danhsachnguyento.Size = new System.Drawing.Size(381, 304);
            this.danhsachnguyento.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(197, 193);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 25);
            this.sum.TabIndex = 6;
            // 
            // tong
            // 
            this.tong.Location = new System.Drawing.Point(175, 187);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(100, 31);
            this.tong.TabIndex = 7;
            // 
            // danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 695);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.danhsachnguyento);
            this.Controls.Add(this.tinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ketthuc);
            this.Controls.Add(this.batdau);
            this.Name = "danhsach";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox batdau;
        private System.Windows.Forms.TextBox ketthuc;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tinhtong;
        private System.Windows.Forms.ListBox danhsachnguyento;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.TextBox tong;
    }
}

