
namespace MKKalkulator
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ZobaczDzien = new System.Windows.Forms.Button();
            this.Lista_Zjedzone = new System.Windows.Forms.ListBox();
            this.ListaDni = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IleZjedzone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Zapotrzebowanie = new System.Windows.Forms.TextBox();
            this.BMR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pobierz Dni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ZobaczDzien
            // 
            this.ZobaczDzien.ForeColor = System.Drawing.Color.Black;
            this.ZobaczDzien.Location = new System.Drawing.Point(12, 109);
            this.ZobaczDzien.Name = "ZobaczDzien";
            this.ZobaczDzien.Size = new System.Drawing.Size(130, 41);
            this.ZobaczDzien.TabIndex = 3;
            this.ZobaczDzien.Text = "Zobacz Dzień";
            this.ZobaczDzien.UseVisualStyleBackColor = true;
            this.ZobaczDzien.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lista_Zjedzone
            // 
            this.Lista_Zjedzone.FormattingEnabled = true;
            this.Lista_Zjedzone.ItemHeight = 20;
            this.Lista_Zjedzone.Location = new System.Drawing.Point(359, 46);
            this.Lista_Zjedzone.Name = "Lista_Zjedzone";
            this.Lista_Zjedzone.Size = new System.Drawing.Size(166, 104);
            this.Lista_Zjedzone.TabIndex = 5;
            this.Lista_Zjedzone.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ListaDni
            // 
            this.ListaDni.FormattingEnabled = true;
            this.ListaDni.ItemHeight = 20;
            this.ListaDni.Location = new System.Drawing.Point(165, 46);
            this.ListaDni.Name = "ListaDni";
            this.ListaDni.Size = new System.Drawing.Size(166, 104);
            this.ListaDni.TabIndex = 0;
            this.ListaDni.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "IleWęglowodanów";
            // 
            // IleZjedzone
            // 
            this.IleZjedzone.Location = new System.Drawing.Point(47, 288);
            this.IleZjedzone.Name = "IleZjedzone";
            this.IleZjedzone.ReadOnly = true;
            this.IleZjedzone.Size = new System.Drawing.Size(125, 27);
            this.IleZjedzone.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(226, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jakie Było zapotrzebowanie:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Zapotrzebowanie
            // 
            this.Zapotrzebowanie.Location = new System.Drawing.Point(226, 288);
            this.Zapotrzebowanie.Name = "Zapotrzebowanie";
            this.Zapotrzebowanie.ReadOnly = true;
            this.Zapotrzebowanie.Size = new System.Drawing.Size(146, 27);
            this.Zapotrzebowanie.TabIndex = 7;
            this.Zapotrzebowanie.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // BMR
            // 
            this.BMR.AutoSize = true;
            this.BMR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMR.Location = new System.Drawing.Point(47, 245);
            this.BMR.Name = "BMR";
            this.BMR.Size = new System.Drawing.Size(115, 20);
            this.BMR.TabIndex = 8;
            this.BMR.Text = "Ile Klc Zjedzone";
            this.BMR.Click += new System.EventHandler(this.BMR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(165, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "listaDni:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(359, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zjedzone Produkty:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IleZjedzone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BMR);
            this.Controls.Add(this.Zapotrzebowanie);
            this.Controls.Add(this.Lista_Zjedzone);
            this.Controls.Add(this.ZobaczDzien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaDni);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Podsumowanie";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ZobaczDzien;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox Lista_Zjedzone;
        private System.Windows.Forms.ListBox ListaDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IleZjedzone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Zapotrzebowanie;
        private System.Windows.Forms.Label BMR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}