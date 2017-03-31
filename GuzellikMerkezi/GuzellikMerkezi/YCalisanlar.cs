using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
namespace GuzellikMerkezi
{
    public partial class YCalisanlar : Form
    {
        int a = 0;
        public YCalisanlar()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void YCalisanlar_Load(object sender, EventArgs e)
        {
           
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlDataReader dr;
            SqlCommand cmd;
            listView1.Items.Clear();
            cmd = new SqlCommand("Select * From calisan", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["cid"].ToString());
                item.SubItems.Add(dr["ckadi"].ToString());
                item.SubItems.Add(dr["cadi"].ToString());
                item.SubItems.Add(dr["csoyadi"].ToString());
                item.SubItems.Add(dr["csifre"].ToString());
                item.SubItems.Add(dr["cmaas"].ToString());
                item.SubItems.Add(dr["ctel"].ToString());
                item.SubItems.Add(dr["cbolge"].ToString());
                item.SubItems.Add(dr["cbolge1"].ToString());
                item.SubItems.Add(dr["cbolge2"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            string ekle;
            ekle = "INSERT INTO calisan (ckadi,cadi,csoyadi,csifre,cmaas, ctel,cbolge,cbolge1,cbolge2) " + "VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            SqlCommand komut = new SqlCommand(ekle, cnn);
            komut.ExecuteNonQuery();
            listView1.Items.Clear();
            SqlDataReader dr;
            SqlCommand cmd;
            cmd = new SqlCommand("Select * From calisan", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["cid"].ToString());
                item.SubItems.Add(dr["ckadi"].ToString());
                item.SubItems.Add(dr["cadi"].ToString());
                item.SubItems.Add(dr["csoyadi"].ToString());
                item.SubItems.Add(dr["csifre"].ToString());
                item.SubItems.Add(dr["cmaas"].ToString());
                item.SubItems.Add(dr["ctel"].ToString());
                item.SubItems.Add(dr["cbolge"].ToString());
                item.SubItems.Add(dr["cbolge1"].ToString());
                item.SubItems.Add(dr["cbolge2"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  FROM calisan where cid='" + textBox1.Text + "'", cnn);
            kmt.ExecuteNonQuery();
            cnn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            listView1.SelectedItems[0].Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlCommand kmt = new SqlCommand("UPDATE calisan set ckadi='" + textBox2.Text + "' , cadi ='" + textBox3.Text + "' , csoyadi ='" + textBox4.Text + "' , csifre ='" + textBox5.Text + "' , cmaas ='" + textBox6.Text + "' , ctel ='" + textBox7.Text + "' , cbolge ='" + textBox8.Text + "' , cbolge1 ='" + textBox9.Text + "' , cbolge2 ='" + textBox10.Text + "'where cid='" + textBox1.Text + "'", cnn);

            kmt.ExecuteNonQuery();
            listView1.Items.Clear();
            SqlDataReader dr;
            SqlCommand cmd;
            cmd = new SqlCommand("Select * From calisan", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["cid"].ToString());
                item.SubItems.Add(dr["ckadi"].ToString());
                item.SubItems.Add(dr["cadi"].ToString());
                item.SubItems.Add(dr["csoyadi"].ToString());
                item.SubItems.Add(dr["csifre"].ToString());
                item.SubItems.Add(dr["cmaas"].ToString());
                item.SubItems.Add(dr["ctel"].ToString());
                item.SubItems.Add(dr["cbolge"].ToString());
                item.SubItems.Add(dr["cbolge1"].ToString());
                item.SubItems.Add(dr["cbolge2"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[4].Text;
                textBox6.Text = item.SubItems[5].Text;
                textBox7.Text = item.SubItems[6].Text;
                textBox8.Text = item.SubItems[7].Text;
                textBox9.Text = item.SubItems[8].Text;
                textBox10.Text = item.SubItems[9].Text;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlDataReader dr;
            SqlCommand cmd;
            listView1.Items.Clear();
            cmd = new SqlCommand("Select * From calisan where cid='" + textBox11.Text + "'", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["cid"].ToString());
                item.SubItems.Add(dr["ckadi"].ToString());
                item.SubItems.Add(dr["cadi"].ToString());
                item.SubItems.Add(dr["csoyadi"].ToString());
                item.SubItems.Add(dr["csifre"].ToString());
                item.SubItems.Add(dr["cmaas"].ToString());
                item.SubItems.Add(dr["ctel"].ToString());
                item.SubItems.Add(dr["cbolge"].ToString());
                item.SubItems.Add(dr["cbolge1"].ToString());
                item.SubItems.Add(dr["cbolge2"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            listView1.Items.Clear();
            SqlDataReader dr;
            SqlCommand cmd;
            cmd = new SqlCommand("Select * From calisan", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["cid"].ToString());
                item.SubItems.Add(dr["ckadi"].ToString());
                item.SubItems.Add(dr["cadi"].ToString());
                item.SubItems.Add(dr["csoyadi"].ToString());
                item.SubItems.Add(dr["csifre"].ToString());
                item.SubItems.Add(dr["cmaas"].ToString());
                item.SubItems.Add(dr["ctel"].ToString());
                item.SubItems.Add(dr["cbolge"].ToString());
                item.SubItems.Add(dr["cbolge1"].ToString());
                item.SubItems.Add(dr["cbolge2"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPanel frm = new YoneticiPanel();
            frm.Show();
        }
    }
}

