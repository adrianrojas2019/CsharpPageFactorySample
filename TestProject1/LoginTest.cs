using OpenQA.Selenium;
using TestProject1.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }

        [Test]
        public void SearchBrowserStack()
        {
            HomePage hp = new(_driver);
            _driver.Navigate().GoToUrl("https://google.com");
            hp.Search("BrowserStack");
            Assert.That(_driver.Title, Does.Contain("BrowserStack"));
        }
        [Test]
        public void Test()
        {
            //IWebDriver driver = new FirefoxDriver();
            LoginPage loginPage = new(_driver);
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            PageFactory.InitElements(_driver, loginPage);
            loginPage.UserName.SendKeys("Admin");
            loginPage.Password.SendKeys("admin123");
            loginPage.Submit.Click();
            Thread.Sleep(5000);
        }
    }
}