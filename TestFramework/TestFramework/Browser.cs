﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
       static IWebDriver webDriver = new FirefoxDriver();

        public static string Title
        {
            get {return webDriver.Title; }
        }

        public static void Goto (string url)
        {
            webDriver.Url = url;
        }
    }
}