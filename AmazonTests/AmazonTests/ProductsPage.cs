using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
  public  class ProductsPage : Page
    {
       public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        private IWebElement Departments => driver.FindElement(By.XPath("//span[@class='a-expander-prompt']"));

        private IWebElement ToyAndGames => driver.FindElement(By.XPath("//h4[@class='a-size-small a-spacing-top-mini a-color-base a-text-bold']"));

        private IWebElement MinPriceField => driver.FindElement(By.Id("low-price"));

        private IWebElement MaxPriceField => driver.FindElement(By.Id("high-price"));

        private IWebElement GoButton => driver.FindElement(By.XPath("//input[@class='a-button-input']"));

        private IWebElement CheckBox => driver.FindElement(By.XPath("//type[@name='s-ref-checkbox-5442388011']"));

    }
}
