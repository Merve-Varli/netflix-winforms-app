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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=hollywoodfilmleri.accdb;Persist Security Info=False;");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from hollywoodfilmleri";
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
                ekle.SubItems.Add(oku["Yönetmen"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From hollywoodfilmleri Where [IMDb]<'7'", baglanti);
            komut.ExecuteNonQuery();

            komut.CommandText = ("Select*From hollywoodfilmleri");
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
                ekle.SubItems.Add(oku["Yönetmen"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
