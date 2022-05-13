using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MKKalkulator
{
    public partial class Form6 : Form
    {

        List<Produkt> produkts = new List<Produkt>();
        ProduktService pr1 = new ProduktService();
        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DodajDoDnia_Click(object sender, EventArgs e)
        {
            ListaBazy.Items.Clear();


            string Nazwa;
            double LiczbaKlaorii;
            double Protein;
            double Fat;
            double Carbo;

            Nazwa = textNazwa.Text;
            LiczbaKlaorii = double.Parse(textKalorie.Text);
            Protein = double.Parse(textBilko.Text);
            
            Fat = double.Parse(textTluszcz.Text);
            Carbo = double.Parse(textWegle.Text);

           
            produkts= pr1.WczytajProdukty();

            produkts.Add(new Produkt( Nazwa, LiczbaKlaorii, Protein, Fat, Carbo));

            
            pr1.ZapiszProdukty(produkts);
            produkts = pr1.WczytajProdukty();

            foreach (var produkt in produkts)
            {
                ListaBazy.Items.Add(produkt.Nazwa);
            }
        }

        private void UsuńZdnia_Click(object sender, EventArgs e)
        {
            produkts = pr1.WczytajProdukty();

            var curIndex = ListaBazy.SelectedIndex;
            ListaBazy.Items.Remove(ListaBazy.SelectedItem);
            produkts.Remove(produkts[curIndex]);

            pr1.ZapiszProdukty(produkts);


        }

        private void Pobierz_Click(object sender, EventArgs e)
        {
            ListaBazy.Items.Clear();

            produkts = pr1.WczytajProdukty();

            foreach (var produkt in produkts)
            {
                ListaBazy.Items.Add(produkt.Nazwa);
            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBilko_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
