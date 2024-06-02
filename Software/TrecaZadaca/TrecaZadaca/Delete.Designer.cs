namespace TrecaZadaca
{
    partial class frmDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelete));
            this.cboLines = new System.Windows.Forms.ComboBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLines
            // 
            this.cboLines.FormattingEnabled = true;
            this.cboLines.Location = new System.Drawing.Point(130, 56);
            this.cboLines.Name = "cboLines";
            this.cboLines.Size = new System.Drawing.Size(219, 24);
            this.cboLines.TabIndex = 0;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(127, 37);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(225, 16);
            this.lblLines.TabIndex = 1;
            this.lblLines.Text = "Odaberite ID linije koju želite obrisati:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(243, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "OBRIŠI";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 166);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.cboLines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelete";
            this.Text = "Brisanje vozne linije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLines;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Button btnDelete;
    }
}