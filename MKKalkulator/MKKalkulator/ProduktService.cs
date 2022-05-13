using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class ProduktService
    {
        List<Produkt> produkts = new List<Produkt>();
        List<Produkt> wczytane = new List<Produkt>();
        string zapo = "asdasd";

        public void AddProduct()
        {
            //Console.WriteLine("1.Dodaj Produkt do Listy");
            //Console.WriteLine("Wpisz nazwę produktu: ");
            //string nazwa = Console.ReadLine();
            produkts.Add(new Produkt("Ziemniaki", 100, 10, 5, 20));
            produkts.Add(new Produkt("kurczak", 350, 20, 5, 5));
            produkts.Add(new Produkt("Ryż", 400, 10, 5, 70));

        }
        public void ZapiszProdukty(List<Produkt> produkts)
        {
            string produktZapisz = JsonConvert.SerializeObject(produkts);
            File.WriteAllText(@"plik.json", produktZapisz);
        }
        public string PobierzZapotrzebowanie()
        {
           
            
            
               
            zapo= File.ReadAllText(@"BMR.json");

            return zapo;

        }
            

        
        public List<Produkt> WczytajProdukty()
        {
            using (StreamReader r = new StreamReader(@"plik.json"))
            {
                string json = r.ReadToEnd();
                produkts = JsonConvert.DeserializeObject<List<Produkt>>(json);
            }
            return produkts;
        }
        public void WyswietlListeProduktow()
        {
            foreach (Produkt produkt in produkts)
            {
                Console.WriteLine(produkt);

            }

        }




    }
}
