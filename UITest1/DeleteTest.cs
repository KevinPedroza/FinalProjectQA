using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Tests
{
    class TestDelete : Base
    {


        LoginCases login;
        public TestDelete(IApp app) : base(app)
        {

        }
        public void BeforeEachTest()
        {
            this.login = new LoginCases(this.app);
        }

        public Boolean deleteCard()
        {
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");

            Query board_name = c => c.Marked("board_name");
            Query settings = c => c.Marked("board_sections");
            Query settingsButton = c => c.Marked("settings_button");
            Query deleteButton = c => c.Text("Close board");
            Query boardUnavailable = c => c.Marked("board_unavailable_layout");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();

            this.Tap(board_name);
            this.WaitForElement(settings);
            this.Tap(settings);
            this.WaitForElement(settingsButton);
            this.Tap(settingsButton);
            this.ScrollDownTo("list_container", "Close board");
            this.WaitForElement(deleteButton);
            this.Tap(deleteButton);
            this.WaitForElement(boardUnavailable);

            return true;

        }
    }
}
