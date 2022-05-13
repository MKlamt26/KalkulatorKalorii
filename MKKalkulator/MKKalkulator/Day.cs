using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Day
    {
        List<Produkt> listaZjedzonych = new List<Produkt>();
        List<Day> listaDni= new List<Day>();

        public List<Produkt> ListaZjedzonych
        {
            get { return listaZjedzonych; }
            set { listaZjedzonych = value; }
        }
        private double zapKal;

        public double ZapKal
        {
            get { return zapKal; }
            set { zapKal = value; }
        }

        private double zapBial;

        public double ZapBial
        {
            get { return zapBial; }
            set { zapBial = value; }
        }

        private double zapTluszcz;

        public double ZapTluszcz
        {
            get { return zapTluszcz; }
            set { zapTluszcz = value; }
        }


        private double zapWegle;

        public double ZapWegle
        {
            get { return zapWegle; }
            set { zapWegle = value; }
        }

        

       


        private double odliczoneKalorie;

        public double OdliczoneKalorie
        {
            get { return odliczoneKalorie; }
            set { odliczoneKalorie = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        //public Day(DateTime Date, List<Produkt> listaZjedzonych)
        //{
        //    this.Date = Date;
        //    this.ListaZjedzonych = listaZjedzonych;
        //}
        public Day(List<Produkt> listaZjedzonych)
        {
            this.listaZjedzonych = listaZjedzonych;
        }
        public Day()
        {

        }

        public void ZapiszDzien(List<Day> listaDni)
        {
            
            string zapiszDzien = JsonConvert.SerializeObject(listaZjedzonych);

           

            foreach (var dzien in listaDni)
            {
                dzien.Date = DateTime.Now;
            }

            

            var ocecnaData = DateTime.Now;

            int obecnyDzien = ocecnaData.Day;
            int obecnyMiesiac = ocecnaData.Month;

            string dozapisu = "ZapisanyDzien" + obecnyDzien.ToString() + obecnyMiesiac.ToString() + ".json";

            string dozapisu2 = "dni.json";
            string zapiszDate= JsonConvert.SerializeObject(listaDni);
            
            
            File.WriteAllText(dozapisu2, zapiszDate);



            //using (StreamReader r = new StreamReader(@"ZapisanyDzien.json"))
            //{
            //    string json = r.ReadToEnd();
            //    day.Date = JsonConvert.DeserializeObject<Day>(json);
               
            //}
        }
       


    }
}
