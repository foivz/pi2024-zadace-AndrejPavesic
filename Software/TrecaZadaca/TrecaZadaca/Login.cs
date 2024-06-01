using System;
using System.Collections.Generic;
using System.ComponentModel;
using DBLayer;
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
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //DB.OpenConnection();

            /*string userUsername = $"SELECT * FROM Users WHERE Username ='korisnik'";
            string workerUsername = $"SELECT * FROM Users WHERE Username ='zaposlenik'";
            string userPsw = $"SELECT * FROM Users WHERE Password ='korisnik'";
            string workerPsw = $"SELECT * FROM Users WHERE Password ='zaposlenik'";*/

            string userUsername = "korisnik";
            string userPsw = "korisnik";
            string workerUsername = "zaposlenik";
            string workerPsw = "zaposlenik"; 

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

            else if (txtPassword.Text == userPsw && txtUsername.Text == userUsername)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            if (txtPassword.Text == workerPsw && txtUsername.Text == workerUsername)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Buses vozniPark = new Buses();
                Hide();
                vozniPark.ShowDialog();
                Close();
            }

            if (txtPassword.Text == userPsw && txtUsername.Text == userUsername)
            {
                MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Tickets karte = new Tickets();
                Hide();
                karte.ShowDialog();
                Close();

            }

            //DB.CloseConnection();
        }

    }
}
