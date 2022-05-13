using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Day = ConsoleApp2.Day;

namespace MKKalkulator
{
    public partial class Form4 : Form
    {
        List<Produkt> produkts1 = new List<Produkt>();
        List<Produkt> zjedzone = new List<Produkt>();
        Urzytkownik urzytkownik = new Urzytkownik();
        List<Day> ListaDni = new List<Day>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NazwaProduktu.Items.Clear();
            listKalorie.Items.Clear();
            listBialko.Items.Clear();
            listTłuszcz.Items.Clear();
            listWęgle.Items.Clear();

            ProduktService ps = new ProduktService();
            produkts1 = ps.WczytajProdukty();

            /*rodukts.Add(new Produkt("cos", 120));*/
            //listBox1.Items.Add(produkts);
            foreach (var item in produkts1)
            {
                NazwaProduktu.Items.Add(item.Nazwa);
                listKalorie.Items.Add(item.LiczbaKalorii);
                listBialko.Items.Add(item.Protein);
                listTłuszcz.Items.Add(item.Fat);
                listWęgle.Items.Add(item.Carbo);

                


            }

            using (StreamReader r = new StreamReader(@"Urzytkownik.json"))
            {
                string json = r.ReadToEnd();
                urzytkownik = JsonConvert.DeserializeObject<Urzytkownik>(json);
                Zapotrzebowanie.Text = urzytkownik.ZapotrzebowanieNaKcl.ToString();
                BiałkoZap.Text = urzytkownik.ZapBial.ToString();
                TłuszczZap.Text = urzytkownik.ZapTluszcz.ToString();
                WeglowodanyZap.Text = urzytkownik.ZapWegle.ToString();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curIndex = NazwaProduktu.SelectedIndex;
            listKalorie.SelectedIndex = curIndex;
            listBialko.SelectedIndex = curIndex;
            listTłuszcz.SelectedIndex = curIndex;
            listWęgle.SelectedIndex = curIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = NazwaProduktu.SelectedIndex;
            listKalorie.SelectedIndex = curItem;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Produkt> produkts = new List<Produkt>();
            ProduktService ps = new ProduktService();
            produkts = ps.WczytajProdukty();
            int a = produkts.FindIndex(x => x.Nazwa.StartsWith(search.Text));
            NazwaProduktu.SelectedIndex = a;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = NazwaProduktu.SelectedIndex;
            listBialko.SelectedIndex = curItem;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = NazwaProduktu.SelectedIndex;
            listTłuszcz.SelectedIndex = curItem;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = NazwaProduktu.SelectedIndex;
            listWęgle.SelectedIndex = curItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZjedzoneProdikty.Items.Add(NazwaProduktu.SelectedItem);

            zjedzone.Add(new Produkt(NazwaProduktu.SelectedItem.ToString(),
                double.Parse(listKalorie.SelectedItem.ToString()), double.Parse(listBialko.SelectedItem.ToString()),
                double.Parse(listTłuszcz.SelectedItem.ToString()), double.Parse(listWęgle.SelectedItem.ToString())));

            //Produkt p1 = new Produkt(NazwaProduktu.SelectedItem.ToString(),
            //    double.Parse(listKalorie.SelectedItem.ToString()), double.Parse(listBialko.SelectedItem.ToString()),
            //    double.Parse(listTłuszcz.SelectedItem.ToString()), double.Parse(listWęgle.SelectedItem.ToString()));

            double KalorieNowe;
            double KalorieZapo = double.Parse(Zapotrzebowanie.Text);
            double KalorieZjedzone = double.Parse(listKalorie.Text);

            double przelicznikKalorie = double.Parse(Przelicznik.Text);
            KalorieNowe = KalorieZapo - KalorieZjedzone * (przelicznikKalorie / 100);

            Zapotrzebowanie.Text = KalorieNowe.ToString();

            double BialkoNowe;
            double BialkoZapo = double.Parse(BiałkoZap.Text);
            double BialkoZjedzone = double.Parse(listBialko.Text);

            double przelicznikTBialko = double.Parse(Przelicznik.Text);
            BialkoNowe = BialkoZapo - BialkoZjedzone * (przelicznikTBialko / 100);

            BiałkoZap.Text = BialkoNowe.ToString();

            double TluszczNowe;
            double TluszczZapo = double.Parse(TłuszczZap.Text);
            double TluszczZjedzone = double.Parse(listTłuszcz.Text);
            double przelicznikTuszcz = double.Parse(Przelicznik.Text);

            TluszczNowe = TluszczZapo - TluszczZjedzone * (przelicznikTuszcz / 100);

            
            TłuszczZap.Text = TluszczNowe.ToString();

            double WegleNowe;
            double WegleZapo = double.Parse(WeglowodanyZap.Text);
            double WelgleZjedzone = double.Parse(listWęgle.Text);
            double przelicznikWegle= double.Parse(Przelicznik.Text);
            
            WegleNowe = WegleZapo - WelgleZjedzone * (przelicznikWegle / 100);
            WeglowodanyZap.Text = WegleNowe.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuńZdnia_Click(object sender, EventArgs e)
        {
            

            double NoweKcl;
            double NoweBialko;
            double NoweTłuszcz;
            double NoweWegle;

            double NaJoweKcl;
            double NaJoweBialko;
            double NaJoweTłuszcz;
            double NaJoweWegle;

            using (StreamReader r = new StreamReader(@"Urzytkownik.json"))
            {
                string json = r.ReadToEnd();
                urzytkownik = JsonConvert.DeserializeObject<Urzytkownik>(json);
                NoweKcl = double.Parse(urzytkownik.ZapotrzebowanieNaKcl.ToString());
                NoweBialko = double.Parse(urzytkownik.ZapBial.ToString());
                NoweTłuszcz = double.Parse(urzytkownik.ZapTluszcz.ToString());
                NoweWegle = double.Parse(urzytkownik.ZapWegle.ToString());

                Zapotrzebowanie.Text = NoweKcl.ToString();
                BiałkoZap.Text = NoweBialko.ToString();
                TłuszczZap.Text = NoweTłuszcz.ToString();
                WeglowodanyZap.Text = NoweWegle.ToString();



            }
            var curIndex = ZjedzoneProdikty.SelectedIndex;
            ZjedzoneProdikty.Items.Remove(ZjedzoneProdikty.SelectedItem);
            zjedzone.Remove(zjedzone[curIndex]);
            
            foreach (var produkt in zjedzone)
            {
                NaJoweKcl = NoweKcl - produkt.LiczbaKalorii;
                NaJoweBialko = NoweBialko - produkt.Protein;
                NaJoweTłuszcz = NoweTłuszcz - produkt.Fat;
                NaJoweWegle = NoweWegle - produkt.Carbo;

                Zapotrzebowanie.Text = NaJoweKcl.ToString();
                BiałkoZap.Text = NaJoweBialko.ToString();
                TłuszczZap.Text = NaJoweTłuszcz.ToString();
                WeglowodanyZap.Text = NaJoweWegle.ToString();

            }
            








        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            using (StreamReader r = new StreamReader(@"dni.json"))
            {
                string json = r.ReadToEnd();

                ListaDni = JsonConvert.DeserializeObject<List<Day>>(json);

                //foreach (var dzien in ListaDni)
                //{
                //    Day day1 = JsonConvert.DeserializeObject<Day>(json);
                //    ListaDni.Add(day1);
                //}


            }

            List<Produkt> listaZjedzonych = new List<Produkt>();


            Day dzien = new Day();
            

            foreach (Produkt Zjedzonyprodukt in zjedzone)
            {
                listaZjedzonych.Add(Zjedzonyprodukt);
            }
            ListaDni.Add(dzien = new Day(listaZjedzonych));

            dzien.Date = DateTime.Now;

            string zapiszDzien = JsonConvert.SerializeObject(ListaDni);

            

           

            var ocecnaData = DateTime.Now;

            int obecnyDzien = ocecnaData.Day;
            int obecnyMiesiac = ocecnaData.Month;

            string dozapisu2 = "dni.json";


            File.WriteAllText(dozapisu2, zapiszDzien);


            //foreach (var dzien in ListaDni)
            //{
            //    dzien.ZapiszDzien(dzien);
            //}

            //day.ZapiszDzien(ListaDni);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
