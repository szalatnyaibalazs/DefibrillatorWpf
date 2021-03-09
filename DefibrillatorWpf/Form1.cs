using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DefibrillatorWpf
{
    public partial class frmFo : Form
    {
        public frmFo()
        {
            InitializeComponent();
            Beolvasas();
        }
        static List<Keszulek> keszulekek = new List<Keszulek>(); 
        static void Beolvasas()
        {
            StreamReader be = new StreamReader("data.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                keszulekek.Add(new Keszulek(int.Parse(a[0]),a[1],double.Parse(a[2]),double.Parse(a[3]),a[4],a[5]));
            }
        }
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
