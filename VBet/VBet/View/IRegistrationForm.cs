using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.View
{
    public interface IRegistrationForm
    {
        string FirstName { get; }
        string SecondName { get; }
        string Email { get; }
        string Password { get; }

        bool IsSuccessful { get; set; }

        event EventHandler Register;
    }
}
