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
    public partial class Buses : Form
    {
        
        public Buses()
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "PI2324_apavesic22_User", "qnqG5Szt");
            InitializeComponent();
        }

        private void Buses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pI2324_apavesic22_DBDataSet.Buses' table. You can move, or remove it, as needed.
            this.busesTableAdapter.Fill(this.pI2324_apavesic22_DBDataSet.Buses);

        }
    }
}
