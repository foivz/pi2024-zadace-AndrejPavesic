namespace TrecaZadaca
{
    partial class frmAddBuses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBuses));
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.lblAddID = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddDest = new System.Windows.Forms.TextBox();
            this.txtAddSP = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddDest = new System.Windows.Forms.Label();
            this.lblAddSP = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(137, 27);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(159, 22);
            this.txtAddID.TabIndex = 0;
            // 
            // lblAddID
            // 
            this.lblAddID.AutoSize = true;
            this.lblAddID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddID.Location = new System.Drawing.Point(106, 27);
            this.lblAddID.Name = "lblAddID";
            this.lblAddID.Size = new System.Drawing.Size(26, 16);
            this.lblAddID.TabIndex = 1;
            this.lblAddID.Text = "ID:";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(137, 111);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(159, 22);
            this.txtAddName.TabIndex = 2;
            // 
            // txtAddDest
            // 
            this.txtAddDest.Location = new System.Drawing.Point(137, 83);
            this.txtAddDest.Name = "txtAddDest";
            this.txtAddDest.Size = new System.Drawing.Size(159, 22);
            this.txtAddDest.TabIndex = 3;
            // 
            // txtAddSP
            // 
            this.txtAddSP.Location = new System.Drawing.Point(137, 55);
            this.txtAddSP.Name = "txtAddSP";
            this.txtAddSP.Size = new System.Drawing.Size(159, 22);
            this.txtAddSP.TabIndex = 4;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(82, 114);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(50, 16);
            this.lblAddName.TabIndex = 5;
            this.lblAddName.Text = "Naziv:";
            // 
            // lblAddDest
            // 
            this.lblAddDest.AutoSize = true;
            this.lblAddDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDest.Location = new System.Drawing.Point(54, 86);
            this.lblAddDest.Name = "lblAddDest";
            this.lblAddDest.Size = new System.Drawing.Size(79, 16);
            this.lblAddDest.TabIndex = 6;
            this.lblAddDest.Text = "Odredište:";
            // 
            // lblAddSP
            // 
            this.lblAddSP.AutoSize = true;
            this.lblAddSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSP.Location = new System.Drawing.Point(62, 55);
            this.lblAddSP.Name = "lblAddSP";
            this.lblAddSP.Size = new System.Drawing.Size(71, 16);
            this.lblAddSP.TabIndex = 7;
            this.lblAddSP.Text = "Polazište";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(137, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 267);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddSP);
            this.Controls.Add(this.lblAddDest);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtAddSP);
            this.Controls.Add(this.txtAddDest);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblAddID);
            this.Controls.Add(this.txtAddID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBuses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje nove vozne linije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label lblAddID;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddDest;
        private System.Windows.Forms.TextBox txtAddSP;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddDest;
        private System.Windows.Forms.Label lblAddSP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}