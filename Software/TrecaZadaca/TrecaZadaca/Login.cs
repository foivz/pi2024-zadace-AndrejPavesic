using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrecaZadaca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

            string usrZaposlenik = "zaposlenik";
            string usrPutnik = "putnik";
            string pswPutnik= "putnik";
            string pswZaposlenik = "zaposlenik";

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Unesite podatke prije nego što pokušate odraditi prijavu", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == pswPutnik && txtUsername.Text == usrPutnik)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            if (txtPassword.Text == pswZaposlenik && txtUsername.Text == usrZaposlenik)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Buses vozniPark = new Buses();
                Hide();
                vozniPark.ShowDialog();
                Close();
            }

            if (txtPassword.Text == pswPutnik && txtUsername.Text == pswPutnik)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Tickets karte = new Tickets();
                Hide();
                karte.ShowDialog();
                Close();

            }


        }
    }
}
