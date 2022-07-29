using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Selenium4EgitimSeti
{
    internal class EBSSeleniumControl
    {
        /// <summary>
        /// Bu class By& Ebubekir Bastama Tarafın'dan geliştirlmiştir.
        /// </summary>
        /// 
        #region Değişkenler
        public static ChromeOptions op = new ChromeOptions();
        public static ChromeDriverService srvs;
        private static string WindowsProfilePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Google\\Chrome\\User Data\\";
        private static string infobarhide = "enable-automation";
        private static string Devtoolsopenop = "--auto-open-devtools-for-tabs";
        private static string WebbrowserHeadless = "Headless";
        #endregion

        internal class JavascriptİSlemleri
        {
            /// <summary>
            /// Bu metod ile javascript kullanılarak sayfayı verdiğimiz değer içerisinde aşağı indiriyoruz.
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="x"></param>
            /// <param name="y"></param>
            #region Scroll Aşağı İndirme
            public static void EBSJavaScriptScrollDown(ChromeDriver drv, int x=0, int y=100)
            {
                drv.ExecuteScript("window.scrollBy('" + x + "','" + y + "')");
            }
            #endregion
        }
        internal class Kontrolİslemleri
        {
            #region Element Kontrol Metodu
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
            #endregion
        }
        internal class Optionsİslemleri
        {
            #region Sayfa Yükleme Durumları
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
            #endregion
            #region Eklenti Yükleme
            private static ChromeOptions EBSExtentionLoad(params string[] ExtentionYol)
            {
                op.AddExtensions(ExtentionYol);
                return op;
            }
            /// <summary>
            /// Bu metod ile sadece eklenti yolunu veriyorsunuz...
            /// </summary>
            /// <param name="ExtentionYol"></param>
            /// <returns></returns>
            public static ChromeOptions EbsExtentionLoad(params string[] ExtentionYol)
            {
                EBSExtentionLoad(ExtentionYol);
                return op;
            }
            #endregion
            #region Profil Yolu
            private static ChromeOptions EBSProfileFolderLoad(string ProfilePath)
            {
                op.AddArgument("--user-data-dir=" + ProfilePath);
                return op;
            }
            /// <summary>
            /// Bu metod size bilgisayaraınızda bulunan tarayıcı özelliklerini kullanmanızı sağlar eğer boş veri yollarsanız ("") Default Profili seçer Fakat siz profil dosyasını başka bir yerden çekiyorsanız yolu belirtebilirsiniz.
            /// </summary>
            /// <param name="ProfilePath"></param>
            /// <returns></returns>
            public static ChromeOptions EbsProfileFolderLoad(string ProfilePath)
            {
                if (ProfilePath == "")
                {
                    EbsProfileFolderLoad(WindowsProfilePath);
                }
                else
                {
                    EBSProfileFolderLoad(ProfilePath);
                }

                return op;
            }
            #endregion
            #region İnfo Bar Gizleme
            private static ChromeOptions EBSİnfoBarHide()
            {
                op.AddExcludedArgument(infobarhide);
                return op;
            }
            /// <summary>
            ///  Bu metodu kullandığınızda info bar gizlecenektir.
            /// </summary>
            /// <param name="ProfilePath"></param>
            /// <returns></returns>
            public static ChromeOptions ebsİnfoBarHide()
            {
                EBSİnfoBarHide();

                return op;
            }
            #endregion
            #region Webbrowser Devtools açma 
            private static ChromeOptions EBSDevtoolsOpen()
            {
                op.AddArgument(Devtoolsopenop);
                return op;
            }
            /// <summary>
            /// Bu metod ile F12 ile açtığımız Console alanını yani Devtools alanını otomatik açtırabiliriz.
            /// </summary>
            /// <returns></returns>
            public static ChromeOptions ebsDevtoolsOpen()
            {
                EBSDevtoolsOpen();
                return op;
            }
            #endregion
            #region ChroumeDriver Console Gizleme 
            private static ChromeDriverService EBSChroumeConsoleHide()
            {
                srvs.HideCommandPromptWindow = false;
                return srvs;
            }
            /// <summary>
            /// Bu metod ile program başlarken açılan console alanını gizliyoruz. 
            /// </summary>
            /// <returns></returns>
            public static ChromeDriverService ebsChroumeConsoleHide()
            {
                EBSChroumeConsoleHide();
                return srvs;
            }
            #endregion
            #region Selenium Browser Gizleme 
            private static ChromeOptions EBSWebbrowserHide()
            {
                op.AddArgument(WebbrowserHeadless);
                return op;
            }
            /// <summary>
            /// Bu metod ile ilgili açılan Selenium Web Tarayıcısını gizliyoruz.
            /// </summary>
            /// <returns></returns>
            public static ChromeOptions ebsWebbrowserHide()
            {
                EBSWebbrowserHide();
                return op;
            }
            #endregion
        }
        internal class Mouseİslemleri
        {
            #region Mous Tıklama
            /// <summary>
            /// Bu metod ile Mous tıklama İşlemi Yapıyorsunuz sadece yapmanız gereken tıklamak istediğiniz elementin Xpath değeri ve oluşturduğunuz ChromeDriver vermektir.
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="Xpath"></param>
            public static void EBSMouseClick(ChromeDriver drv, string Xpath)
            {
                Actions ac = new Actions(drv);
                ac.Click(drv.FindElement(By.XPath(Xpath))).Release().Build().Perform();
            }
            #endregion
            #region Menü Mous Tıklama
            /// <summary>
            /// Bu metod ile bir sayfaya mouse tıklaması ile menü açılma işlemini yapıyoruz Xpath vermezseniz default olarak //html değer alır...
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="Xpath"></param>
            public static void EBSContextClick(ChromeDriver drv, string Xpath="//html")
            {
                Actions ac = new Actions(drv);
                ac.ContextClick(drv.FindElement(By.XPath(Xpath))).Release().Build().Perform();
            }
            #endregion
            #region Tıkla ve Beklet
            /// <summary>
            /// Bu metod ile Mous tıkla ve Bekletme işlemini yapıyoruz...
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="Xpath"></param>
            public static void EBSClickAndHold(ChromeDriver drv, string Xpath)
            {
                Actions ac = new Actions(drv);
                ac.ClickAndHold(drv.FindElement(By.XPath(Xpath))).Release().Build().Perform();
            }
            #endregion
            #region Çift Tıklama
            //Bu metod ile Mouse Cift Tıklama Yapıyoruz...
            public static void EBSDoubleClick(ChromeDriver drv, string Xpath)
            {
                Actions ac = new Actions(drv);
                ac.DoubleClick(drv.FindElement(By.XPath(Xpath))).Release().Build().Perform();
            }
            #endregion
            #region Sürükle ve Bırak
            /// <summary>
            /// Bu metod ile Mouse Sürükle ve Bırakma İşlemi Yapıyoruz SourceXpath="Kaynek Element" ,TargetXpath="Sürüklenecek element"
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="SourceXpath"></param>
            /// <param name="TargetXpath"></param>
            public static void EBSDragAndDrop(ChromeDriver drv, string SourceXpath, string TargetXpath)
            {
                Actions ac = new Actions(drv);
                ac.DragAndDrop(drv.FindElement(By.XPath(SourceXpath)), drv.FindElement(By.XPath(TargetXpath))).Release().Build().Perform();
            }
            #endregion

        }



    }
}
