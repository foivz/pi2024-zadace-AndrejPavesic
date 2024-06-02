namespace TrecaZadaca
{
    partial class frmSearchBuses
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
            this.txtStartingPoint = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStartingPoint = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartingPoint
            // 
            this.txtStartingPoint.Location = new System.Drawing.Point(160, 30);
            this.txtStartingPoint.Name = "txtStartingPoint";
            this.txtStartingPoint.Size = new System.Drawing.Size(200, 22);
            this.txtStartingPoint.TabIndex = 0;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(160, 70);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(200, 22);
            this.txtDestination.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblStartingPoint
            // 
            this.lblStartingPoint.AutoSize = true;
            this.lblStartingPoint.Location = new System.Drawing.Point(30, 30);
            this.lblStartingPoint.Name = "lblStartingPoint";
            this.lblStartingPoint.Size = new System.Drawing.Size(94, 16);
            this.lblStartingPoint.TabIndex = 3;
            this.lblStartingPoint.Text = "Starting Point:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(30, 70);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 16);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(160, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(30, 200);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(700, 300);
            this.dgvResults.TabIndex = 7;
            // 
            // frmSearchBuses
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStartingPoint);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtStartingPoint);
            this.Name = "frmSearchBuses";
            this.Text = "Search Buses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStartingPoint;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStartingPoint;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}
