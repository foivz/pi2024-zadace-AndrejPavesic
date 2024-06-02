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
using System.Xml.Linq;

namespace TrecaZadaca
{
    public partial class frmAddBuses : Form
    {
        public frmAddBuses()
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtAddID.Text;
            string startingPoint = txtAddSP.Text;
            string Destination = txtAddDest.Text;
            string Name = txtAddName.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(startingPoint) || string.IsNullOrEmpty(Destination) || string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Molimo ispunite sva polja.");
                return;
            }

            try
            {
                DB.OpenConnection();
                string query = $"INSERT INTO Buses (ID, Starting_point, Destination, Name) VALUES ({id}, N'{startingPoint}', N'{Destination}', N'{Name}')";
                DB.ExecuteCommand(query);
                MessageBox.Show("Podaci su uspješno uneseni u bazu");
            }

            catch (Exception ex) { 
                MessageBox.Show($"Dogodila se greška: {ex.Message}");
            }

            finally
            {
                DB.CloseConnection();
            }
        }
    }
}
