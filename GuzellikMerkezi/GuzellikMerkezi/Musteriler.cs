using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkezi
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlDataReader dr;
            SqlCommand cmd;
            listView1.Items.Clear();
            cmd = new SqlCommand("Select * From musteriler", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["mid"].ToString());
                item.SubItems.Add(dr["madi"].ToString());
                item.SubItems.Add(dr["msoyadi"].ToString());
                item.SubItems.Add(dr["mtcno"].ToString());
                item.SubItems.Add(dr["mcinsiyet"].ToString());
                item.SubItems.Add(dr["mtelno"].ToString());
                item.SubItems.Add(dr["madres"].ToString());
                item.SubItems.Add(dr["mkartno"].ToString());
                item.SubItems.Add(dr["memail"].ToString());
                item.SubItems.Add(dr["mboy"].ToString());
                item.SubItems.Add(dr["mkilo"].ToString());
                item.SubItems.Add(dr["mislem"].ToString());
                item.SubItems.Add(dr["mkalanseans"].ToString());
                item.SubItems.Add(dr["mkalanborc"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gmerkezi;Integrated Security=True");
            cnn.Open();
            SqlDataReader dr;
            SqlCommand cmd;
            listView1.Items.Clear();
            cmd = new SqlCommand("Select * From musteriler", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["mid"].ToString());
                item.SubItems.Add(dr["madi"].ToString());
                item.SubItems.Add(dr["msoyadi"].ToString());
                item.SubItems.Add(dr["mtcno"].ToString());
                item.SubItems.Add(dr["mcinsiyet"].ToString());
                item.SubItems.Add(dr["mtelno"].ToString());
                item.SubItems.Add(dr["madres"].ToString());
                item.SubItems.Add(dr["mkartno"].ToString());
                item.SubItems.Add(dr["memail"].ToString());
                item.SubItems.Add(dr["mboy"].ToString());
                item.SubItems.Add(dr["mkilo"].ToString());
                item.SubItems.Add(dr["mislem"].ToString());
                item.SubItems.Add(dr["mkalanseans"].ToString());
                item.SubItems.Add(dr["mkalanborc"].ToString());
                listView1.Items.Add(item);
            }
            cnn.Close();
        }
    }
}
