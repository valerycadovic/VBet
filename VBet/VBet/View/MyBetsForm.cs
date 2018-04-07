using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VBet.Model.DatabaseApi.UserData;

namespace VBet.View
{
    public partial class MyBetsForm : Form, IMyBetsForm
    {
        public MyBetsForm(int id)
        {
            InitializeComponent();
            this.Id = id;
            this.Load += MyBetsForm_Load;
            //UserDataContext db = new UserDataContext();
            //db.Bets.Where(p => p.HolderId == this.Id).Load();

            //gridMyBets.DataSource = db.Bets.Local.ToBindingList();

        }

        private void MyBetsForm_Load(object sender, System.EventArgs e)
        {
            LoadMyBets?.Invoke(this.Id);
        }

        public int Id { get; private set; }
        public object DataSource
        {
            set
            {
                this.gridMyBets.DataSource = value;
            }
        }

        public event LoadMyBetsHandler LoadMyBets;
    }
}
