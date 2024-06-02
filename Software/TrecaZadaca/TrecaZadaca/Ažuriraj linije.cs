using System;
using DBLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrecaZadaca
{
    public partial class frmUpdateBuses : Form
    {
        public frmUpdateBuses()
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("ID mora biti broj.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string startingPoint = txtStartingPoint.Text;
            string destination = txtDestination.Text;
            string name = txtName.Text;

            if (string.IsNullOrEmpty(startingPoint) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Molimo ispunite sva polja.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DB.OpenConnection();
                string checkQuery = $"SELECT COUNT(*) FROM Buses WHERE ID = {id}";
                int count = (int)DB.GetScalar(checkQuery);

                if (count == 0)
                {
                    MessageBox.Show("Vozna linija s unesenim ID-om nije pronađena.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updateQuery = $"UPDATE Buses SET Starting_point = N'{startingPoint}', Destination = N'{destination}', Name = N'{name}' WHERE ID = {id}";
                    DB.ExecuteCommand(updateQuery);
                    MessageBox.Show("Vozna linija je uspješno ažurirana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
