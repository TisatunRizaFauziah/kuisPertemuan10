namespace kuisPertemuan10
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
            this.txthasil = new System.Windows.Forms.TextBox();
            this.txtangka2 = new System.Windows.Forms.TextBox();
            this.txtangka1 = new System.Windows.Forms.TextBox();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthasil
            // 
            this.txthasil.AllowDrop = true;
            this.txthasil.Location = new System.Drawing.Point(238, 236);
            this.txthasil.Multiline = true;
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(379, 29);
            this.txthasil.TabIndex = 0;
            this.txthasil.TextChanged += new System.EventHandler(this.txthasil_TextChanged);
            // 
            // txtangka2
            // 
            this.txtangka2.Location = new System.Drawing.Point(238, 177);
            this.txtangka2.Multiline = true;
            this.txtangka2.Name = "txtangka2";
            this.txtangka2.Size = new System.Drawing.Size(379, 29);
            this.txtangka2.TabIndex = 1;
            // 
            // txtangka1
            // 
            this.txtangka1.Location = new System.Drawing.Point(238, 108);
            this.txtangka1.Multiline = true;
            this.txtangka1.Name = "txtangka1";
            this.txtangka1.Size = new System.Drawing.Size(379, 29);
            this.txtangka1.TabIndex = 2;
            // 
            // btnkali
            // 
            this.btnkali.Location = new System.Drawing.Point(549, 307);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(68, 47);
            this.btnkali.TabIndex = 3;
            this.btnkali.Text = "X";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.Location = new System.Drawing.Point(437, 307);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(68, 47);
            this.btnbagi.TabIndex = 4;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.Location = new System.Drawing.Point(336, 307);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(68, 47);
            this.btnkurang.TabIndex = 5;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            this.btnkurang.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(238, 307);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(68, 47);
            this.btntambah.TabIndex = 6;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Angka 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Angka 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hasil :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kalukatore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.txtangka1);
            this.Controls.Add(this.txtangka2);
            this.Controls.Add(this.txthasil);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.TextBox txtangka2;
        private System.Windows.Forms.TextBox txtangka1;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

