namespace TrecaZadaca
{
    partial class Buses
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
            this.components = new System.ComponentModel.Container();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pI2324_apavesic22_DBDataSet = new TrecaZadaca.PI2324_apavesic22_DBDataSet();
            this.busesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busesTableAdapter = new TrecaZadaca.PI2324_apavesic22_DBDataSetTableAdapters.BusesTableAdapter();
            this.iDbusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_apavesic22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuses
            // 
            this.dgvBuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuses.AutoGenerateColumns = false;
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDbusDataGridViewTextBoxColumn,
            this.startingPointDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvBuses.DataSource = this.busesBindingSource;
            this.dgvBuses.Location = new System.Drawing.Point(63, 12);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.RowHeadersWidth = 51;
            this.dgvBuses.RowTemplate.Height = 24;
            this.dgvBuses.Size = new System.Drawing.Size(773, 410);
            this.dgvBuses.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(211, 447);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(371, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 49);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "PROMIJENI";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(527, 447);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 49);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "IZBRIŠI";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(63, 447);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 49);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "PRETRAŽI";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pI2324_apavesic22_DBDataSet
            // 
            this.pI2324_apavesic22_DBDataSet.DataSetName = "PI2324_apavesic22_DBDataSet";
            this.pI2324_apavesic22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busesBindingSource
            // 
            this.busesBindingSource.DataMember = "Buses";
            this.busesBindingSource.DataSource = this.pI2324_apavesic22_DBDataSet;
            // 
            // busesTableAdapter
            // 
            this.busesTableAdapter.ClearBeforeFill = true;
            // 
            // iDbusDataGridViewTextBoxColumn
            // 
            this.iDbusDataGridViewTextBoxColumn.DataPropertyName = "ID_bus";
            this.iDbusDataGridViewTextBoxColumn.HeaderText = "ID_bus";
            this.iDbusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDbusDataGridViewTextBoxColumn.Name = "iDbusDataGridViewTextBoxColumn";
            this.iDbusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingPointDataGridViewTextBoxColumn
            // 
            this.startingPointDataGridViewTextBoxColumn.DataPropertyName = "Starting point";
            this.startingPointDataGridViewTextBoxColumn.HeaderText = "Starting point";
            this.startingPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingPointDataGridViewTextBoxColumn.Name = "startingPointDataGridViewTextBoxColumn";
            this.startingPointDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Buses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 521);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Buses";
            this.Text = "Vozne linije";
            this.Load += new System.EventHandler(this.Buses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_apavesic22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private PI2324_apavesic22_DBDataSet pI2324_apavesic22_DBDataSet;
        private System.Windows.Forms.BindingSource busesBindingSource;
        private PI2324_apavesic22_DBDataSetTableAdapters.BusesTableAdapter busesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}