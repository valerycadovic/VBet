using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBet.Presenter;

namespace VBet.View
{

    public partial class MainForm : Form, IMainForm
    {
        private readonly IAuthorizationForm invokedForm;

        public MainForm(UserStatus status, string Name, double cash, int id, IAuthorizationForm form)
        {
            InitializeComponent();

            gridLine.CellDoubleClick += GridLine_CellDoubleClick;

            this.Load += MainForm_Load;
            this.linkMyBets.Click += ShowMyBets;
            this.linkBack.Click += LeaveAccount;

            this.FormClosed += MainForm_FormClosed;

            this.invokedForm = form;

            this.UserName = Name;
            this.Cash = cash;
            this.Id = id;
            this.Status = status;
        }

        private void LeaveAccount(object sender, EventArgs e)
        {
            this.invokedForm.Show();
            this.Hide();
        }

        private void ShowMyBets(object sender, EventArgs e)
        {
            MyBetsForm form = new MyBetsForm(this.Id);
            MyBetsFormPresenter presenter = new MyBetsFormPresenter(form, new Model.BetListModel(), new MessageBoxService.MessageBoxService());

            form.Show();
        }

        

        private async void UpdateLineAsync(object sender, EventArgs e)
        {
            await Task.Run(() => UpdateLine?.Invoke());
        }

        private void GridLine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BetClick?.Invoke(this, EventArgs.Empty);
            BetForm form = new BetForm(gridLine.SelectedCells[1].Value.ToString(), DateTime.Parse(gridLine.SelectedCells[0].Value.ToString()), Id, Cash);
            BetFormPresenter presenter = new BetFormPresenter(form, new Model.BetListModel(), new MessageBoxService.MessageBoxService());

            this.UpdateCash += () => this.Cash = form.Cash;
            
            form.FormClosed += Form_FormClosed;
            
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Cash = UpdateCash?.Invoke() ?? this.Cash;
            this.lblCash.Text = $"Счёт: {this.Cash.ToString()} тенге";
        }

        #region Interface implementation

        public UserStatus Status { get; private set; }
        public string UserName { get; private set; }

        private double cash;
        public double Cash
        {
            get
            {
                return cash;
            }
            private set
            {
                cash = value;
            }
        }

        public int Id { get; set; }

        public event EventHandler BetClick;
        public event UpdateHandler UpdateLine;
        public event CashHandler UpdateCash;

        #endregion

        public async void MainForm_Load(object sender, EventArgs e)
        {
            lblCash.Text = $"Счёт: {Cash.ToString()} тенге";
            lblName.Text = UserName;
            lblOnUpdating.Text = "Идёт обновление...";

            await Task.Run(() => UpdateLine?.Invoke());

            lblOnUpdating.Text = string.Empty;

            this.Fill();
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
        


        #region SQL scripts

        private void FillByEngland()
        {
            try
            {
                this.matchesTableAdapter.FillByEngland(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.Matches);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBySpain()
        {
            try
            {
                this.matchesTableAdapter.FillBySpain(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.Matches);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByItaly()
        {
            try
            {
                this.matchesTableAdapter.FillByItaly(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.Matches);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboLeagues.SelectedItem.ToString();

            //MessageBox.Show(selectedState);

            switch (selectedState)
            {
                case "Все матчи":
                    Fill();
                    break;
                case "Англия. Премьер Лига":
                    FillByEngland();
                    break;
                case "Испания. Примера":
                    FillBySpain();
                    break;
                case "Италия. Серия А":
                    FillByItaly();
                    break;
                default:
                    throw new Exception();
            }

        }

        private void Fill()
        {
            try
            {
                this.matchesTableAdapter.Fill(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.Matches);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FillBy()
        {
            try
            {
                this.matchesTableAdapter.FillBy(this._VBet_Model_DatabaseApi_MatchLine_MatchesContextDataSet.Matches);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #endregion
    }
}
