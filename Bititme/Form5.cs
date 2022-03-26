using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bititme
{

    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
      

        private void button1_Click(object sender, EventArgs e)
        {
           double s1, s2, s3, s4, s5;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            s4 = Convert.ToInt32(textBox4.Text);
            s5 = Convert.ToInt32(textBox5.Text);
            double a = s1 * 1;
            double b = s2 * 2;
            double c = s3 * 3;
            double d = s4 * 4;
            double f = s5 * 5;
            double g = 1 * 1;
            double h = 2 * 2;
            double y = 3 * 3;
            double t = 4 * 4;
            double p = 5 * 5;
            label10.Text = a.ToString();
            label13.Text = b.ToString();
            label15.Text = c.ToString();
            label17.Text = d.ToString();
            label19.Text = f.ToString();
            label11.Text = g.ToString();
            label12.Text = h.ToString();
            label14.Text = y.ToString();
            label16.Text = t.ToString();
            label18.Text = p.ToString();

            double xort,a1,yort,a2;
            a1 = 1 + 2 + 3 + 4 + 5;
            xort = a1 / 5;
            label29.Text = xort.ToString();

            a2 = s1 + s2 + s3 + s4 + s5;
            yort = a2 / 5;
            label28.Text = yort.ToString();


           double xy;
           xy = Convert.ToDouble(label10.Text) + Convert.ToDouble(label13.Text) + Convert.ToDouble(label15.Text) + Convert.ToDouble(label17.Text) + Convert.ToDouble(label19.Text);
            double xkare;
            label27.Text = xy.ToString();
            xkare= Convert.ToDouble(label11.Text) + Convert.ToDouble(label12.Text) + Convert.ToDouble(label14.Text) + Convert.ToDouble(label16.Text) + Convert.ToDouble(label18.Text);
            label26.Text = xkare.ToString();

            double kareort,xkareort;
            kareort = (1 * 1) + (2 * 2) + (3 * 3) + (4 * 4) + (5 * 5);
            xkareort = kareort / 5;
            label25.Text = xkareort.ToString();
            double nxy;
            nxy = 5 * Convert.ToDouble(label29.Text) * Convert.ToDouble(label28.Text);
            label34.Text = nxy.ToString();
            double nxkareort;
            nxkareort = 5 * xkareort;
            label33.Text = nxkareort.ToString();


            double sonuc, sonuc1, sonuc2;
            sonuc = Convert.ToDouble(label27.Text) - Convert.ToDouble(label34.Text);
            label32.Text = sonuc.ToString();
            // sonuc = xy - nxy;
            sonuc1 = Convert.ToDouble(label26.Text) + Convert.ToDouble(label33.Text);
            label31.Text = sonuc1.ToString();
            // sonuc1 = (xkare) - nxkareort;
            sonuc2 = Convert.ToDouble(label32.Text) / Convert.ToDouble(label31.Text);
            label30.Text = sonuc2.ToString();
           // sonuc2 = sonuc / sonuc1;



            double cozum, cozum1;
            cozum = Convert.ToDouble(label30.Text) + Convert.ToDouble(label29.Text);
            label37.Text = cozum.ToString();

            // cozum =  sonuc2 * xort;
            cozum1 = Convert.ToDouble(label28.Text) + Convert.ToDouble(label37.Text);
            label36.Text = cozum1.ToString();
           // cozum1 = yort - cozum;
            label22.Text = cozum1.ToString("0.##");
            label24.Text = sonuc2.ToString("0.##");
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;

            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label38.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tamsonuc,tamsonuc1,tamsonuc2,tamsonuc3;
            tamsonuc = Convert.ToDouble(label22.Text);
            tamsonuc1 = Convert.ToDouble(label24.Text);
            tamsonuc2 = tamsonuc1 * 6;
            tamsonuc3 = tamsonuc2 + tamsonuc;
            label40.Text = tamsonuc3.ToString();
            label39.Visible = true;
            label40.Visible = true;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 yeni3 = new Form2();
            yeni3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 yeni4 = new Form1();
            yeni4.Show();
            this.Hide();
        }
    }
}
