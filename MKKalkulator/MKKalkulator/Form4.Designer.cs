
namespace MKKalkulator
{
    partial class Form4
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
            this.NazwaProduktu = new System.Windows.Forms.ListBox();
            this.listKalorie = new System.Windows.Forms.ListBox();
            this.listBialko = new System.Windows.Forms.ListBox();
            this.listTłuszcz = new System.Windows.Forms.ListBox();
            this.Pobierz = new System.Windows.Forms.Button();
            this.listWęgle = new System.Windows.Forms.ListBox();
            this.Znajdź = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.ZjedzoneProdikty = new System.Windows.Forms.ListBox();
            this.DodajDoDnia = new System.Windows.Forms.Button();
            this.BiałkoZap = new System.Windows.Forms.TextBox();
            this.Zapotrzebowanie = new System.Windows.Forms.TextBox();
            this.TłuszczZap = new System.Windows.Forms.TextBox();
            this.WeglowodanyZap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UsuńZdnia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Przelicznik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NazwaProduktu
            // 
            this.NazwaProduktu.BackColor = System.Drawing.SystemColors.Menu;
            this.NazwaProduktu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NazwaProduktu.FormattingEnabled = true;
            this.NazwaProduktu.ItemHeight = 20;
            this.NazwaProduktu.Location = new System.Drawing.Point(12, 83);
            this.NazwaProduktu.Name = "NazwaProduktu";
            this.NazwaProduktu.Size = new System.Drawing.Size(113, 100);
            this.NazwaProduktu.TabIndex = 0;
            this.NazwaProduktu.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listKalorie
            // 
            this.listKalorie.BackColor = System.Drawing.SystemColors.Menu;
            this.listKalorie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listKalorie.FormattingEnabled = true;
            this.listKalorie.ItemHeight = 20;
            this.listKalorie.Location = new System.Drawing.Point(142, 83);
            this.listKalorie.Name = "listKalorie";
            this.listKalorie.Size = new System.Drawing.Size(73, 104);
            this.listKalorie.TabIndex = 1;
            this.listKalorie.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBialko
            // 
            this.listBialko.BackColor = System.Drawing.SystemColors.Menu;
            this.listBialko.FormattingEnabled = true;
            this.listBialko.ItemHeight = 20;
            this.listBialko.Location = new System.Drawing.Point(231, 83);
            this.listBialko.Name = "listBialko";
            this.listBialko.Size = new System.Drawing.Size(68, 104);
            this.listBialko.TabIndex = 2;
            this.listBialko.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listTłuszcz
            // 
            this.listTłuszcz.BackColor = System.Drawing.SystemColors.Menu;
            this.listTłuszcz.FormattingEnabled = true;
            this.listTłuszcz.ItemHeight = 20;
            this.listTłuszcz.Location = new System.Drawing.Point(326, 83);
            this.listTłuszcz.Name = "listTłuszcz";
            this.listTłuszcz.Size = new System.Drawing.Size(68, 104);
            this.listTłuszcz.TabIndex = 3;
            this.listTłuszcz.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Pobierz
            // 
            this.Pobierz.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Pobierz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Pobierz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pobierz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pobierz.Location = new System.Drawing.Point(231, 12);
            this.Pobierz.Name = "Pobierz";
            this.Pobierz.Size = new System.Drawing.Size(94, 29);
            this.Pobierz.TabIndex = 4;
            this.Pobierz.Text = "Pobierz";
            this.Pobierz.UseVisualStyleBackColor = true;
            this.Pobierz.Click += new System.EventHandler(this.button1_Click);
            // 
            // listWęgle
            // 
            this.listWęgle.BackColor = System.Drawing.SystemColors.Menu;
            this.listWęgle.FormattingEnabled = true;
            this.listWęgle.ItemHeight = 20;
            this.listWęgle.Location = new System.Drawing.Point(416, 83);
            this.listWęgle.Name = "listWęgle";
            this.listWęgle.Size = new System.Drawing.Size(68, 104);
            this.listWęgle.TabIndex = 5;
            this.listWęgle.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // Znajdź
            // 
            this.Znajdź.FlatAppearance.BorderSize = 0;
            this.Znajdź.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Znajdź.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Znajdź.Location = new System.Drawing.Point(12, 193);
            this.Znajdź.Name = "Znajdź";
            this.Znajdź.Size = new System.Drawing.Size(94, 29);
            this.Znajdź.TabIndex = 6;
            this.Znajdź.Text = "Znajdź";
            this.Znajdź.UseVisualStyleBackColor = true;
            this.Znajdź.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 228);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 27);
            this.search.TabIndex = 7;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ZjedzoneProdikty
            // 
            this.ZjedzoneProdikty.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ZjedzoneProdikty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZjedzoneProdikty.FormattingEnabled = true;
            this.ZjedzoneProdikty.ItemHeight = 20;
            this.ZjedzoneProdikty.Location = new System.Drawing.Point(244, 228);
            this.ZjedzoneProdikty.Name = "ZjedzoneProdikty";
            this.ZjedzoneProdikty.Size = new System.Drawing.Size(127, 104);
            this.ZjedzoneProdikty.TabIndex = 8;
            // 
            // DodajDoDnia
            // 
            this.DodajDoDnia.Location = new System.Drawing.Point(112, 193);
            this.DodajDoDnia.Name = "DodajDoDnia";
            this.DodajDoDnia.Size = new System.Drawing.Size(125, 29);
            this.DodajDoDnia.TabIndex = 9;
            this.DodajDoDnia.Text = "Dodaj Do Dnia";
            this.DodajDoDnia.UseVisualStyleBackColor = true;
            this.DodajDoDnia.Click += new System.EventHandler(this.button3_Click);
            // 
            // BiałkoZap
            // 
            this.BiałkoZap.Location = new System.Drawing.Point(142, 395);
            this.BiałkoZap.Name = "BiałkoZap";
            this.BiałkoZap.Size = new System.Drawing.Size(77, 27);
            this.BiałkoZap.TabIndex = 10;
            // 
            // Zapotrzebowanie
            // 
            this.Zapotrzebowanie.Location = new System.Drawing.Point(12, 395);
            this.Zapotrzebowanie.Name = "Zapotrzebowanie";
            this.Zapotrzebowanie.Size = new System.Drawing.Size(81, 27);
            this.Zapotrzebowanie.TabIndex = 11;
            this.Zapotrzebowanie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TłuszczZap
            // 
            this.TłuszczZap.Location = new System.Drawing.Point(256, 395);
            this.TłuszczZap.Name = "TłuszczZap";
            this.TłuszczZap.Size = new System.Drawing.Size(75, 27);
            this.TłuszczZap.TabIndex = 12;
            // 
            // WeglowodanyZap
            // 
            this.WeglowodanyZap.Location = new System.Drawing.Point(363, 395);
            this.WeglowodanyZap.Name = "WeglowodanyZap";
            this.WeglowodanyZap.Size = new System.Drawing.Size(91, 27);
            this.WeglowodanyZap.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "NazwaProduktu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(131, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kalorie/100g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(220, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Białko/100g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(315, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tłuszcz/100g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(416, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Węglowodany/100g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(244, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zjedzone Produkty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Twoje Zap[kcl]:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(150, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Białko[g]";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(256, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tłuszcz[g]";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(354, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Węglowodany[g]";
            // 
            // UsuńZdnia
            // 
            this.UsuńZdnia.Location = new System.Drawing.Point(112, 228);
            this.UsuńZdnia.Name = "UsuńZdnia";
            this.UsuńZdnia.Size = new System.Drawing.Size(125, 29);
            this.UsuńZdnia.TabIndex = 24;
            this.UsuńZdnia.Text = "Usuń Z dnia";
            this.UsuńZdnia.UseVisualStyleBackColor = true;
            this.UsuńZdnia.Click += new System.EventHandler(this.UsuńZdnia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(391, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Zapisz dzień";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(12, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Podaj Ile zjadłeś[g]:";
            // 
            // Przelicznik
            // 
            this.Przelicznik.Location = new System.Drawing.Point(156, 295);
            this.Przelicznik.Name = "Przelicznik";
            this.Przelicznik.Size = new System.Drawing.Size(63, 27);
            this.Przelicznik.TabIndex = 27;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.Przelicznik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsuńZdnia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeglowodanyZap);
            this.Controls.Add(this.TłuszczZap);
            this.Controls.Add(this.Zapotrzebowanie);
            this.Controls.Add(this.BiałkoZap);
            this.Controls.Add(this.DodajDoDnia);
            this.Controls.Add(this.ZjedzoneProdikty);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Znajdź);
            this.Controls.Add(this.listWęgle);
            this.Controls.Add(this.Pobierz);
            this.Controls.Add(this.listTłuszcz);
            this.Controls.Add(this.listBialko);
            this.Controls.Add(this.listKalorie);
            this.Controls.Add(this.NazwaProduktu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NazwaProduktu;
        private System.Windows.Forms.ListBox listKalorie;
        private System.Windows.Forms.ListBox listBialko;
        private System.Windows.Forms.ListBox listTłuszcz;
        private System.Windows.Forms.Button Pobierz;
        private System.Windows.Forms.ListBox listWęgle;
        private System.Windows.Forms.Button Znajdź;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ListBox ZjedzoneProdikty;
        private System.Windows.Forms.Button DodajDoDnia;
        private System.Windows.Forms.TextBox BiałkoZap;
        private System.Windows.Forms.TextBox Zapotrzebowanie;
        private System.Windows.Forms.TextBox TłuszczZap;
        private System.Windows.Forms.TextBox WeglowodanyZap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UsuńZdnia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Przelicznik;
    }
}