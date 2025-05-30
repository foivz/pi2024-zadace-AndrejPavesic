﻿using TrecaZadaca.Repositories;
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
using TrecaZadaca.Models;
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
            ShowBuses();
        }

        private void ShowBuses()
        {
            List<Bus> buses = BusRepository.GetBuses();
            dgvBuses.DataSource = buses;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchBuses searchLinije = new frmSearchBuses();
            Hide();
            searchLinije.ShowDialog();
            Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBuses dodajLinije = new frmAddBuses();
            Hide();
            dodajLinije.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete obrisi = new frmDelete();
            Hide();
            obrisi.ShowDialog();
            Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateBuses linije = new frmUpdateBuses();
            Hide();
            linije.ShowDialog();
            Close();
        }
    }
}
