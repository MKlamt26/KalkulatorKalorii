using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class AllDays
    {
        private List<Day> days;
        DateTime ydate = new DateTime();

        List<Day> listaDni = new List<Day>();
      
        

        //public void AddDay()
        //{
        //    var ocecnaData = DateTime.Now;
        //    days.Add(new Day(ocecnaData,);
        //    produkts.Add(new Produkt("Ziemniaki", 100, 10, 5, 20));
        //    produkts.Add(new Produkt("kurczak", 350, 20, 5, 5));
        //    produkts.Add(new Produkt("Ryż", 400, 10, 5, 70));

        //}

        public void SprawdzDate()
        {
            string datateraz = DateTime.Now.ToShortTimeString();
        }

        public void ZapiszDzien()
        {
            Day day = new Day();
            string zapiszDzien = JsonConvert.SerializeObject(days);

            day.Date = DateTime.Now;

            var ocecnaData = DateTime.Now;

            int obecnyDzien = ocecnaData.Day;
            int obecnyMiesiac = ocecnaData.Month;

            string dozapisu = "ZapisanyDzien" + obecnyDzien.ToString() + obecnyMiesiac.ToString() + ".json";


            string zapiszDate = JsonConvert.SerializeObject(day.Date);
            File.WriteAllText(dozapisu, zapiszDzien);



            //using (StreamReader r = new StreamReader(@"ZapisanyDzien.json"))
            //{
            //    string json = r.ReadToEnd();
            //    day.Date = JsonConvert.DeserializeObject<Day>(json);

            //}
        }

    }
}
