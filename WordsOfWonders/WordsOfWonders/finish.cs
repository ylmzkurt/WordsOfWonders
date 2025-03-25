using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWonders
{
    public partial class finish : Form
    {
        public finish()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "WoW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();

            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1Goster = new Form1();
            form1Goster.Show();
        }
    }
}
