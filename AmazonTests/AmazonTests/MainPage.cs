using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class MainPage : Page
    {

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            this.url = "https://www.amazon.com/";
        }

        private IWebElement SearchBox => driver.FindElement(By.Id("twotabsearchtextbox"));

        private IWebElement SearchButton => driver.FindElement(By.XPath("//input[@class='nav-input']"));

        public void SearchForHarryPotter()
        {
            driver.Navigate().GoToUrl(url);
            SearchBox.Clear();
            SearchBox.SendKeys("HarryPotter");
            SearchButton.Click();
        }


    }
}
