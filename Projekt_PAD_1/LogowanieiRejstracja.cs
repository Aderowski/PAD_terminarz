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
    public partial class LogowanieiRejstracja : Form
    {
        public LogowanieiRejstracja()
        {
            InitializeComponent();
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {
            
            Logowanie1 logowanie1 = new Logowanie1();
            panel1.Controls.Add(logowanie1);
            logowanie1.Visible = true;
            logowanie1.Dock = DockStyle.Fill;
            logowanie1.BringToFront();
        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            Logowanie1 logowanie1 = new Logowanie1();
            panel1.Controls.Add(logowanie1);
            logowanie1.Visible = true;
            logowanie1.Dock = DockStyle.Fill;
            logowanie1.BringToFront();
        }
    }
}
