using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tester
{
    public class Porgram{
    public static void Main()
    {
        var driver = new ChromeDriver();    
            driver.Navigate().GoToUrl("");
        var pageTitle = driver.Title;
         
        var inputUsername = driver.FindElement(By.Name("input-username"))
                                  .FindElement(By.Name("input-username"));
            inputUsername.SendKeys("");

        var inputPassword = driver.FindElement(By.Name("input-password"))
                                   .FindElement(By.Name("input-password"));
            inputPassword.SendKeys("");
         
        var btnLogin =  driver.FindElement(By.ClassName("btn-login"));
            btnLogin.Click();
            //driver.Quit();
         Console.WriteLine(pageTitle);
        
      
    }
  }
}
