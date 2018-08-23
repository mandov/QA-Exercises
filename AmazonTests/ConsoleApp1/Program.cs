using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            MainPage page = new MainPage(driver);
            page.SearchForHarryPotter();
        }
    }
}
