using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model.DatabaseApi.UserData;
using VBet.Model.DatabaseApi.UserData.Tables;
using VBet.Model.ModelExceptions;
using VBet.View;

namespace VBet.Model
{
    public class UserListModel
    {
        public void AddUser(string FirstName, string SecondName, string Email, string Password)
        {
            if (FirstName == string.Empty || SecondName == string.Empty || Email == string.Empty || Password == string.Empty)
                throw new EmptyParameterException("Заполните все данные!");

            using (UserDataContext db = new UserDataContext())
            {
                if (db.Users.FirstOrDefault(row => row.Email == Email) == null)
                {

                    UserEntity user = new UserEntity();

                    user.FirstName = FirstName;
                    user.SecondName = SecondName;
                    user.Email = Email;
                    user.Password = Password;
                    user.UserStatus = "User";
                    user.Cash = 10;

                    db.Users.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    throw new AlreadyExistsUserClientException("Пользователь с таким адресом уже существует!");
                }
            }
        }

        public UserInfo CheckUser(string Email, string Password)
        {
            UserInfo userInfo = new UserInfo();

            using (UserDataContext db = new UserDataContext())
            {
                var query = (from row in db.Users
                             where row.Email == Email && row.Password == Password
                             select row).ToList();


                if (query.Count > 0)
                {
                    userInfo.Name = $"{query.FirstOrDefault().FirstName} {query.FirstOrDefault().SecondName}";
                    userInfo.Cash = query.FirstOrDefault().Cash;
                    userInfo.Status = query.FirstOrDefault().UserStatus;
                    userInfo.Id = query.FirstOrDefault().Id;
                }
            }

            return userInfo;
        }
    }
}
