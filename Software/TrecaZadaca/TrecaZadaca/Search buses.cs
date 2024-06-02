using System;
using System.Data;
using System.Windows.Forms;
using DBLayer;


namespace TrecaZadaca
{
    public partial class frmSearchBuses : Form
    {
        public frmSearchBuses()
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startingPoint = txtStartingPoint.Text;
            string destination = txtDestination.Text;
            string name = txtName.Text;

            try
            {
                DB.OpenConnection();
                string query = "SELECT * FROM Buses WHERE 1=1";

                if (!string.IsNullOrEmpty(startingPoint))
                {
                    query += $" AND Starting_point LIKE N'%{startingPoint}%'";
                }

                if (!string.IsNullOrEmpty(destination))
                {
                    query += $" AND Destination LIKE N'%{destination}%'";
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query += $" AND Name LIKE N'%{name}%'";
                }

                var reader = DB.GetDataReader(query);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvResults.DataSource = dataTable;
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
