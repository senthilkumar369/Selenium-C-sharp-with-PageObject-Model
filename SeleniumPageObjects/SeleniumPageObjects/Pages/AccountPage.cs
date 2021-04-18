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
    public class AccountsPage
    {
        private IWebDriver driver ;
        public AccountsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        String expected_page_Title = "My account - My Store";
        String actual_page_Title => driver.Title;

        public void verifyPageTitle()
        {
            if (expected_page_Title.Contains(actual_page_Title))
            {
                Console.WriteLine("PASS"); }
            else
            { Console.WriteLine("Fail"); }



        }
    }
}
