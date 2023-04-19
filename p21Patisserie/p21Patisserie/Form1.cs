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
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace p21Patisserie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p21Pastahane;Integrated Security=True");

        void malzemeliste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Table_Malzemeler", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void urunliste()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select*from Table_Urunler", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select*from Table_Kasa", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void Urunler()
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select*from Table_Urunler",conn);
            DataTable dt1 = new DataTable();
            da1 .Fill(dt1);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt1;
            conn.Close();
        }

        void Malzemeler()
        {
            conn.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select*from Table_Malzemeler", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt2;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeliste();
            malzemeliste();
            Urunler();
            Malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            urunliste();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemeliste();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Malzemeler (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            cmd.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            cmd.Parameters.AddWithValue("@p4", txtMalzemeNot.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzemeliste();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Table_Urunler (AD) values (@p1)", conn);
            cmd1.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün Sisteme Eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunliste();
        }

        private void btnUrunOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Table_Firin (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", conn);
            cmd2.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            cmd2.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            cmd2.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            cmd2.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün Gereksinimleri Sisteme Eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if(txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Table_Malzemeler where MALZEMEID=@p1", conn);
            cmd2.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                txtMaliyet.Text = reader[3].ToString();
            }
            conn.Close();

            maliyet =Convert.ToDouble(txtMaliyet.Text)/1000 * Convert.ToDouble(txtMiktar.Text);
            txtMaliyet.Text=maliyet.ToString();
        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            conn.Open();
            SqlCommand cmd5 = new SqlCommand("select sum (MALIYET) from Table_Firin where URUNID=@p1", conn);
            cmd5.Parameters.AddWithValue("@p1",txtUrunID.Text);
            SqlDataReader r = cmd5.ExecuteReader();
            while (r.Read())
            {
                txtUrunMaliyet.Text = r[0].ToString();
            }
            conn.Close();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("update Table_Urunler set MALIYETFIYAT=@p1,SATISFIYAT=@p2,STOK=@p3 where URUNID=@p4", conn);
            cmd6.Parameters.AddWithValue("@p1", decimal.Parse(txtUrunMaliyet.Text));
            cmd6.Parameters.AddWithValue("@p2", decimal.Parse(txtUrunSatis.Text));
            cmd6.Parameters.AddWithValue("@p3", txtUrunStok.Text);
            cmd6.Parameters.AddWithValue("@p4", txtUrunID.Text);
            cmd6.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün Güncellendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunliste();

            conn.Open();
            SqlCommand cmd7 = new SqlCommand("update Table_Kasa set GIRIS=GIRIS+@s1, CIKIS=CIKIS+@s2", conn);
            cmd7.Parameters.AddWithValue("@s1", decimal.Parse(txtUrunMaliyet.Text) * decimal.Parse(txtUrunStok.Text));
            cmd7.Parameters.AddWithValue("@s2", decimal.Parse(txtUrunSatis.Text) * decimal.Parse(txtUrunStok.Text));
            cmd7.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kasaya Giriş Yapıldı!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUrunStok_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
