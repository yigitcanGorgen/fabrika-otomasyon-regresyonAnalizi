using System;
using System.Windows.Forms;

namespace Bititme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yigit" && textBox2.Text == "12345")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();

            }
        }
    }
}
