using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mySeliniumTest.Pages;
using OpenQA.Selenium;
using NUnit.Framework;
using mySeliniumTest.Configs;
using OpenQA.Selenium.Firefox;
using NUnit.Compatibility;


namespace mySeliniumTest.Tests
{
    [TestFixture]

    public class test1 : webDOM
    {   
        //To pass Browser Name from Nunit console, need to add TestContext.params
        String _browser = TestContext.Parameters.Get("Browser");

        [Test]
        public void test11()
        {
            IWebDriver driver = driverselectedBrowser(_browser);
            driver.Url = webProject_URL;
            HomePage homepage = new HomePage(driver);
            WomenPage womenpage=homepage.click_women();
            womenpage.verify_page_title();
            driver.Quit();
        }
        [Test]
        public void test2()
        {
            IWebDriver driver = driverselectedBrowser(_browser);
            driver.Url = webProject_URL;
            HomePage homepage = new HomePage(driver);
            LoginPage lp = homepage.click_sign_in_link();
            AccountsPage ap=lp.validSignIn();
            ap.verifyPageTitle();
            driver.Quit();

        }

    }
}
