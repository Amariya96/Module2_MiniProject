﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCliq.PageObjects
{
    internal class HomeScreen
    {
        IWebDriver driver;
        public HomeScreen(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='QuickLinks__quickLinksCard'][6]")]
        private IWebElement? Screen { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[text()='quick view'])[1]")]
        private IWebElement? QuickView { get; set; }



        public void Screens()
        {
            Thread.Sleep(2000); 
            Screen?.Click();
            Thread.Sleep(3000);
            IWebElement brand = driver.FindElement(By.XPath("(//div[@class='PlpComponent__base'])[1]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(brand).Build().Perform();
            Thread.Sleep(3000);
            QuickView?.Click();
            Thread.Sleep(2000);
        }
    }
}
