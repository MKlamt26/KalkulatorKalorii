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
    // 
    public partial class Form3 : Form
    {
        List<Produkt> produkts = new List<Produkt>();
        List<Produkt> zjedzone = new List<Produkt>();
        List<Day> days = new List<Day>();
        Day dzien = new Day();
        Urzytkownik urzytkownik = new Urzytkownik();
        public Form3()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }
        public override string ToString()
        {
            return string.Format("{0}", ProductName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           

            using (StreamReader r = new StreamReader(@"dni.json"))
            {
                string json = r.ReadToEnd();
                days = JsonConvert.DeserializeObject<List<Day>>(json);
                //produkts = JsonConvert.DeserializeObject<List<Produkt>>(json);
                //dzien = JsonConvert.DeserializeObject<List<<Produkt>>(json);
                //dzien = JsonConvert.DeserializeObject<List<Produkt>>(json);
                Zapotrzebowanie.Text = dzien.OdliczoneKalorie.ToString();

                //zjedzone = day.ListaZjedzonych;
                

            }
            

            foreach (var dzien in days)
            {
                ListaDni.Items.Add(dzien.Date.Day+"."+ dzien.Date.Month);

               

            }

            
            //Lista_Zjedzone.Items.Add(ListaDni.SelectedIndex.);



            foreach (var item in zjedzone)
            {
                Lista_Zjedzone.Items.Add(item);

            }








            //StringBuilder sb = new StringBuilder();
            //foreach (var item in listBox1.Items)
            //{

            //    sb.Append(item.ToString());
            //}
            //MessageBox.Show(sb.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string cos = textBox1.Text;
            //textBox1.Text.

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*extBox2 = textBox1.Text;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            //double cm = double.Parse(textBox1.Text);
            //double metry = cm / 100;
            //label1.Text = metry.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var co = produkts.Where(x => x.Nazwa.StartsWith("Z")
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista_Zjedzone.Items.Clear();

            double ileZjadl=0;
            //foreach (var dzien in days)
            //{
            //    Lista_Zjedzone.Items.Add(dzien.ListaZjedzonych.);
            //}
            int index = ListaDni.SelectedIndex;

            foreach (var produkt in days[index].ListaZjedzonych)
            {
                Lista_Zjedzone.Items.Add(produkt.Nazwa);
                ileZjadl += produkt.LiczbaKalorii;

            }

            IleZjedzone.Text = ileZjadl.ToString();

            using (StreamReader r = new StreamReader(@"Urzytkownik.json"))
            {
                string json = r.ReadToEnd();
                urzytkownik = JsonConvert.DeserializeObject<Urzytkownik>(json);
                Zapotrzebowanie.Text = urzytkownik.ZapotrzebowanieNaKcl.ToString();
               
            }


            //Zapotrzebowanie.Text = dzien..LiczbaKalorii;
            //Zapotrzebowanie.Text = dzien.ListaZjedzonych.N
            //BialkoZap.Text = dzien.ZapBial.ToString();

            //ZobaczDzien.Items.Add(ListaDni.SelectedItem);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            double ileZjadl = 0;
            double ileZjadlBialka = 0;
            double ileZjadlTluszczy = 0;
            double ileZjadlWegli = 0;

            double zapo = urzytkownik.ZapotrzebowanieNaKcl;
            double zapoNaBialko = urzytkownik.ZapBial;
            double zapoNaTluscz = urzytkownik.ZapTluszcz;
            double zapoNaWegle = urzytkownik.ZapWegle;
            Zapotrzebowanie.Text = zapo.ToString();


            zjedzone.Add((Produkt)ListaDni.SelectedItem);
            


            Lista_Zjedzone.Items.Add(ListaDni.SelectedItem);
            foreach (var item in zjedzone)
            {
                ileZjadl += item.LiczbaKalorii;
                ileZjadlBialka += item.Protein;
                ileZjadlTluszczy += item.Fat;
                ileZjadlWegli += item.Carbo;
            }

            double noweZapo = zapo - ileZjadl;
            double noweBialko = zapoNaBialko - ileZjadlBialka;
            double noweTluszcze = zapoNaTluscz - ileZjadlTluszczy;
            double noweWegle = zapoNaWegle - ileZjadlWegli;




           Zapotrzebowanie.Text = noweZapo.ToString();
            IleZjedzone.Text = noweBialko.ToString();
            //TluszczZap.Text = noweTluszcze.ToString();
            //WegleZap.Text = noweWegle.ToString();
            






            //foreach (var item in zjedzone)
            //{

            //    Lista_Zjedzone.Items.Add(item);
            //}

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ileZjadl = 0;
            double ileZjadlBialka = 0;
            double ileZjadlTluszczy = 0;
            double ileZjadlWegli = 0;

            double zapo = urzytkownik.ZapotrzebowanieNaKcl;
            double zapoNaBialko = urzytkownik.ZapBial;
            double zapoNaTluscz = urzytkownik.ZapTluszcz;
            double zapoNaWegle = urzytkownik.ZapWegle;

            
            Zapotrzebowanie.Text = zapo.ToString();
            zjedzone.Remove((Produkt)Lista_Zjedzone.SelectedItem);

            Lista_Zjedzone.Items.Remove(Lista_Zjedzone.SelectedItem);

            foreach (var item in zjedzone)
            {
                ileZjadl += item.LiczbaKalorii;
                ileZjadlBialka += item.Protein;
                ileZjadlTluszczy += item.Fat;
                ileZjadlWegli += item.Carbo;
            }

            double noweZapo = zapo - ileZjadl;
            double noweBialko = zapoNaBialko - ileZjadlBialka;
            double noweTluszcze = ileZjadlTluszczy - ileZjadlTluszczy;
            double noweWegle = zapoNaWegle - ileZjadlWegli;




            Zapotrzebowanie.Text = noweZapo.ToString();
            IleZjedzone.Text = noweBialko.ToString();
            //TluszczZap.Text = noweTluszcze.ToString();
            //WegleZap.Text = noweWegle.ToString();




            Zapotrzebowanie.Text = noweZapo.ToString();


        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Day obecnyDzien = new Day(DateTime.Now);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BMR_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = ListaDni.SelectedIndex;

            
        }
    }
}
