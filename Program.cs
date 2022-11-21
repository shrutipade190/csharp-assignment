using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Shruti
{
    public class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radiobutton;
        //static IwebElement checkbox;
        private static IWebElement Checkbox;
        private static string store;

        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            excerise();
            exercisetwo();
            exercisethree();
            excercisefour();
            exercisefourone();
            exercisefourtwo();
            excercisefive();
            excerisesix();
            exceriseseven();
            exceriseEight();
            excerisenine();


        }

        public static void exercise()
        {
            throw new NotImplementedException();

        }

        public static void excerise()
        {
            string[] option = { "1", "2", "3" };
            int i = 0;


            while (i < 3)
            {
                radiobutton = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[" + option[i]+"]/input"));
                radiobutton.Click();

                if (radiobutton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("the radio button" + (i + 1) + " is checked!");
                }
                else
                {
                    Console.WriteLine("this is one of the unchecked radio buttons!");
                }
                i++;
                Thread.Sleep(2000);

            }
        }
        public static void exercisetwo()
        {


            IWebElement drop = driver.FindElement(By.Id("autocomplete"));
            drop.SendKeys("united");
            IList<IWebElement> sbox = driver.FindElements(By.XPath("//div[@class='ui-menu-item-wrapper']"));



            foreach (var selement in sbox)
            {
                if (selement.Text.Contains("united states(usa)"))
                {
                    selement.Click();
                }
            }
        }

        public static void exercisethree()
        {
            IWebElement down = driver.FindElement(By.Id("dropdown-class-example"));

            for (int i = 2; i < 5; i++)

            {

                IWebElement down1 = driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]/option["+i+"]"));
                down1.Click();
                Thread.Sleep(2000);
                //down.Click();
                //Thread.Sleep(2000);
            }
        }
        public static void excercisefour()
        {

            //string url = "https://rahulshettyacademy.com/AutomationPractice/";
            //string Store = "1";
            //driver.Navigate().GoToUrl(url);

            String store = "1";




            IWebElement Checkbox1 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + store + "\"]"));
            Thread.Sleep(2000);
            Checkbox1.Click();
            Thread.Sleep(3000);
            Checkbox1.Click();

            Thread.Sleep(2000);
            Console.WriteLine(Checkbox1.GetAttribute("Value"));
            string option2 = "2";



            IWebElement Checkbox2 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option2 + "\"]")); Thread.Sleep(3000);
            Checkbox2.Click();
            Thread.Sleep(2000);
            Checkbox2.Click();

            Thread.Sleep(2000);
            Console.WriteLine(Checkbox2.GetAttribute("value"));




            string option3 = "3";



            IWebElement Checkbox3 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + store + "\"]"));
            Console.WriteLine(Checkbox3.GetAttribute("value"));



            Checkbox3.Click();
            Thread.Sleep(2000);
            Checkbox3.Click();
            Thread.Sleep(2000);

        }



        public static void exercisefourone()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement Checkall = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                Checkall.Click();
                Thread.Sleep(3000);

            }
        }



        public static void exercisefourtwo()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement deselect = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                deselect.Click();

            }
            Thread.Sleep(2000);

        }



        public static void excercisefive()
        {

            IWebElement data = driver.FindElement(By.XPath("//*[@id=\"openwindow\"]"));
            data.Click();
            Thread.Sleep(2000);


        }
        public static void excerisesix()


        {
            IWebElement opentabbtn = driver.FindElement(By.Id("opentab"));
            opentabbtn.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(3000);
        }

        public static void exceriseseven()
        {
            IWebElement alertbox = driver.FindElement(By.Id("opentab"));
            alertbox.SendKeys("shruti");
            Thread.Sleep(3000);

            IWebElement altbtn = driver.FindElement(By.Id("alertbtn"));
            altbtn.Click();
            Thread.Sleep(1000);
            var alt = driver.SwitchTo().Alert();
            alt.Accept();
        }
        public static void exceriseEight()

        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            Thread.Sleep(500);
            jse.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(1500);
            jse.ExecuteScript("document.querySelector('.tableFixHead').scrollBy(0,6000)");
            Thread.Sleep(1000);
        }

        public static void excerisenine()

        {
            Actions a = new Actions(driver);
            IWebElement mousehower = driver.FindElement(By.XPath("//*[@id=\"mousehover\"]"));
            a.MoveToElement(mousehower).Click().Build().Perform();
            Thread.Sleep(3000);

            IWebElement mouseclick = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]"));
            a.MoveToElement(mouseclick).Click().Build().Perform();
            Thread.Sleep(5000);


        }

    }
}

           
 

    
        
       
           

        







        
  

            

    




   

     
        
    

