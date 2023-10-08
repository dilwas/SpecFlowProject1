﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class HomePage
    {
        public void VerifySucssesLogin(IWebDriver driver)
        {
            //Check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath($"//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has loged in successefully");
            }
            else
            {
                Console.WriteLine("User has not loged in");
            }
        }
        public void GoToTMPage(IWebDriver driver)
        {
         try 
            {
                //Navigate to Time & Material module
                IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationDropdown.Click();
            }
         catch(Exception exception)
            {
                Assert.Fail("Turnup portal not displayed",exception.Message);
            }
               
                IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
                tmOption.Click();
                Thread.Sleep(3000);
            
          
           
        }
    }
}
