using System;
using System.Collections.Generic;
using System.Text;

namespace MKKalkulator
{
    class Urzytkownik
    {
        private double zapotrzebowanieNaKcl;

        public double ZapotrzebowanieNaKcl
        {
            get { return zapotrzebowanieNaKcl; }
            set { zapotrzebowanieNaKcl = value; }
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

        public Urzytkownik(double ZapotrzebowanieNaKcl)
        {
            this.ZapotrzebowanieNaKcl = ZapotrzebowanieNaKcl;
        }
        public Urzytkownik(double ZapotrzebowanieNaKcl,double ZapBial, double ZapTluszcz, double ZapWegle)
        {
            this.ZapBial = ZapBial;
            this.ZapotrzebowanieNaKcl = ZapotrzebowanieNaKcl;
            this.ZapTluszcz = ZapTluszcz;
            this.ZapWegle = ZapWegle;
        }

        public Urzytkownik()
        {

        }
    }
}
