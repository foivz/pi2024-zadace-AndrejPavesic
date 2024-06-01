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
            InitializeComponent();
        }

        private void Buses_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_apavesic22_DB", "apavesic22", "qnqG5Szt");

        }


    }
}
