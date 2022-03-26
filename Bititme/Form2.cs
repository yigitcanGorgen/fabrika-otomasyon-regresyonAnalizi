using System;
using System.Windows.Forms;

namespace Bititme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 yeni2 = new Form3();
            yeni2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 yeni4 = new Form5();
            yeni4.Show();
            this.Hide();

        }
    }
}
