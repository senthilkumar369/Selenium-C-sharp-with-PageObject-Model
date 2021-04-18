using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace mySeliniumTest.Pages
{
    public class WomenPage
    {
        private IWebDriver driver;
        public WomenPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
                        
        }

        string EXPECTED_Womenpage_title = "Women - My Store";

        IWebElement x => driver.FindElement(By.Id(""));

        public void verify_page_title()
        {
            string actual_women_page_tile=driver.Title;
            if (actual_women_page_tile == EXPECTED_Womenpage_title)
            {
                Console.WriteLine("WOMEN PAGE TITLE CORRECT - Pass");
            }
            else
            {
                Console.WriteLine("INCORRECT WOMEN PAGE TITLE - FAIL");

            }
        }
       
    }
}
