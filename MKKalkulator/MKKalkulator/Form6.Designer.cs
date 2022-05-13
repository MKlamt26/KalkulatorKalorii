
namespace MKKalkulator
{
    partial class Form6
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
            this.UsuńZdnia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajDoDnia = new System.Windows.Forms.Button();
            this.textNazwa = new System.Windows.Forms.TextBox();
            this.Pobierz = new System.Windows.Forms.Button();
            this.ListaBazy = new System.Windows.Forms.ListBox();
            this.textKalorie = new System.Windows.Forms.TextBox();
            this.textBilko = new System.Windows.Forms.TextBox();
            this.textTluszcz = new System.Windows.Forms.TextBox();
            this.textWegle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuńZdnia
            // 
            this.UsuńZdnia.Location = new System.Drawing.Point(306, 255);
            this.UsuńZdnia.Name = "UsuńZdnia";
            this.UsuńZdnia.Size = new System.Drawing.Size(113, 29);
            this.UsuńZdnia.TabIndex = 50;
            this.UsuńZdnia.Text = "UsuńZBazy";
            this.UsuńZdnia.UseVisualStyleBackColor = true;
            this.UsuńZdnia.Click += new System.EventHandler(this.UsuńZdnia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(30, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Węglowodany na 100g";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tłuszcz na 100g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Białko na 100g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kalorie na 100g";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nazwa Produktu";
            // 
            // DodajDoDnia
            // 
            this.DodajDoDnia.Location = new System.Drawing.Point(306, 205);
            this.DodajDoDnia.Name = "DodajDoDnia";
            this.DodajDoDnia.Size = new System.Drawing.Size(113, 29);
            this.DodajDoDnia.TabIndex = 35;
            this.DodajDoDnia.Text = "DodajDoBazy";
            this.DodajDoDnia.UseVisualStyleBackColor = true;
            this.DodajDoDnia.Click += new System.EventHandler(this.DodajDoDnia_Click);
            // 
            // textNazwa
            // 
            this.textNazwa.Location = new System.Drawing.Point(197, 57);
            this.textNazwa.Name = "textNazwa";
            this.textNazwa.Size = new System.Drawing.Size(94, 27);
            this.textNazwa.TabIndex = 33;
            // 
            // Pobierz
            // 
            this.Pobierz.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Pobierz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Pobierz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pobierz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pobierz.Location = new System.Drawing.Point(37, 354);
            this.Pobierz.Name = "Pobierz";
            this.Pobierz.Size = new System.Drawing.Size(206, 29);
            this.Pobierz.TabIndex = 30;
            this.Pobierz.Text = "Wyświetl Bazę Produktów";
            this.Pobierz.UseVisualStyleBackColor = true;
            this.Pobierz.Click += new System.EventHandler(this.Pobierz_Click);
            // 
            // ListaBazy
            // 
            this.ListaBazy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ListaBazy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaBazy.FormattingEnabled = true;
            this.ListaBazy.ItemHeight = 20;
            this.ListaBazy.Location = new System.Drawing.Point(306, 318);
            this.ListaBazy.Name = "ListaBazy";
            this.ListaBazy.Size = new System.Drawing.Size(124, 120);
            this.ListaBazy.TabIndex = 26;
            // 
            // textKalorie
            // 
            this.textKalorie.Location = new System.Drawing.Point(197, 101);
            this.textKalorie.Name = "textKalorie";
            this.textKalorie.Size = new System.Drawing.Size(94, 27);
            this.textKalorie.TabIndex = 52;
            // 
            // textBilko
            // 
            this.textBilko.Location = new System.Drawing.Point(197, 154);
            this.textBilko.Name = "textBilko";
            this.textBilko.Size = new System.Drawing.Size(94, 27);
            this.textBilko.TabIndex = 53;
            this.textBilko.TextChanged += new System.EventHandler(this.textBilko_TextChanged);
            // 
            // textTluszcz
            // 
            this.textTluszcz.Location = new System.Drawing.Point(197, 205);
            this.textTluszcz.Name = "textTluszcz";
            this.textTluszcz.Size = new System.Drawing.Size(94, 27);
            this.textTluszcz.TabIndex = 54;
            // 
            // textWegle
            // 
            this.textWegle.Location = new System.Drawing.Point(197, 255);
            this.textWegle.Name = "textWegle";
            this.textWegle.Size = new System.Drawing.Size(94, 27);
            this.textWegle.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(141, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Wpisz dane produktu:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textWegle);
            this.Controls.Add(this.textTluszcz);
            this.Controls.Add(this.textBilko);
            this.Controls.Add(this.textKalorie);
            this.Controls.Add(this.UsuńZdnia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajDoDnia);
            this.Controls.Add(this.textNazwa);
            this.Controls.Add(this.Pobierz);
            this.Controls.Add(this.ListaBazy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UsuńZdnia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajDoDnia;
        private System.Windows.Forms.TextBox textNazwa;
        private System.Windows.Forms.Button Pobierz;
        private System.Windows.Forms.ListBox ListaBazy;
        private System.Windows.Forms.TextBox textKalorie;
        private System.Windows.Forms.TextBox textBilko;
        private System.Windows.Forms.TextBox textTluszcz;
        private System.Windows.Forms.TextBox textWegle;
        private System.Windows.Forms.Label label6;
    }
}