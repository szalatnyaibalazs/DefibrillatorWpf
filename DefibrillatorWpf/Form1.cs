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
                keszulekek.Add(new Keszulek(int.Parse(a[0]), a[1], double.Parse(a[2].Replace(".", ",")), double.Parse(a[3].Replace(".",",")), a[4], a[5]));
            }
        }
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static bool VanAdat(string x, string y)
        {
            if (x !=""&&y!="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAdatlekeres_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var k in keszulekek)
                {
                double xcord = (k.Longitude - double.Parse(tbYkoord.Text)) * Math.Cos(k.Latitude + double.Parse(tbXkoord.Text) / 2);
                double ycord = k.Latitude - double.Parse(tbXkoord.Text);
                lbAdatok.Items.Add($"{xcord} - {ycord}");
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                tbXkoord.Text = "";
                tbYkoord.Text = "";
            }
        }

        private void btnUjadatok_Click(object sender, EventArgs e)
        {
            tbXkoord.Text = "";
            tbYkoord.Text = "";
            lbAdatok.Items.Clear();
        }
    }
}
