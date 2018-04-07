using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model;
using VBet.View;
using VBet.View.MessageBoxService;

namespace VBet.Presenter
{ 
    public class AuthorizationFormPresenter
    {
        private readonly IAuthorizationForm authorizationForm;
        private readonly UserListModel model;
        private readonly IMessageBoxService messageService;

        public AuthorizationFormPresenter(IAuthorizationForm authorizationForm, UserListModel model, IMessageBoxService messageService)
        {
            this.authorizationForm = authorizationForm;
            this.model = model;
            this.messageService = messageService;

            this.authorizationForm.LogIn += AuthorizationForm_LogIn;
        }
        
        private void AuthorizationForm_LogIn(object sender, EventArgs e)
        {
           
            var userInfo = model.CheckUser(authorizationForm.Email, authorizationForm.Password);

            if (userInfo.Status == UserStatus.User.ToString())
            {
                authorizationForm.Status = UserStatus.User;
                
                messageService.ShowMessage("Авторизация прошла успешно");
            }
            else if(userInfo.Status == UserStatus.Admin.ToString())
            {
                authorizationForm.Status = UserStatus.Admin;
                messageService.ShowMessage("Вы вошли как админ");
            }
            else
            {
                authorizationForm.Status = UserStatus.Guest;
                messageService.ShowExclamation("Неверный логин или пароль.");
            }

            authorizationForm.Name = userInfo.Name;
            authorizationForm.Id = userInfo.Id;
            authorizationForm.Cash = userInfo.Cash;
        }

    }
}
