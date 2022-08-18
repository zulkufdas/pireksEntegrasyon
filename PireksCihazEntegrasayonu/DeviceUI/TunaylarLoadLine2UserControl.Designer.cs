namespace PireksCihazEntegrasyonu.DeviceUI
{
    partial class TunaylarLoadLine2UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonTartimiKaydet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNet = new System.Windows.Forms.TextBox();
            this.textBoxTuru = new System.Windows.Forms.TextBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelGenelNetToplamBilgi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TUNAYLAR LOAD LINE 2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonKaydet);
            this.panel2.Controls.Add(this.buttonTartimiKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 57);
            this.panel2.TabIndex = 1;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.Location = new System.Drawing.Point(182, 0);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(198, 57);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonTartimiKaydet
            // 
            this.buttonTartimiKaydet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonTartimiKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTartimiKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTartimiKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonTartimiKaydet.Location = new System.Drawing.Point(0, 0);
            this.buttonTartimiKaydet.Name = "buttonTartimiKaydet";
            this.buttonTartimiKaydet.Size = new System.Drawing.Size(182, 57);
            this.buttonTartimiKaydet.TabIndex = 1;
            this.buttonTartimiKaydet.Text = "Tartım Oku";
            this.buttonTartimiKaydet.UseVisualStyleBackColor = false;
            this.buttonTartimiKaydet.Click += new System.EventHandler(this.buttonTartimiKaydet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxNet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTuru, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlaka, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 136);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxNet
            // 
            this.textBoxNet.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNet.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNet.Location = new System.Drawing.Point(201, 84);
            this.textBoxNet.Multiline = true;
            this.textBoxNet.Name = "textBoxNet";
            this.textBoxNet.Size = new System.Drawing.Size(176, 37);
            this.textBoxNet.TabIndex = 5;
            this.textBoxNet.Text = "0";
            this.textBoxNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNet.TextChanged += new System.EventHandler(this.textBoxNet_TextChanged_1);
            // 
            // textBoxTuru
            // 
            this.textBoxTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTuru.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxTuru.Location = new System.Drawing.Point(201, 44);
            this.textBoxTuru.Multiline = true;
            this.textBoxTuru.Name = "textBoxTuru";
            this.textBoxTuru.Size = new System.Drawing.Size(176, 34);
            this.textBoxTuru.TabIndex = 3;
            this.textBoxTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlaka.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlaka.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxPlaka.Location = new System.Drawing.Point(201, 3);
            this.textBoxPlaka.Multiline = true;
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(176, 35);
            this.textBoxPlaka.TabIndex = 0;
            this.textBoxPlaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(95, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLAKA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(95, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "TÜRÜ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "NET";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelGenelNetToplamBilgi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(380, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 260);
            this.panel3.TabIndex = 3;
            // 
            // labelGenelNetToplamBilgi
            // 
            this.labelGenelNetToplamBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGenelNetToplamBilgi.AutoEllipsis = true;
            this.labelGenelNetToplamBilgi.BackColor = System.Drawing.Color.White;
            this.labelGenelNetToplamBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGenelNetToplamBilgi.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelGenelNetToplamBilgi.Location = new System.Drawing.Point(30, 40);
            this.labelGenelNetToplamBilgi.Margin = new System.Windows.Forms.Padding(30);
            this.labelGenelNetToplamBilgi.Name = "labelGenelNetToplamBilgi";
            this.labelGenelNetToplamBilgi.Padding = new System.Windows.Forms.Padding(2);
            this.labelGenelNetToplamBilgi.Size = new System.Drawing.Size(276, 180);
            this.labelGenelNetToplamBilgi.TabIndex = 0;
            this.labelGenelNetToplamBilgi.Text = "0,00 KG.";
            this.labelGenelNetToplamBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TunaylarLoadLine2UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "TunaylarLoadLine2UserControl";
            this.Size = new System.Drawing.Size(716, 260);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNet;
        private System.Windows.Forms.TextBox textBoxTuru;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTartimiKaydet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelGenelNetToplamBilgi;
        private System.Windows.Forms.Button buttonKaydet;
    }
}
