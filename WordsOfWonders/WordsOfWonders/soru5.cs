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
    public partial class soru5 : Form
    {
        public int ipucu_sayac = 0;
        public soru5()
        {
            InitializeComponent();
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
                        MessageBox.Show("Correct answer. Well done!\nYou have successfully completed easy mode.", "WoW", MessageBoxButtons.OK);

                        finish finishGoster = new finish();
                        this.Hide();
                        finishGoster.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The game will over, are you sure you want to continue?", "WoW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();

            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ipucu_sayac == 0)
            {
                textBox1.Text = "___";
                ipucu_sayac++;

            }
            else if (ipucu_sayac == 1)
            {
                textBox1.Text = "_i_";
                ipucu_sayac++;
            }

            else if (ipucu_sayac == 2)
            {
                textBox1.Text = "_id";
                ipucu_sayac++;
            }
            else if (ipucu_sayac >= 3)
            {
                MessageBox.Show("You are entitled to 3 clues!", "WoW");
            }
        }
    }
}
