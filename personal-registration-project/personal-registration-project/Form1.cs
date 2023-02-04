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

namespace personal_registration_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T54ECK5;Initial Catalog=personel_veri_tabani;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

            this.tbl_PersonelTableAdapter.Fill(this.personel_veri_tabaniDataSet.Tbl_Personel);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_veri_tabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //Bağlantı açılıyor.
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            //@p = parametrenin p harfi kullanılıyor, isteğe göre farklı değer ataması yapılabilir.
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6",label8.Text);


            komut.ExecuteNonQuery();
            //Executenonquery = sorguyu çalıştır.
            baglanti.Close();
            //Bağlantı kapatılıyor.
            MessageBox.Show("Personel Eklendi!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }
    }
}
