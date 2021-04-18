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
    public class HomePage

    {
        private IWebDriver driver ;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        webDOM config = new webDOM();
        IWebElement Link_women => driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[1]/a"));
        IWebElement lnk_sign_in => driver.FindElement(By.XPath(config.Login));

        public WomenPage click_women()
        {

                 Link_women.Click();
            return new WomenPage(driver);
        }

        public LoginPage click_sign_in_link()
        {
            lnk_sign_in.Click();
            return new LoginPage(driver);
        }

    }
}
