using ConsoleApp2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

            string gender, exercise;
            double height, weight, age, malebmr, femalebmr; //variables
            double ZapBial, ZapTluscz, ZapWegle;
            decimal bmrmult;

            // get personal information
            height = double.Parse(textBox2.Text);
            weight = double.Parse(textBox1.Text);
            age = double.Parse(textBox3.Text);

            string zapiszDane = JsonConvert.SerializeObject(height + weight + age);

            File.WriteAllText(@"DANE.json", zapiszDane);
            // select gender
            if (checkBox1.Checked)
            {


                // perform calculation
                //PPM = 66,47 + 13,75 x waga w kg + 5 x wzrost w cm – 6,75 x wiek

                //malebmr = weight * 10 + height * 6.25 - age * 5 - 5;
                malebmr = (13.75 * weight + height * 5 - age * 6.75 + 66.47)*1.6;
                        textBox4.Text = (" " + malebmr + " Kcal");
                ZapBial = (0.2 * malebmr) / 4;
                ZapTluscz = (0.25 * malebmr) / 9;
                ZapWegle = (0.55 * malebmr) / 4;

                malebmr = Math.Round(malebmr, 2);
                ZapBial = Math.Round(ZapBial, 2);
                ZapTluscz = Math.Round(ZapTluscz, 2);
                ZapWegle = Math.Round(ZapWegle, 2);



                //string zapiszBMR = JsonConvert.SerializeObject(malebmr);

                Urzytkownik urzytkownik1 = new Urzytkownik(malebmr, ZapBial, ZapTluscz, ZapWegle);
                urzytkownik1.ZapotrzebowanieNaKcl.ToString();
                string zapiszurzytkownika = JsonConvert.SerializeObject(urzytkownik1);
                File.WriteAllText(@"Urzytkownik.json", zapiszurzytkownika);

                //File.WriteAllText(@"BMR.json", zapiszBMR);   



            }
            if (checkBox2.Checked)
            {
                //femalebmr = weight * 10 + height * 6.25 - age * 5 - 161;
                //  665,09 + 9,56 x waga w kg + 1,85 x wzrost w cm – 4,67 x wiek
                femalebmr = (9.56 * weight + 1.85 * height - 4.67 * age + 665.89)*1.6;
                textBox4.Text = ("" + femalebmr + "Kcal");
                ZapBial = (0.2 * femalebmr) / 4;
                ZapTluscz = (0.25 * femalebmr) / 9;
                ZapWegle = (0.55 * femalebmr) / 4;

                malebmr = Math.Round(femalebmr, 2);
                ZapBial = Math.Round(ZapBial, 2);
                ZapTluscz = Math.Round(ZapTluscz, 2);
                ZapWegle = Math.Round(ZapWegle, 2);

                string zapiszBMR = JsonConvert.SerializeObject(femalebmr);
                Urzytkownik urzytkownik1 = new Urzytkownik(femalebmr, ZapBial, ZapTluscz, ZapWegle);
                string zapiszurzytkownika = JsonConvert.SerializeObject(urzytkownik1);
                File.WriteAllText(@"Urzytkownik.json", zapiszurzytkownika);

                File.WriteAllText(@"BMR.json", zapiszBMR);

            }

            //string zapszWage = JsonConvert.SerializeObject(textBox1.Text);
            //string zapiszWzrost = JsonConvert.SerializeObject(textBox2.Text);
            //string zapiszWiek = JsonConvert.SerializeObject(textBox3.Text);

            //File.WriteAllText(@"Dane.json", zapszWage+ zapiszWzrost+ zapiszWiek);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
