using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Tests
{

    class RegisterCases : Base

    {
        LoginCases login;
        public RegisterCases(IApp app) : base(app)
        {


        }

        public void BeforeEachTest()
        {
            this.login = new LoginCases(this.app);
        }

        public Boolean addEmptySpace()
        {
            //  Sesion
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");
            //Lista
            Query add_fab = c => c.Marked("label");
            Query board_name = c => c.Marked("board_name");
            Query text1 = c => c.Marked("text1");
            Query create_board = c => c.Marked("create_board");
            Query visibility_spinner_label = c => c.Marked("visibility_spinner_label");
            Query visibility_spinner = c => c.Marked("visibility_spinner");
            Query text2 = c => c.Marked("text2");
            Query icon_view = c => c.Marked("icon_view");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.Tap(add_fab);
            this.EnterText(board_name, "TestEmpty");
            this.Tap(text1);
            this.Tap(c => c.Marked("Public"));
            this.Tap(create_board);

            return true;

        }
        public Boolean addNormalsWords()
        {
            //  Sesion
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");
            //Lista
            Query add_fab = c => c.Marked("label");
            Query board_name = c => c.Marked("board_name");
            Query text1 = c => c.Marked("text1");
            Query create_board = c => c.Marked("create_board");
            Query visibility_spinner_label = c => c.Marked("visibility_spinner_label");
            Query visibility_spinner = c => c.Marked("visibility_spinner");
            Query text2 = c => c.Marked("text2");
            Query icon_view = c => c.Marked("icon_view");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.Tap(add_fab);
            this.EnterText(board_name, "BoardTest");
            this.Tap(text1);
            this.Tap(c => c.Marked("Public"));
            this.Tap(create_board);

            return true;

        }

        public Boolean addSymbols()
        {
            //  Sesion
            Query loginButton = c => c.Marked("log_in_button");
            Query userText = c => c.Marked("user");
            Query buttonUser = c => c.Marked("authenticate");
            Query passwordText = c => c.Marked("password");
            Query homeboard = c => c.Marked("boards_container");
            //Lista
            Query add_fab = c => c.Marked("label");
            Query board_name = c => c.Marked("board_name");
            Query text1 = c => c.Marked("text1");
            Query create_board = c => c.Marked("create_board");
            Query visibility_spinner_label = c => c.Marked("visibility_spinner_label");
            Query visibility_spinner = c => c.Marked("visibility_spinner");
            Query text2 = c => c.Marked("text2");
            Query icon_view = c => c.Marked("icon_view");

            this.login = new LoginCases(this.app);
            this.login.validCredentials();
            this.Tap(add_fab);
            this.EnterText(board_name, "#$%@");
            this.Tap(text1);
            this.Tap(c => c.Marked("Public"));
            this.Tap(create_board);

            return true;

        }
    }
}
