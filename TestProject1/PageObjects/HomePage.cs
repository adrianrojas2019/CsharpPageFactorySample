using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObjects
{
    internal class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "q")]
        private readonly IWebElement _searchtxtbox;

        [FindsBy(How = How.Name, Using = "btnK")]
        private readonly IWebElement _searchbtn;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Search(string searchText)
        {
            _searchtxtbox.SendKeys(searchText);
            //_searchbtn.Click();
            Thread.Sleep(5000);
            _searchbtn.SendKeys(Keys.Enter);
        }
    }
}
