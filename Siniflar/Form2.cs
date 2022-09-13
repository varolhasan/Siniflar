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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Mavi";
            rb2.hiz = 155;
            rb2.durum = 'i';
            rb2.motor = 1100.23;
            rb2.fiyat = 60000;

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.durum.ToString();
            label4.Text = rb2.motor.ToString();
            label5.Text = rb2.fiyat.ToString();
        }
    }
}
