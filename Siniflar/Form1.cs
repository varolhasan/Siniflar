using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb1 = new Araba();
            rb1.renk = "Kırmızı";
            rb1.hiz = 160;
            rb1.durum = 's';
            rb1.motor = 1245.56;
            rb1.fiyat = 70000;

            label1.Text = rb1.renk;
            label2.Text = rb1.hiz.ToString();
            label3.Text = rb1.durum.ToString();
            label4.Text = rb1.motor.ToString();
            label5.Text = rb1.fiyat.ToString();
        }
    }
}
