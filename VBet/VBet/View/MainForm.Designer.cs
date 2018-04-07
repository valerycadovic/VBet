namespace VBet.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkMyBets = new System.Windows.Forms.LinkLabel();
            this.comboLeagues = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnUpdating = new System.Windows.Forms.Label();
            this.gridLine = new System.Windows.Forms.DataGridView();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet();
            this.matchesTableAdapter = new VBet._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSetTableAdapters.MatchesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblOnUpdating);
            this.splitContainer1.Panel1.Controls.Add(this.linkBack);
            this.splitContainer1.Panel1.Controls.Add(this.lblCash);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.linkMyBets);
            this.splitContainer1.Panel1.Controls.Add(this.comboLeagues);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridLine);
            this.splitContainer1.Size = new System.Drawing.Size(708, 450);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 1;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Location = new System.Drawing.Point(12, 86);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 13);
            this.linkBack.TabIndex = 8;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Выход";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCash.Location = new System.Drawing.Point(12, 57);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(45, 16);
            this.lblCash.TabIndex = 7;
            this.lblCash.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label2";
            // 
            // linkMyBets
            // 
            this.linkMyBets.AutoSize = true;
            this.linkMyBets.Location = new System.Drawing.Point(12, 175);
            this.linkMyBets.Name = "linkMyBets";
            this.linkMyBets.Size = new System.Drawing.Size(66, 13);
            this.linkMyBets.TabIndex = 2;
            this.linkMyBets.TabStop = true;
            this.linkMyBets.Text = "Мои ставки";
            // 
            // comboLeagues
            // 
            this.comboLeagues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLeagues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeagues.FormattingEnabled = true;
            this.comboLeagues.Items.AddRange(new object[] {
            "Все матчи",
            "Англия. Премьер Лига",
            "Испания. Примера",
            "Италия. Серия А"});
            this.comboLeagues.Location = new System.Drawing.Point(15, 141);
            this.comboLeagues.Name = "comboLeagues";
            this.comboLeagues.Size = new System.Drawing.Size(182, 21);
            this.comboLeagues.TabIndex = 1;
            this.comboLeagues.SelectedIndexChanged += new System.EventHandler(this.comboLeagues_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильтр:";
            // 
            // lblOnUpdating
            // 
            this.lblOnUpdating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOnUpdating.AutoSize = true;
            this.lblOnUpdating.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOnUpdating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOnUpdating.Location = new System.Drawing.Point(11, 417);
            this.lblOnUpdating.Name = "lblOnUpdating";
            this.lblOnUpdating.Size = new System.Drawing.Size(60, 24);
            this.lblOnUpdating.TabIndex = 4;
            this.lblOnUpdating.Text = "label2";
            // 
            // gridLine
            // 
            this.gridLine.AllowUserToAddRows = false;
            this.gridLine.AllowUserToDeleteRows = false;
            this.gridLine.AllowUserToResizeColumns = false;
            this.gridLine.AllowUserToResizeRows = false;
            this.gridLine.AutoGenerateColumns = false;
            this.gridLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTimeDataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn});
            this.gridLine.DataSource = this.matchesBindingSource;
            this.gridLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLine.Location = new System.Drawing.Point(0, 0);
            this.gridLine.MultiSelect = false;
            this.gridLine.Name = "gridLine";
            this.gridLine.ReadOnly = true;
            this.gridLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLine.Size = new System.Drawing.Size(492, 450);
            this.gridLine.TabIndex = 0;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Frozen = true;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "Teams";
            this.teamsDataGridViewTextBoxColumn.Frozen = true;
            this.teamsDataGridViewTextBoxColumn.HeaderText = "Teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamsDataGridViewTextBoxColumn.Width = 300;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "Matches";
            this.matchesBindingSource.DataSource = this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet;
            // 
            // _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet
            // 
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.DataSetName = "_VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet";
            this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "VBet";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel linkMyBets;
        private System.Windows.Forms.ComboBox comboLeagues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridLine;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private _VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOnUpdating;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}