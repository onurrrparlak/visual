using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GuzellikMerkezi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
                SqlCommand sorgula = new SqlCommand("select * from yonetici where ykadi ='" + textBox1.Text + "' and ysifre ='" + textBox2.Text + "'", cnn);
           

            SqlDataReader dr = sorgula.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                YoneticiPanel frm = new YoneticiPanel();
                frm.Show();
                
            }
            else
            {
                label3.Show();

            }
            cnn.Close();
            cnn.Open();
            SqlCommand sorgula1 = new SqlCommand("select * from calisan where ckadi ='" + textBox1.Text + "' and csifre ='" + textBox2.Text + "'", cnn);

            SqlDataReader dr1 = sorgula1.ExecuteReader();
            if (dr1.Read())
            {
                this.Hide();
                CalisanPanel frm = new CalisanPanel();
                frm.Show();

            }
            else
            {
                label3.Show();

            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           

            textBox2.PasswordChar = '*';
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
                cnn.Open();
                SqlCommand sorgula = new SqlCommand("select * from yonetici where ykadi ='" + textBox1.Text + "' and ysifre ='" + textBox2.Text + "'", cnn);
                SqlDataReader dr = sorgula.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    YoneticiPanel frm = new YoneticiPanel();
                    frm.Show();

                }
                else
                {
                    label3.Show();

                }
                cnn.Close();
                cnn.Open();
                SqlCommand sorgula1 = new SqlCommand("select * from calisan where ckadi ='" + textBox1.Text + "' and csifre ='" + textBox2.Text + "'", cnn);

                SqlDataReader dr1 = sorgula1.ExecuteReader();
                if (dr1.Read())
                {
                    this.Hide();
                    CalisanPanel frm = new CalisanPanel();
                    frm.Show();

                }
                else
                {
                    label3.Show();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
