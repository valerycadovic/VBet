using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VBet.Model.DatabaseApi.MatchLine;

namespace VBet.View
{
    public partial class BetForm : Form, IBetForm
    {
        
        public string Teams { get; private set; }
        public DateTime StartTime { get; private set; }
        public int Id { get; private set; }
        public double Cash { get; set; }
        public object DataSource
        {
            set
            {
                this.gridCoeffs.DataSource = value;
            }
        }

        public event BetHandler PlaceBet;
        public event EmptyHandler LoadBets;

        public BetForm(string teams, DateTime startTime, int id, double cash)
        {
            InitializeComponent();

            this.Teams = teams;
            this.StartTime = startTime;
            this.Id = id;
            this.Cash = cash;
            
            this.Load += BetForm_Load;
            this.gridCoeffs.CellDoubleClick += PlaceBet_Load;
            
            lblTeams.Text = Teams;
            lblTime.Text = StartTime.ToString();
        }
        

        private void PlaceBet_Load(object sender, DataGridViewCellEventArgs e)
        {
            PlaceBetForm form = new PlaceBetForm();
            
            form.numericUpDown1.Maximum = decimal.Parse(this.Cash.ToString());
            form.numericUpDown1.Minimum = 1M;
            form.btnPlaceBet.Click += ((obj, ea) =>
            {
                    PlaceBet?.Invoke(this.Teams, this.gridCoeffs.SelectedCells[0].Value.ToString(), 
                        double.Parse(this.gridCoeffs.SelectedCells[1].Value.ToString()), 
                        double.Parse(form.numericUpDown1.Value.ToString()));
            });
            
            form.Show();
        }


        private void BetForm_Load(object sender, EventArgs e)
        {
            LoadBets?.Invoke(this.Teams);
            this.coeffsTableAdapter1.Fill(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet2.Coeffs);
        }
    }
}
