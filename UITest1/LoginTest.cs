using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Tests
{
    class LoginCases : Base
    {
        public LoginCases(IApp app) : base(app)
        {

        }

        public Boolean validCredentials()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");
            
            this.Tap(loginButton);
            this.WaitForElement(userText);
            this.EnterText(userText, "kevin.pedroza@dotcreek.com");
            this.Tap(buttonUser);
            this.WaitForElement(passwordText);
            this.EnterText(passwordText, "12345678");
            this.Tap(buttonUser);
            this.WaitForElement(homeboard);

            return true;
        }

        public Boolean invalidCredentials()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query alertView = c => c.Marked("alertTitle");

            this.Tap(loginButton);
            this.WaitForElement(userText);
            this.EnterText(userText, "kevin.pedroza@invalid.com");
            this.Tap(buttonUser);
            this.WaitForElement(passwordText);
            this.EnterText(passwordText, "987654321");
            this.Tap(buttonUser);
            this.WaitForElement(alertView);

            return true;
        }

        public Boolean onlyInvalidPassword()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query alertView = c => c.Marked("alertTitle");

            this.Tap(loginButton);
            this.WaitForElement(userText);
            this.EnterText(userText, "kevin.pedroza@dotcreek.com");
            this.Tap(buttonUser);
            this.WaitForElement(passwordText);
            this.EnterText(passwordText, "123232");
            this.Tap(buttonUser);
            this.WaitForElement(alertView);

            return true;
        }

    }
}
