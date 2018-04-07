using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.View
{
    public interface IAuthorizationForm
    {
        UserStatus Status { get; set; }
        string Name { get; set; }
        int Id { get; set; }
        double Cash { get; set; }

        string Email { get; }
        string Password { get; }
        
        event EventHandler LogIn;

        void Show();
    }
}
