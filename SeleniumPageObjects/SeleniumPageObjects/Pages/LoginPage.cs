using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using mySeliniumTest.Configs;

namespace mySeliniumTest.Pages
{
    public class LoginPage
    {
        private IWebDriver driver ;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        webDOM config = new webDOM();
        IWebElement userName => driver.FindElement(By.Id(config.login_emailid));
        IWebElement password => driver.FindElement(By.Id(config.login_pwd));
        IWebElement submit => driver.FindElement(By.Id(config.login_submit));

        public AccountsPage validSignIn()
        {
            userName.SendKeys("senthilkumar369@gmail.com");
            password.SendKeys("orange123");
            submit.Click();
            return new AccountsPage(driver);
        }
    }
}
