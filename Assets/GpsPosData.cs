using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    class GpsPosData
    {
        private DateTime gpst;
        private double latitude;
        private double longitude;
        private double height;
        private int quality;
        private int ns;
        private double sdn;
        private double sde;
        private double sdu;
        private double sdne;
        private double sdeu;
        private double sdun;
        private double age;
        private double ratio;

        public DateTime GPST
        {
            //set { this.gpst = value; }
            get { return this.gpst; }
        }
        public double Latitude
        {
            //set { this.latitude = value; }
            get { return this.latitude; }
        }
        public double Longitude
        {
            //set { this.longitude = value; }
            get { return this.longitude; }
        }
        public double Height
        {
            //set { this.height = value; }
            get { return this.height; }
        }
        public int Quality
        {
            //set { this.quality = value; }
            get { return this.quality; }
        }
        public int NS
        {
            //set { this.ns = value; }
            get { return this.ns; }
        }
        public double Sdn
        {
            //set { this.sdn = value; }
            get { return this.sdn; }
        }
        public double Sde
        {
            //set { this.sde = value; }
            get { return this.sde; }
        }
        public double Sdu
        {
            //set { this.sdu = value; }
            get { return this.sdu; }
        }
        public double Sdne
        {
            //set { this.sdne = value; }
            get { return this.sdne; }
        }
        public double Sdeu
        {
            //set { this.sdeu = value; }
            get { return this.sdeu; }
        }
        public double Sdun
        {
            //set { this.sdun = value; }
            get { return this.sdun; }
        }
        public double Age
        {
            //set { this.age = value; }
            get { return this.age; }
        }
        public double Ratio
        {
            //set { this.ratio = value; }
            get { return this.ratio; }
        }

        public GpsPosData(string text)
        {
            //%  GPST                  latitude(deg) longitude(deg)  height(m)   Q  ns   sdn(m)   sde(m)   sdu(m)  sdne(m)  sdeu(m)  sdun(m) age(s)  ratio
            // 2018/05/16 03:29:42.000   35.673271553  139.481054753   116.4973   5   3  28.1765   7.4881   7.8548  14.3975  -7.4266 -14.1790   1.00    0.0
            Regex rSplit = new Regex("\\s+");
            string[] t = rSplit.Split(text);
            try
            {
                gpst = DateTime.ParseExact(t[0] + " " + t[1], "yyyy/MM/dd HH:mm:ss.fff", null);
                latitude = double.Parse(t[2]);
                longitude = double.Parse(t[3]);
                height = double.Parse(t[4]);
                quality = int.Parse(t[5]);
                ns = int.Parse(t[6]);
                sdn = double.Parse(t[7]);
                sde = double.Parse(t[8]);
                sdu = double.Parse(t[9]);
                sdne = double.Parse(t[10]);
                sdeu = double.Parse(t[11]);
                sdun = double.Parse(t[12]);
                age = double.Parse(t[13]);
                ratio = double.Parse(t[14]);
            }
            catch (FormatException)
            {
                // デフォルト値を設定する
                gpst = DateTime.MinValue;
                latitude = 0.0;
                longitude = 0.0;
                height = 0.0;
                quality = 0;
                ns = 0;
                sdn = 0.0;
                sde = 0.0;
                sdu = 0.0;
                sdne = 0.0;
                sdeu = 0.0;
                sdun = 0.0;
                age = 0.0;
                ratio = 0.0;
            }

        }
    }
}
