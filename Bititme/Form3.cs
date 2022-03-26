using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Bititme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4QCF5KV\\SQLEXPRESS;Initial Catalog=hammadde;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from veriler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["hammaddeismi"].ToString());
                ekle.SubItems.Add(oku["alışfiyatı(br)"].ToString());
                ekle.SubItems.Add(oku["alışfiyatı(kg)"].ToString());
                ekle.SubItems.Add(oku["alınanşirket"].ToString());
                ekle.SubItems.Add(oku["alıştarihi"].ToString());
                ekle.SubItems.Add(oku["stokmiktarı"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();


        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into veriler(id,hammaddeismi,[alışfiyatı(br)],[alışfiyatı(kg)],alınanşirket,alıştarihi,stokmiktarı,notlar) values ('" + textBox7.Text.ToString() + "','"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+maskedTextBox1.Text.ToString()+"','"+textBox6.Text.ToString()+"','"+textBox5.Text.ToString()+"')", baglan);
            komut.ExecuteNonQuery();          
            baglan.Close();

            
            
            verilerigoster();
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from veriler where id=("+id+")",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox7.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[6].Text;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update veriler set id='" + textBox7.Text.ToString() + "',hammaddeismi='" + textBox1.Text.ToString() + "',[alışfiyatı(br)]='" + textBox2.Text.ToString()+"',[alışfiyatı(kg)]='"+textBox3.Text.ToString()+"',alınanşirket='"+textBox4.Text.ToString()+"',alıştarihi='"+maskedTextBox1.Text.ToString()+"',stokmiktarı='"+textBox6.Text.ToString()+"',notlar='"+textBox5.Text.ToString()+"' where id="+id+"",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
