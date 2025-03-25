namespace WordsOfWonders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            soru1 soruGoster = new soru1();
            soruGoster.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("In this game difficulty you will have 30 seconds to find the correct answer. Do you want to continue?", "WoW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                this.Hide();
                soru6 soruGoster = new soru6();
                soruGoster.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("In this game difficulty you will have 10 seconds to find the correct answer. Do you want to continue?", "WoW",MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                soru11 soruGoster = new soru11();
                soruGoster.Show();
            }
        }
    }
}
