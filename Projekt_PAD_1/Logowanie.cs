using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PAD_1
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void Llogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lpokazhaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (Lpokazhaslo.Checked == true)
            {
                Lhaslo.UseSystemPasswordChar = true;
            }
            else if(Lpokazhaslo.Checked == false)
            {
                Lhaslo.UseSystemPasswordChar = false;
            }
        }

        private void Lhaslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
        }

        private void btn_logowanie_Click(object sender, EventArgs e)
        {
            
        }
    }
}
