﻿namespace TrecaZadaca
{
    partial class frmUpdateBuses
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtStartingPoint = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStartingPoint = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtStartingPoint
            // 
            this.txtStartingPoint.Location = new System.Drawing.Point(160, 70);
            this.txtStartingPoint.Name = "txtStartingPoint";
            this.txtStartingPoint.Size = new System.Drawing.Size(200, 22);
            this.txtStartingPoint.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(160, 110);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(200, 22);
            this.txtDestination.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // lblStartingPoint
            // 
            this.lblStartingPoint.AutoSize = true;
            this.lblStartingPoint.Location = new System.Drawing.Point(30, 70);
            this.lblStartingPoint.Name = "lblStartingPoint";
            this.lblStartingPoint.Size = new System.Drawing.Size(88, 16);
            this.lblStartingPoint.TabIndex = 5;
            this.lblStartingPoint.Text = "Starting Point:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(30, 110);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(77, 16);
            this.lblDestination.TabIndex = 6;
            this.lblDestination.Text = "Destination:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateBuses
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStartingPoint);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtStartingPoint);
            this.Controls.Add(this.txtID);
            this.Name = "frmUpdateBuses";
            this.Text = "Update Bus Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtStartingPoint;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStartingPoint;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
    }
}
