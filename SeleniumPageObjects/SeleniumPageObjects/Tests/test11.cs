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
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace mySeliniumTest.Tests
{
    [TestFixture]

    public class test1
    {
        //public IWebDriver driver;

        [Test]
        public void test11()
        {


            //# Browser browser = new Browser(driver, "CHROME");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://automationpractice.com/index.php";
          
            HomePage homepage = new HomePage(driver);
            WomenPage womenpage=homepage.click_women();
            womenpage.verify_page_title();
            driver.Quit();
        }
        [Test]
        public void test2()
        {
            //Browser browser = new Browser(driver, "CHROME");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://automationpractice.com/index.php";
            HomePage homepage = new HomePage(driver);
            LoginPage lp = homepage.click_sign_in_link();
            AccountsPage ap=lp.validSignIn();
            ap.verifyPageTitle();
            driver.Quit();

        }

    }
}
