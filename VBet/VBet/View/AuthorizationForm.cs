using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBet.Presenter;

namespace VBet.View
{

    public partial class AuthorizationForm : Form, IAuthorizationForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();

            linkRegister.Click += OpenRegistrationForm;

            this.Load += GetLoginAndPassword;
            
            btnEnter.Click += BtnEnter_SavePassword;
            btnEnter.Click += BtnEnter_Click;
            btnEnter.Click += GetLoginAndPassword;
        }

        private void GetLoginAndPassword(object sender, EventArgs e)
        {
            using (StreamReader stReader = new StreamReader("mem.txt"))
            {
                tbLogin.Text = stReader.ReadLine();
                tbPassword.Text = stReader.ReadLine();
                stReader.Close();
            }
        }

        private void BtnEnter_SavePassword(object sender, EventArgs e)
        {
            if (this.cbRememberPassword.Checked == true)
            {
                using (StreamWriter stWriter = new StreamWriter("mem.txt"))
                {
                    stWriter.WriteLine($"{tbLogin.Text}");
                    stWriter.WriteLine($"{tbPassword.Text}");
                    stWriter.Close();
                }
            }
        }

        #region Interface implementation

        public string Email
        {
            get
            {
                return this.tbLogin.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.tbPassword.Text;
            }
        }

        public UserStatus Status { get; set; }
        public int Id { get; set; }
        public double Cash { get; set; }

        public event EventHandler LogIn;

        #endregion

        #region External events

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            LogIn?.Invoke(this, EventArgs.Empty);

            if (this.Status != UserStatus.Guest)
            {
                MainForm form = new MainForm(this.Status, this.Name, this.Cash, this.Id, this);
                
                MainFormPresenter formPresenter =
                    new MainFormPresenter(form, new Model.MatchListModel(), new MessageBoxService.MessageBoxService());

                form.Show();

                this.Hide();
            }
        }
        

        #endregion

        #region Internal form code

        private void CloseForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OpenRegistrationForm(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();

            RegistrationFormPresenter formPresenter = new RegistrationFormPresenter(form, new Model.UserListModel(), new MessageBoxService.MessageBoxService());

            form.Show();
        }
        
        #endregion

    }
}
