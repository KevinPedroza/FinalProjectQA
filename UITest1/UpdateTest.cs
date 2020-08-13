using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Tests
{
    class Update : Base
    {
        LoginCases login;
        public Update(IApp app) : base(app)
        {

        }
        public void BeforeEachTest()
        {
            this.login = new LoginCases(this.app);
        }

        public Boolean updateWriting()
        {
            //Sesion
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");

            Query board_name = c => c.Marked("board_name");
            Query cardText = c => c.Marked("cardText");
            Query list_name = c => c.Marked("list_name");
            Query toolbar_title = c => c.Marked("toolbar_title");
            Query editing_toolbar_title = c => c.Marked("editing_toolbar_title");
            Query confirm = c => c.Marked("confirm");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.WaitForElement(board_name);
            this.Tap(board_name);
            this.WaitForElement(toolbar_title);
            this.Tap(toolbar_title);
            this.ClearText(editing_toolbar_title);
            this.EnterText(editing_toolbar_title, "BoardUpdate");
            this.WaitForElement(confirm);
            this.Tap(confirm);

            return true;
        }




        public Boolean updateSymbols()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");

            Query board_name = c => c.Marked("board_name");
            Query cardText = c => c.Marked("cardText");
            Query list_name = c => c.Marked("list_name");
            Query toolbar_title = c => c.Marked("toolbar_title");
            Query editing_toolbar_title = c => c.Marked("editing_toolbar_title");
            Query confirm = c => c.Marked("confirm");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.WaitForElement(board_name);
            this.Tap(board_name);
            this.WaitForElement(toolbar_title);
            this.Tap(toolbar_title);
            this.ClearText(editing_toolbar_title);
            this.EnterText(editing_toolbar_title, "BoardUpdate#@$*");
            this.WaitForElement(confirm);
            this.Tap(confirm);

            return true;
        }

        public Boolean updateEmpty()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");

            Query board_name = c => c.Marked("board_name");
            Query cardText = c => c.Marked("cardText");
            Query list_name = c => c.Marked("list_name");
            Query toolbar_title = c => c.Marked("toolbar_title");
            Query editing_toolbar_title = c => c.Marked("editing_toolbar_title");
            Query confirm = c => c.Marked("confirm");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.WaitForElement(board_name);
            this.Tap(board_name);
            this.WaitForElement(toolbar_title);
            this.Tap(toolbar_title);
            this.ClearText(editing_toolbar_title);
            this.EnterText(editing_toolbar_title, "              ");
            this.WaitForElement(confirm);
            this.Tap(confirm);

            return true;
        }


    }

}




