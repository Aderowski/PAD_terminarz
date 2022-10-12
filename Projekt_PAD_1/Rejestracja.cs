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
    public partial class Rejestracja : Form
    {
        private string Login;
        private string Email;
        private string Haslo;
        private string Imie;
        private string Nazwisko;

        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Rimie_Click(object sender, EventArgs e)
        {

        }

        private void Rnazwisko_Click(object sender, EventArgs e)
        {

        }

        private void Remail_Click(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
        public int IloscPoprawnychElementów;
        private void RbtnZarejestruj_Click(object sender, EventArgs e)
        {
            
            

            Imie = Rimie.Text;
            Nazwisko = Rnazwisko.Text;
            if (Remail.Text.Contains('@') == true && Remail.Text.Contains('.') == true)
            {
                IloscPoprawnychElementów=IloscPoprawnychElementów+1;
                Email = Remail.Text;
            }
            else
            {
                MessageBox.Show("Wpisano Błędny Mail");
            }

            if(Rhaslo.Text != "" && Rhaslo.Text.Length >= 8)
            {
                if (Rpowhaslo.Text == Rhaslo.Text)
                {
                    IloscPoprawnychElementów++;
                    Haslo = Rhaslo.Text;
                }
                else if(Rpowhaslo.Text != Rhaslo.Text)
                {
                    MessageBox.Show("Błędne hasła");
                    Rhaslo.Text = "";
                }
            }else if (Rhaslo.Text.Length < 8)
            {
                MessageBox.Show("Hasło ma za mało znaków; Potrzebna ilość znaków : 8");
                Rhaslo.Text = "";
            }

            /*if(Rlogin.Text != "" && Rlogin.Text.Length >= 6)
            {
                IloscPoprawnychElementów++;
                Login = Rlogin.Text;
            }
            else if (Rlogin.Text == "")
            {
                MessageBox.Show("Nie Podałeś loginu");
                Rlogin.Text = "";
            }
            else if (Rlogin.Text.Length < 6)
            {
                MessageBox.Show("Login jest za krótki; Potrzebna ilość znaków : 6");
                Rlogin.Text = "";
            }*/

            if (IloscPoprawnychElementów > 3)
            {
                MessageBox.Show("Zarejestrowałeś się!"); 
                Rejestracja R = new Rejestracja();
                R.Close();
            }
            else
            {
                MessageBox.Show("Błąd");
            }

        }

        private void Rpowrot_Click(object sender, EventArgs e)
        {
            this.Close();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();

        }

        private void Rimie1_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(150, 40);
        }

        private void Rpowhaslo_Click(object sender, EventArgs e)
        {

        }

        private void Rlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rhaslo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_logowanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }
    }
}
