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


    }
}
