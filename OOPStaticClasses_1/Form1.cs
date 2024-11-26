using OOPStaticClasses_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPStaticClasses_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Matematik m = new Matematik();
            //m.KareAl(2);

            //Matematik m2 = new Matematik();
            //m2.KareAl(3);

            //MessageBox m = new MessageBox();
            //m.Show();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string a;
            //a = Matematik.KareAl(2);

            Kullanici k = new Kullanici();
            Kullanici k2 = new Kullanici();
            Kullanici k3 = new Kullanici();
            Kullanici k4 = new Kullanici();
            Kullanici k5 = new Kullanici();
            Kullanici k6= new Kullanici();

            MessageBox.Show(Kullanici.KullaniciSayisi.ToString());

            
        }
    }
}
