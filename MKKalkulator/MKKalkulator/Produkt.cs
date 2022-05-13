using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Produkt
    {
        readonly private string sciezkaDoPliku;
        private string nazwa;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }
        private double liczbakalorii;



        public double LiczbaKalorii
        {
            get { return liczbakalorii; }
            set { liczbakalorii = value; }
        }
        private double protein;

        public double Protein
        {
            get { return protein; }
            set { protein = value; }
        }

        private double fat;

        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        private double carbo;

        public double Carbo
        {
            get { return carbo; }
            set { carbo = value; }
        }
        public Produkt(string Nazwa,double LiczbaKlaorii,double Protein,double Fat,double Carbo)
        {
            this.Nazwa = Nazwa;
            this.LiczbaKalorii = LiczbaKlaorii;
            this.Protein = Protein;
            this.Fat = Fat;
            this.Carbo = Carbo;
        }
        public Produkt()
        {

        }
        public Produkt(string Nazwa,double liczbaKalorii)
        {
            this.Nazwa = Nazwa;
            this.LiczbaKalorii = liczbaKalorii;

        }
        public override string ToString()
        {
            //return String.Format($"Produkt: + {Nazwa}  Liczba Kalorii: {liczbakalorii} Biłko + {Protein} Tłuszcz: {Fat} Węglowodany: {Carbo}");
            return "Produkt: " + Nazwa + "  Liczba Kalorii: " + liczbakalorii + " Biłko " + Protein + " Tłuszcz: " + Fat + " Węglowodany: " + Carbo;
        }






    }
}
