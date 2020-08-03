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


namespace Proje_SQL_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            FrmUrunler fr = new FrmUrunler();
            fr.Show();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J99GINJ\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //// ürünlerin durum seviyesi
            //SqlCommand komut = new SqlCommand("Execute Test4", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            // grafik verisi çekmek

            //SqlCommand komut2 = new SqlCommand("Select KATEGORIAD, COUNT(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID=TBLURUNLER.KATEGORI GROUP BY KATEGORIAD");
            //burda kaldım. 

        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri fr2= new FrmMusteri();
            fr2.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-J99GINJ\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True