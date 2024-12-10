namespace mulasztasokGUI_20241210
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
            this.dgvadatok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osztaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanyadika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igazolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemigazolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszeshiany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbadatok = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lboraksz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbtanulok = new System.Windows.Forms.RichTextBox();
            this.txnev = new System.Windows.Forms.TextBox();
            this.txosztaly = new System.Windows.Forms.TextBox();
            this.txigazolt = new System.Windows.Forms.TextBox();
            this.txnemigaolt = new System.Windows.Forms.TextBox();
            this.cbhanyadik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adatok";
            // 
            // dgvadatok
            // 
            this.dgvadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.osztaly,
            this.hanyadika,
            this.igazolt,
            this.nemigazolt,
            this.osszeshiany});
            this.dgvadatok.Location = new System.Drawing.Point(18, 217);
            this.dgvadatok.Name = "dgvadatok";
            this.dgvadatok.Size = new System.Drawing.Size(556, 230);
            this.dgvadatok.TabIndex = 1;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 130;
            // 
            // osztaly
            // 
            this.osztaly.HeaderText = "Osztály";
            this.osztaly.Name = "osztaly";
            this.osztaly.ReadOnly = true;
            this.osztaly.Width = 60;
            // 
            // hanyadika
            // 
            this.hanyadika.HeaderText = "Hányadika";
            this.hanyadika.Name = "hanyadika";
            this.hanyadika.Width = 70;
            // 
            // igazolt
            // 
            this.igazolt.HeaderText = "Igazolt";
            this.igazolt.Name = "igazolt";
            this.igazolt.Width = 60;
            // 
            // nemigazolt
            // 
            this.nemigazolt.HeaderText = "Nem Igazolt";
            this.nemigazolt.Name = "nemigazolt";
            this.nemigazolt.Width = 60;
            // 
            // osszeshiany
            // 
            this.osszeshiany.HeaderText = "Összes hiányzás";
            this.osszeshiany.Name = "osszeshiany";
            // 
            // rtbadatok
            // 
            this.rtbadatok.Location = new System.Drawing.Point(18, 29);
            this.rtbadatok.Name = "rtbadatok";
            this.rtbadatok.Size = new System.Drawing.Size(556, 182);
            this.rtbadatok.TabIndex = 2;
            this.rtbadatok.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 182);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Osztály: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hányadikán: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Igazolt: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nem igazolt: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbtanulok);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lboraksz);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(583, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Összes hiányzása adott napon: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Legtöbb hiányzás";
            // 
            // lboraksz
            // 
            this.lboraksz.AutoSize = true;
            this.lboraksz.Location = new System.Drawing.Point(12, 124);
            this.lboraksz.Name = "lboraksz";
            this.lboraksz.Size = new System.Drawing.Size(81, 13);
            this.lboraksz.TabIndex = 1;
            this.lboraksz.Text = "Órák száma: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tanulók";
            // 
            // rtbtanulok
            // 
            this.rtbtanulok.Location = new System.Drawing.Point(187, 106);
            this.rtbtanulok.Name = "rtbtanulok";
            this.rtbtanulok.Size = new System.Drawing.Size(145, 109);
            this.rtbtanulok.TabIndex = 3;
            this.rtbtanulok.Text = "";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(624, 26);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(137, 20);
            this.txnev.TabIndex = 10;
            // 
            // txosztaly
            // 
            this.txosztaly.Location = new System.Drawing.Point(642, 59);
            this.txosztaly.Name = "txosztaly";
            this.txosztaly.Size = new System.Drawing.Size(52, 20);
            this.txosztaly.TabIndex = 11;
            // 
            // txigazolt
            // 
            this.txigazolt.Location = new System.Drawing.Point(639, 133);
            this.txigazolt.Name = "txigazolt";
            this.txigazolt.Size = new System.Drawing.Size(70, 20);
            this.txigazolt.TabIndex = 12;
            this.txigazolt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txnemigaolt
            // 
            this.txnemigaolt.Location = new System.Drawing.Point(661, 169);
            this.txnemigaolt.Name = "txnemigaolt";
            this.txnemigaolt.Size = new System.Drawing.Size(70, 20);
            this.txnemigaolt.TabIndex = 14;
            this.txnemigaolt.TextChanged += new System.EventHandler(this.txnemigaolt_TextChanged);
            // 
            // cbhanyadik
            // 
            this.cbhanyadik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhanyadik.FormattingEnabled = true;
            this.cbhanyadik.Location = new System.Drawing.Point(661, 93);
            this.cbhanyadik.Name = "cbhanyadik";
            this.cbhanyadik.Size = new System.Drawing.Size(83, 21);
            this.cbhanyadik.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.cbhanyadik);
            this.Controls.Add(this.txnemigaolt);
            this.Controls.Add(this.txigazolt);
            this.Controls.Add(this.txosztaly);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbadatok);
            this.Controls.Add(this.dgvadatok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mulasztások - szeptember hónap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanyadika;
        private System.Windows.Forms.DataGridViewTextBoxColumn igazolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemigazolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszeshiany;
        private System.Windows.Forms.RichTextBox rtbadatok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbtanulok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lboraksz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.TextBox txosztaly;
        private System.Windows.Forms.TextBox txigazolt;
        private System.Windows.Forms.TextBox txnemigaolt;
        private System.Windows.Forms.ComboBox cbhanyadik;
    }
}

