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

namespace WordsOfWonders
{
    public partial class soru12 : Form
    {
        public int ipucu_sayac = 0;
        private int maxProgressBarValue = 10000;
        public soru12()
        {
            InitializeComponent();

            progressBar1.Maximum = maxProgressBarValue;
            progressBar1.Value = 0;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = null;

            try
            {
                baglanti = new SqlConnection(@"Data Source=DESKTOP-NTVKR34\SQLEXPRESS;Initial Catalog=kelimeDB;Integrated Security=True");
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT kelimeAd FROM kelimeTable", baglanti);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

            tekrar_Cevap:
                while (sqlDR.Read())
                {
                    string cevap = sqlDR[0].ToString();

                    if (cevap == textBox1.Text)
                    {
                        timer1.Stop();
                        MessageBox.Show("Correct answer. Well done!", "WoW", MessageBoxButtons.OK);
                        

                        soru13 soruGoster = new soru13();
                        soruGoster.Show();

                        this.Hide();
                    }
                    else
                    {
                        
                        goto tekrar_Cevap;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sırasında bir hata oluştu.", "UYARI");
            }
            finally { if (baglanti != null) ; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += timer1.Interval;

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    textBox1.Text = "pontoon";

                    MessageBox.Show("Time's up! The game is over.");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The game will over, are you sure you want to continue?", "WoW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ipucu_sayac == 0)
            {
                textBox1.Text = "_______";
                ipucu_sayac++;

            }
            else if (ipucu_sayac == 1)
            {
                textBox1.Text = "_____o_";
                ipucu_sayac++;
            }

            else if (ipucu_sayac == 2)
            {
                textBox1.Text = "____oo_";
                ipucu_sayac++;
            }
            else if (ipucu_sayac >= 3)
            {
                MessageBox.Show("You are entitled to 3 clues!", "WoW");
            }
        }

        private void soru12_Load(object sender, EventArgs e)
        {

        }
    }
}
