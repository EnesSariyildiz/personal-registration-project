using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_registration_project
{
    public partial class Frmİstatislik : Form
    {
        public Frmİstatislik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T54ECK5;Initial Catalog=personel_veri_tabani;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frmİstatislik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel");
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }

            baglanti.Close();
        }
    }
}
