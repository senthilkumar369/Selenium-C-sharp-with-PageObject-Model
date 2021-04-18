using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace mySeliniumTest.Configs
{
   public class webDOM
    {
        public IWebDriver driver;
        public string webProject_URL = "http://automationpractice.com/index.php";
        public string Login = "//*[@id='header']/div[2]/div/div/nav/div[1]/a";
        public string login_emailid = "email";
        public string login_pwd = "passwd";
        public string login_submit="SubmitLogin";

        


        public IWebDriver driverselectedBrowser(string browser)
        {
            if (browser == "firefox")
            {
                return new FirefoxDriver();
            }
            else
            {
                return new FirefoxDriver();

            }
        }
          }
}