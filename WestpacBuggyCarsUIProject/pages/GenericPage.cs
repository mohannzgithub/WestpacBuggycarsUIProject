﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WestpacBuggyCarsUIProject.DataModel;

namespace WestpacBuggyCarsUIProject.pages
{
    public class GenericPage : BasePage
    {
        protected ContextObject contextObj;
        public GenericPage(ContextObject _contextobj) : base(_contextobj.Driver)
        {
            contextObj = _contextobj;
            contextObj.Driver.SwitchTo().DefaultContent();
        }

        public IWebElement WaitForElement(By locator, double timeout)
        {
            IWebElement elm;
            WebDriverWait wait = new WebDriverWait(contextObj.Driver, TimeSpan.FromSeconds(timeout));
            new WebDriverWait(contextObj.Driver, new TimeSpan(0, 0, 360)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            elm = wait.Until(x => contextObj.Driver.FindElement(locator));
            wait.Until(d =>
            {
                if (elm != null)
                {
                    return elm.Displayed;

                }
                else return false;
            });

            return elm;
        }

        public void ClickElement(By locator)
        {
            IWebElement elm;
            WebDriverWait wait = new WebDriverWait(contextObj.Driver, TimeSpan.FromSeconds(60));
            elm = wait.Until(x => contextObj.Driver.FindElement(locator));
            elm.Click();

        }
        public IWebElement GetElement(By elem)
        {
            return contextObj.Driver.FindElement(elem);
        }

    }
}
