using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium4EgitimSeti
{
    internal class EBSSeleniumControl
    {
        public static ChromeOptions op = new ChromeOptions();
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
                    Thread.Sleep(waiting_time);
                    goto ERROR1;
                }
            }

        }
        public static void EbsElemntCretedControl(int waiting_time, string Xpath, ChromeDriver drv)
        {
            EBSElemntCretedControl(waiting_time, Xpath, drv);
        }
        private static ChromeOptions EBSPageLoadStrategy(string PageLoadStrategystring = "None")
        {
            if (PageLoadStrategystring == "Default")
            {
                op.PageLoadStrategy = PageLoadStrategy.Default;

            }
            else if (PageLoadStrategystring == "Normal")
            {
                op.PageLoadStrategy = PageLoadStrategy.Normal;
            }
            else if (PageLoadStrategystring == "Eager")
            {
                op.PageLoadStrategy = PageLoadStrategy.Eager;
            }
            else if (PageLoadStrategystring == "None")
            {
                op.PageLoadStrategy = PageLoadStrategy.None;
            }
            return op;
        }
        /// <summary>
        /// ChromeOptions parametrelerinden biri olan PageLoadStrategy 4 adet değer alır(Default,Normal,Eager,None) normal tamamlamak  Varsayılan olarak kullanılır, tüm kaynakların indirilmesini bekler, eager etkileşimli DOM erişimi hazır, ancak resimler gibi diğer kaynaklar hala yükleniyor olabilir,none Hiç WebDriver'ı hiç engellemez
        /// </summary>
        /// <param name="PageLoadStrategystring"></param>
        public static ChromeOptions EbsPageLoadStrategy(string PageLoadStrategystring)
        {
            return EBSPageLoadStrategy(PageLoadStrategystring);
        }
        /// <summary>
        /// Bu metod ile sadece eklenti yolunu veriyorsunuz...
        /// </summary>
        /// <param name="ExtentionYol"></param>
        /// <returns></returns>
        private static ChromeOptions EBSExtentionLoad(params string[] ExtentionYol)
        {
            op.AddExtensions(ExtentionYol);
            return op;
        }
        public static ChromeOptions EbsExtentionLoad(params string[] ExtentionYol)
        {
            EBSExtentionLoad(ExtentionYol);
            return op;
        }
    }
}
