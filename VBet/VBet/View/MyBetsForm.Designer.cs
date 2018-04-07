namespace VBet.View
{
    partial class MyBetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBetsForm));
            this.gridMyBets = new System.Windows.Forms.DataGridView();
            this.Teams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coeffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMyBets
            // 
            this.gridMyBets.AllowUserToAddRows = false;
            this.gridMyBets.AllowUserToDeleteRows = false;
            this.gridMyBets.AutoGenerateColumns = false;
            this.gridMyBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyBets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.Teams,
            this.formulaDataGridViewTextBoxColumn,
            this.coeffDataGridViewTextBoxColumn,
            this.betPriceDataGridViewTextBoxColumn});
            this.gridMyBets.DataSource = this.betEntityBindingSource;
            this.gridMyBets.Location = new System.Drawing.Point(3, 156);
            this.gridMyBets.Name = "gridMyBets";
            this.gridMyBets.ReadOnly = true;
            this.gridMyBets.Size = new System.Drawing.Size(509, 208);
            this.gridMyBets.TabIndex = 0;
            // 
            // Teams
            // 
            this.Teams.DataPropertyName = "Teams";
            this.Teams.HeaderText = "Teams";
            this.Teams.Name = "Teams";
            this.Teams.ReadOnly = true;
            this.Teams.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Активные ставки";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formulaDataGridViewTextBoxColumn
            // 
            this.formulaDataGridViewTextBoxColumn.DataPropertyName = "Formula";
            this.formulaDataGridViewTextBoxColumn.HeaderText = "Formula";
            this.formulaDataGridViewTextBoxColumn.Name = "formulaDataGridViewTextBoxColumn";
            this.formulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.formulaDataGridViewTextBoxColumn.Width = 50;
            // 
            // coeffDataGridViewTextBoxColumn
            // 
            this.coeffDataGridViewTextBoxColumn.DataPropertyName = "Coeff";
            this.coeffDataGridViewTextBoxColumn.HeaderText = "Coeff";
            this.coeffDataGridViewTextBoxColumn.Name = "coeffDataGridViewTextBoxColumn";
            this.coeffDataGridViewTextBoxColumn.ReadOnly = true;
            this.coeffDataGridViewTextBoxColumn.Width = 50;
            // 
            // betPriceDataGridViewTextBoxColumn
            // 
            this.betPriceDataGridViewTextBoxColumn.DataPropertyName = "BetPrice";
            this.betPriceDataGridViewTextBoxColumn.HeaderText = "BetPrice";
            this.betPriceDataGridViewTextBoxColumn.Name = "betPriceDataGridViewTextBoxColumn";
            this.betPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.betPriceDataGridViewTextBoxColumn.Width = 50;
            // 
            // betEntityBindingSource
            // 
            this.betEntityBindingSource.DataSource = typeof(VBet.Model.DatabaseApi.UserData.Tables.BetEntity);
            // 
            // MyBetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMyBets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyBetsForm";
            this.Text = "MyBetsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMyBets;
        private System.Windows.Forms.BindingSource betEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teams;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coeffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn betPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}