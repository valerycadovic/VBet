using System;
using System.Windows.Forms;

namespace VBet.View
{
    public partial class RegistrationForm : Form, IRegistrationForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            IsSuccessful = true;

            btnRegister.Click += BtnRegister_Click;

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (this.tbPassword.Text == this.tbAgainPassword.Text)
            {
                Register?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful == true)
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Text = string.Empty;
                tbAgainPassword.Text = string.Empty;
            }
            
        }
        


        #region Interface implementation

        public string FirstName
        {
            get
            {
                return this.tbFirstName.Text;
            }
        }

        public string SecondName
        {
            get
            {
                return this.tbSecondName.Text;
            }
        }

        public string Email
        {
            get
            {
                return this.tbEmail.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.tbPassword.Text;
            }
        }

        public bool IsSuccessful { get; set; }

        public event EventHandler Register;

        #endregion
    }
}
