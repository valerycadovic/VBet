namespace VBet.View
{
    partial class BetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetForm));
            this.gridCoeffs = new System.Windows.Forms.DataGridView();
            this.coeffEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1 = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1();
            this.coeffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coeffsTableAdapter = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1TableAdapters.CoeffsTableAdapter();
            this.coeffsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2 = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2();
            this.coeffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coeffsTableAdapter1 = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2TableAdapters.CoeffsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.formulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoeffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCoeffs
            // 
            this.gridCoeffs.AllowUserToAddRows = false;
            this.gridCoeffs.AllowUserToDeleteRows = false;
            this.gridCoeffs.AutoGenerateColumns = false;
            this.gridCoeffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoeffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formulaDataGridViewTextBoxColumn,
            this.coefficientDataGridViewTextBoxColumn});
            this.gridCoeffs.DataSource = this.coeffEntityBindingSource;
            this.gridCoeffs.Location = new System.Drawing.Point(20, 138);
            this.gridCoeffs.Margin = new System.Windows.Forms.Padding(6);
            this.gridCoeffs.Name = "gridCoeffs";
            this.gridCoeffs.ReadOnly = true;
            this.gridCoeffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCoeffs.Size = new System.Drawing.Size(376, 277);
            this.gridCoeffs.TabIndex = 0;
            // 
            // coeffEntityBindingSource
            // 
            this.coeffEntityBindingSource.DataSource = typeof(VBet.Model.DatabaseApi.MatchLine.Tables.CoeffEntity);
            // 
            // _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1
            // 
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1.DataSetName = "_VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1";
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coeffsBindingSource
            // 
            this.coeffsBindingSource.DataMember = "Coeffs";
            this.coeffsBindingSource.DataSource = this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1;
            // 
            // coeffsTableAdapter
            // 
            this.coeffsTableAdapter.ClearBeforeFill = true;
            // 
            // coeffsRowBindingSource
            // 
            this.coeffsRowBindingSource.DataSource = typeof(VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1.CoeffsRow);
            // 
            // _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2
            // 
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2.DataSetName = "_VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2";
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coeffsBindingSource1
            // 
            this.coeffsBindingSource1.DataMember = "Coeffs";
            this.coeffsBindingSource1.DataSource = this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2;
            // 
            // coeffsTableAdapter1
            // 
            this.coeffsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список доступных ставок";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeams.Location = new System.Drawing.Point(15, 51);
            this.lblTeams.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(70, 25);
            this.lblTeams.TabIndex = 2;
            this.lblTeams.Text = "label2";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(15, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label3";
            // 
            // formulaDataGridViewTextBoxColumn
            // 
            this.formulaDataGridViewTextBoxColumn.DataPropertyName = "Formula";
            this.formulaDataGridViewTextBoxColumn.HeaderText = "Formula";
            this.formulaDataGridViewTextBoxColumn.Name = "formulaDataGridViewTextBoxColumn";
            this.formulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.formulaDataGridViewTextBoxColumn.Width = 150;
            // 
            // coefficientDataGridViewTextBoxColumn
            // 
            this.coefficientDataGridViewTextBoxColumn.DataPropertyName = "Coefficient";
            this.coefficientDataGridViewTextBoxColumn.HeaderText = "Coefficient";
            this.coefficientDataGridViewTextBoxColumn.Name = "coefficientDataGridViewTextBoxColumn";
            this.coefficientDataGridViewTextBoxColumn.ReadOnly = true;
            this.coefficientDataGridViewTextBoxColumn.Width = 150;
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 423);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCoeffs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "BetForm";
            this.Text = "Коэффициенты";
            ((System.ComponentModel.ISupportInitialize)(this.gridCoeffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCoeffs;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1 _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1;
        private System.Windows.Forms.BindingSource coeffsBindingSource;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet1TableAdapters.CoeffsTableAdapter coeffsTableAdapter;
        private System.Windows.Forms.BindingSource coeffsRowBindingSource;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2 _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2;
        private System.Windows.Forms.BindingSource coeffsBindingSource1;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2TableAdapters.CoeffsTableAdapter coeffsTableAdapter1;
        private System.Windows.Forms.BindingSource coeffEntityBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefficientDataGridViewTextBoxColumn;
    }
}