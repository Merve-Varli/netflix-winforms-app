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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=animasyon.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from animasyon";
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
            label2.Text = "ANİMASYONLAR:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=oneri.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from oneri";
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
            label2.Text = "ÖNERİ FİLMLER:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=hayvanlar.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from hayvanlar";
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
            label2.Text = "HAYVAN FİLMLERİ:";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=hayvanlar.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE hayvanlar SET [Yapım Yılı] = '3000' WHERE [Yetişkinlik Düzeyi] = 'Genel İzleyici'", baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = "Select * from hayvanlar";
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
            MessageBox.Show("Koyun Shaun Noel'den Önce Buluşalım filminin yapım yılı 2021'den 3000'e GÜNCELLENDİ.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
