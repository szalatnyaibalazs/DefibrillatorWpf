using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DefibrillatorWpf
{
    class Keszulek
    {
        private int id;
        int Id { get { return id; } }
        private string name;
        string Name { get { return name; } }
        private double latitude;
        double Latitude { get { return latitude; } }
        private double longitude;
        double Longitude { get { return longitude; } }
        private string tel;
        string Tel{ get { return tel; } }
        private string address;
        string Address { get { return address; } }
        private double dist;
        double Dist { get { return dist; } }


        public Keszulek(int id,string name,double latitude,double longitude, string tel,string address)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.tel = tel;
            this.address = address;
        }
        static void DistCalc(double x, double y)
        {
            double dis = Math.Sqrt((x*x)+(y*y))*6371;
        }
    }
}
