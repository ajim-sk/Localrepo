using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    internal class SearchStepDefinitions
    {
        private IWebDriver driver;
        [Given("User open chrome browser")]
        public void GivenUserOpenChromeBrowser()
        {
            driver =new ChromeDriver();
        }

        [When("User Enters URL")]
        public void WhenUserEntersURL()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [When("User Enters Product")]
        public void WhenUserEntersProduct()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@type='text']")).SendKeys("Ayesha Shaikh");
                 
        }

        [When("User click on search button")]
        public void WhenUserClickOnSearchButton()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@type='text']")).SendKeys(Keys.Enter);
            driver.Quit();
        }

    }
}
