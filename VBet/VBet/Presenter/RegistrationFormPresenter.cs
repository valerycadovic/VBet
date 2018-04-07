using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model;
using VBet.View;
using VBet.View.MessageBoxService;
using VBet.Model.ModelExceptions;

namespace VBet.Presenter
{
    class RegistrationFormPresenter
    {
        private readonly IRegistrationForm registrationForm;
        private readonly UserListModel model;
        private readonly IMessageBoxService messageService;

        public RegistrationFormPresenter(IRegistrationForm registrationForm, UserListModel model, IMessageBoxService messageService)
        {
            this.registrationForm = registrationForm;
            this.model = model;
            this.messageService = messageService;

            this.registrationForm.Register += RegistrationForm_Register;
        }

        private void RegistrationForm_Register(object sender, EventArgs e)
        {
            try
            {
                model.AddUser(registrationForm.FirstName, registrationForm.SecondName, registrationForm.Email, registrationForm.Password);
                messageService.ShowMessage("Регистрация прошла успешно!");
            }
            catch(EmptyParameterException ex)
            {
                registrationForm.IsSuccessful = false;
                messageService.ShowError(ex.Message);
            }
            catch (AlreadyExistsUserClientException ex)
            {
                registrationForm.IsSuccessful = false;
                messageService.ShowError(ex.Message);
            }
        }
    }
}
