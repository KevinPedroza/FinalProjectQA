using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace Tests
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;

        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //Login
        [Test]
        public void loginValidCredentials()
        {
            LoginCases login = new LoginCases(app);

            Boolean result = login.validCredentials();

            Assert.IsTrue(result);
        }

        [Test]
        public void loginInvalidCredentials()
        {
            LoginCases login = new LoginCases(app);

            Boolean result = login.invalidCredentials();

            Assert.IsTrue(result);
        }

        [Test]
        public void loginOnlyInvalidPassword()
        {
            LoginCases login = new LoginCases(app);

            Boolean result = login.onlyInvalidPassword();

            Assert.IsTrue(result);
        }


        //Register 
        [Test]
        public void registerEmptySpace()
        {
            RegisterCases register = new RegisterCases(this.app);

            Boolean result = register.addEmptySpace();

            Assert.IsTrue(result);
        }

        [Test]
        public void registerSymbols()
        {
            RegisterCases register = new RegisterCases(this.app);

            Boolean result = register.addSymbols();

            Assert.IsTrue(result);
        }
        [Test]
        public void registersSuccess()
        {
            RegisterCases register = new RegisterCases(this.app);

            Boolean result = register.addNormalsWords();

            Assert.IsTrue(result);
        }
        
        //Update
        [Test]
        public void testUpdateWriting()
        {
            Update update = new Update(this.app);

            Boolean result = update.updateWriting();

            Assert.IsTrue(result);
        }

        [Test]
        public void testUpdateSymbols()
        {
            Update update = new Update(this.app);

            Boolean result = update.updateSymbols();

            Assert.IsTrue(result);
        }
        [Test]
        public void testUpdateEmpty()
        {
            Update update = new Update(this.app);

            Boolean result = update.updateEmpty();

            Assert.IsTrue(result);
        }

        //Delete
        [Test]
        public void z_TestDeleteCard()
        {
            TestDelete delete = new TestDelete(this.app);

            Boolean result = delete.deleteCard();

            Assert.IsTrue(result);
        }


    }
}
