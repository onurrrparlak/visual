using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuzellikMerkezi
{
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
               
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris frm = new Giris();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YCalisanlar frm = new YCalisanlar();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Musteriler frm = new Musteriler();
            frm.Show();
        }
    }
}
    