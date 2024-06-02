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
       

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Unesite podatke prije nego što pokušate odraditi prijavu", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DB.OpenConnection();
                string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{txtUsername.Text}' AND Password = '{txtPassword.Text}'";
                int userCount = (int)DB.GetScalar(query);

                if (userCount > 0)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buses vozniPark = new Buses();
                    Hide();
                    vozniPark.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravno korisničko ime ili lozinka.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se greška: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }


        }

    }
}
