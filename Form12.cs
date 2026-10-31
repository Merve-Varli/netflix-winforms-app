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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=cocuklistesi.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from cocuklistesi";
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["Yetişkinlik Düzeyi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=cocuklistesi.accdb;Persist Security Info=False;");
            baglanti.Open();
            string yapimyili = textBox1.Text;
            string adi = textBox2.Text;
            string sure = textBox3.Text;
            string yetiskinlikduzeyi = textBox4.Text;

            OleDbCommand komut = new OleDbCommand("INSERT INTO cocuklistesi ([Yapım Yılı], [Adı], [Süre], [Yetişkinlik Düzeyi]) " +
    "VALUES ('" + yapimyili + "', '" + adi + "', '" + sure + "', '" + yetiskinlikduzeyi + "')", baglanti);
            komut.ExecuteNonQuery();

            komut.CommandText = ("Select*From cocuklistesi");
            OleDbDataReader oku = komut.ExecuteReader();

            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["Yetişkinlik Düzeyi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=cocuklistesi.accdb;Persist Security Info=False;");
            baglanti.Open();
            string yapimyili = textBox1.Text;
            string adi = textBox2.Text;
            string sure = textBox3.Text;
            string yetiskinlikduzeyi = textBox4.Text;

            OleDbCommand komut = new OleDbCommand("Delete From cocuklistesi Where [Yetişkinlik Düzeyi]='18+'", baglanti);
            komut.ExecuteNonQuery();

            komut.CommandText = ("Select*From cocuklistesi");
            OleDbDataReader oku = komut.ExecuteReader();

            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Yapım Yılı"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Süre"].ToString());
                ekle.SubItems.Add(oku["Yetişkinlik Düzeyi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
