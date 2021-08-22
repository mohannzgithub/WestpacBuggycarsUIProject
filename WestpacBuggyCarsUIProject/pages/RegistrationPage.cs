using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestpacBuggyCarsUIProject.Pages
{
    public interface RegistrationPage
    {
        //void registration(User user);
        void submitForm();
        String readMessage();
    }
}
