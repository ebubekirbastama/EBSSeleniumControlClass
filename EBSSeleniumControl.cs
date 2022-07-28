using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium4EgitimSeti
{
    internal class EBSSeleniumControl
    {
        private static void EBSElemntCretedControl(int waiting_time, string Xpath, ChromeDriver drv)
        {

        ERROR1: try
            {
                if (drv.FindElement(By.XPath(Xpath)).Displayed == true)
                {
                    if (drv.FindElement(By.XPath(Xpath)).Enabled == true)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("no such element") != -1)
                {
                    Thread.Sleep(2000);
                    goto ERROR1;
                }
            }

        }
        public static void EbsElemntCretedControl(int waiting_time, string Xpath, ChromeDriver drv)
        {
            EBSElemntCretedControl(waiting_time, Xpath, drv);
        }
    }
}
