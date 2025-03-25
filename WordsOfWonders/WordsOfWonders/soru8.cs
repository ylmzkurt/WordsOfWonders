using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWonders
{
    public partial class soru8 : Form
    {
        public int ipucu_sayac = 0;
        private int maxProgressBarValue = 30000;
        public soru8()
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
                        

                        soru9 soruGoster = new soru9();
                        this.Hide();
                        soruGoster.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (ipucu_sayac == 0)
            {
                textBox1.Text = "____";
                ipucu_sayac++;

            }
            else if (ipucu_sayac == 1)
            {
                textBox1.Text = "__n_";
                ipucu_sayac++;
            }

            else if (ipucu_sayac == 2)
            {
                textBox1.Text = "_en_";
                ipucu_sayac++;
            }
            else if (ipucu_sayac >= 3)
            {
                MessageBox.Show("You are entitled to 3 clues!", "WoW");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += timer1.Interval;

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    textBox1.Text = "tent";

                    MessageBox.Show("Time's up! The game is over.");
                    Application.Exit();
                }
            }
        }
    }
}
