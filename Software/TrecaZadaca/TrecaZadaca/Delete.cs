using DBLayer;
using System;
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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);

            DB.OpenConnection();
            string deleteQuery = $"DELETE FROM Buses WHERE ID = {ID}";

            DB.ExecuteCommand(deleteQuery);

            MessageBox.Show("Korisnik uspješno obrisan.");

            DB.CloseConnection();
            
            Buses buses = new Buses();
            Hide();
            buses.ShowDialog();
            Close();
        }

    }
}
