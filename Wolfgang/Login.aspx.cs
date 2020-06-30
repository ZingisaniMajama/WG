using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wolfgang.Helpers;

namespace Wolfgang
{
    public partial class Login : System.Web.UI.Page
    {
        private string _Username;
        private string _Password;
        private APIHelper _ApiHelper;

        public Login(IAPIHelper ApiHelper)
        {
                
        }
        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
                NotyfyOfPropertyChange(() => Username);
                NotyfyOfPropertyChange(() => CanLogin);
            }
        }
       

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                NotyfyOfPropertyChange(() => Password);
                NotyfyOfPropertyChange(() => CanLogin);

            }
        }

        public bool CanLogin
        {
            get
            {
                bool output = false;

                if(Username?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }


        public void LogIn()
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }
    }
}