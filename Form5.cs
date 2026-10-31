using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=merveliste.accdb;Persist Security Info=False;");
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from merveliste";
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Film Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["IMDb"].ToString());
                ekle.SubItems.Add(oku["Oyuncular"].ToString());
                ekle.SubItems.Add(oku["Tür"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string yapimyili = textBox1.Text;
            string adi = textBox2.Text;
            string sure = textBox3.Text;
            string ımdb = textBox4.Text;
            string oyuncular = textBox5.Text;
            string tur = textBox6.Text;

            OleDbCommand komut = new OleDbCommand("INSERT INTO merveliste ([Yapım Yılı], [Film Adı], [Süre], [IMDb],[Oyuncular],[Tür]) " +
    "VALUES ('" + yapimyili + "', '" + adi + "', '" + sure + "', '" + ımdb + "','" + oyuncular + "','" + tur + "')", baglanti);
            komut.ExecuteNonQuery();

            komut.CommandText = ("Select*From merveliste");
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Film Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["IMDb"].ToString());
                ekle.SubItems.Add(oku["Oyuncular"].ToString());
                ekle.SubItems.Add(oku["Tür"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE merveliste SET [Yapım Yılı] = 'İzlemek İçin Son Şans' WHERE Val([Yapım Yılı]) < 2010", baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = "Select * from merveliste";
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Film Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["IMDb"].ToString());
                ekle.SubItems.Add(oku["Oyuncular"].ToString());
                ekle.SubItems.Add(oku["Tür"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            MessageBox.Show("Yapım Yılı 2010'dan küçük olan filmlerin yapım yılı 'izlemek için son şans' olarak güncellendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From merveliste Where [Yapım Yılı] = 'İzlemek İçin Son Şans'", baglanti);
            komut.ExecuteNonQuery();

            komut.CommandText = ("Select*From merveliste");
            OleDbDataReader oku = komut.ExecuteReader();

            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Film Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["IMDb"].ToString());
                ekle.SubItems.Add(oku["Oyuncular"].ToString());
                ekle.SubItems.Add(oku["Tür"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
