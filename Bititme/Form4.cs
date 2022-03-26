using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bititme
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4QCF5KV\\SQLEXPRESS;Initial Catalog=çalışanlar;Integrated Security=True");
        private void verilerigoster()
        {

            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from bilgiler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["departman"].ToString());
                ekle.SubItems.Add(oku["yaş"].ToString());
                ekle.SubItems.Add(oku["maaş"].ToString());
                ekle.SubItems.Add(oku["telefonno"].ToString());
                
                listView1.Items.Add(ekle);

            }
            baglan.Close();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into bilgiler(id,adsoyad,departman,yaş,maaş,telefonno) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() +  "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void Form4_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }
        int id = 0;
        private void button3_Click(object sender, System.EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from bilgiler where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
           
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
           
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update bilgiler set id='" + textBox1.Text.ToString() + "',adsoyad='" + textBox2.Text.ToString() + "',departman='" + textBox3.Text.ToString() + "',yaş='" + textBox4.Text.ToString() + "',maaş='" + textBox5.Text.ToString() + "',telefonno='"  + textBox6.Text.ToString() +  "' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();

        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();

        }
    }
}
