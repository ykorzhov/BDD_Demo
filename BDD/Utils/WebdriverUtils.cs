using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Utils
{
    public class WebdriverUtils
    {
        public static WebDriver driver;

        public static WebDriver getInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        //ця реалізація не є Thread safe 

    }
}
