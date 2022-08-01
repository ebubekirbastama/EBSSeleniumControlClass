using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Selenium4EgitimSeti
{
    internal class EBSSeleniumControl
    {
        /// <summary>
        /// Bu class By& Ebubekir Bastama Tarafın'dan geliştirlmiştir. Bu gibi Yararlı metodların gelmesini istiyorsanız Bizlere sponsor olabilrisiniz.
        /// </summary>
        /// 

        #region ISO Language Code Table
        //af    | Afrikaans
        //af-ZA | Afrikaans(South Africa)
        //ar    | Arabic
        //ar-AE | Arabic(U.A.E.)
        //ar-BH | Arabic(Bahrain)
        //ar-DZ | Arabic(Algeria)
        //ar-EG | Arabic(Egypt)
        //ar-IQ | Arabic(Iraq)
        //ar-JO | Arabic(Jordan)
        //ar-KW | Arabic(Kuwait)
        //ar-LB | Arabic(Lebanon)
        //ar-LY | Arabic(Libya)
        //ar-MA | Arabic(Morocco)
        //ar-OM | Arabic(Oman)
        //ar-QA | Arabic(Qatar)
        //ar-SA | Arabic(Saudi Arabia)
        //ar-SY | Arabic(Syria)
        //ar-TN | Arabic(Tunisia)
        //ar-YE | Arabic(Yemen)
        //az    | Azeri(Latin)
        //az-AZ | Azeri(Latin) (Azerbaijan)
        //az-AZ | Azeri(Cyrillic) (Azerbaijan)
        //be    | Belarusian
        //be-BY | Belarusian(Belarus)
        //bg    | Bulgarian
        //bg-BG | Bulgarian(Bulgaria)
        //bs-BA | Bosnian(Bosnia and Herzegovina)
        //ca    | Catalan
        //ca-ES | Catalan(Spain)
        //cs    | Czech
        //cs-CZ | Czech(Czech Republic)
        //cy    | Welsh
        //cy-GB | Welsh(United Kingdom)
        //da    | Danish
        //da-DK | Danish(Denmark)
        //de    | German
        //de-AT | German(Austria)
        //de-CH | German(Switzerland)
        //de-DE | German(Germany)
        //de-LI | German(Liechtenstein)
        //de-LU | German(Luxembourg)
        //dv    | Divehi
        //dv-MV | Divehi(Maldives)
        //el    | Greek
        //el-GR | Greek(Greece)
        //en    | English
        //en-AU | English(Australia)
        //en-BZ | English(Belize)
        //en-CA | English(Canada)
        //en-CB | English(Caribbean)
        //en-GB | English(United Kingdom)
        //en-IE | English(Ireland)
        //en-JM | English(Jamaica)
        //en-NZ | English(New Zealand)
        //en-PH | English(Republic of the Philippines)
        //en-TT | English(Trinidad and Tobago)
        //en-US | English(United States)
        //en-ZA | English(South Africa)
        //en-ZW | English(Zimbabwe)
        //eo    | Esperanto
        //es    | Spanish
        //es-AR | Spanish(Argentina)
        //es-BO | Spanish(Bolivia)
        //es-CL | Spanish(Chile)
        //es-CO | Spanish(Colombia)
        //es-CR | Spanish(Costa Rica)
        //es-DO | Spanish(Dominican Republic)
        //es-EC | Spanish(Ecuador)
        //es-ES | Spanish(Castilian)
        //es-ES | Spanish(Spain)
        //es-GT | Spanish(Guatemala)
        //es-HN | Spanish(Honduras)
        //es-MX | Spanish(Mexico)
        //es-NI | Spanish(Nicaragua)
        //es-PA | Spanish(Panama)
        //es-PE | Spanish(Peru)
        //es-PR | Spanish(Puerto Rico)
        //es-PY | Spanish(Paraguay)
        //es-SV | Spanish(El Salvador)
        //es-UY | Spanish(Uruguay)
        //es-VE | Spanish(Venezuela)
        //et    | Estonian
        //et-EE | Estonian(Estonia)
        //eu    | Basque
        //eu-ES | Basque(Spain)
        //fa    | Farsi
        //fa-IR | Farsi(Iran)
        //fi    | Finnish
        //fi-FI | Finnish(Finland)
        //fo    | Faroese
        //fo-FO | Faroese(Faroe Islands)
        //fr    | French
        //fr-BE | French(Belgium)
        //fr-CA | French(Canada)
        //fr-CH | French(Switzerland)
        //fr-FR | French(France)
        //fr-LU | French(Luxembourg)
        //fr-MC | French(Principality of Monaco)
        //gl    | Galician
        //gl-ES | Galician(Spain)
        //gu    | Gujarati
        //gu-IN | Gujarati(India)
        //he    | Hebrew
        //he-IL | Hebrew(Israel)
        //hi    | Hindi
        //hi-IN | Hindi(India)
        //hr    | Croatian
        //hr-BA | Croatian(Bosnia and Herzegovina)
        //hr-HR | Croatian(Croatia)
        //hu    | Hungarian
        //hu-HU | Hungarian(Hungary)
        //hy    | Armenian
        //hy-AM | Armenian(Armenia)
        //id    | Indonesian
        //id-ID | Indonesian(Indonesia)
        //is 	| Icelandic
        //is-IS | Icelandic(Iceland)
        //it    | Italian
        //it-CH | Italian(Switzerland)
        //it-IT | Italian(Italy)
        //ja    | Japanese
        //ja-JP | Japanese(Japan)
        //ka    | Georgian
        //ka-GE | Georgian(Georgia)
        //kk    | Kazakh
        //kk-KZ | Kazakh(Kazakhstan)
        //kn    | Kannada
        //kn-IN | Kannada(India)
        //ko    | Korean
        //ko-KR | Korean(Korea)
        //kok   | Konkani
        //kok-IN| Konkani(India)
        //ky    | Kyrgyz
        //ky-KG | Kyrgyz(Kyrgyzstan)
        //lt    | Lithuanian
        //lt-LT | Lithuanian(Lithuania)
        //lv    | Latvian
        //lv-LV | Latvian(Latvia)
        //mi    | Maori
        //mi-NZ | Maori(New Zealand)
        //mk    | FYRO Macedonian
        //mk-MK | FYRO Macedonian(Former Yugoslav Republic of Macedonia)
        //mn    | Mongolian
        //mn-MN | Mongolian(Mongolia)
        //mr    | Marathi
        //mr-IN | Marathi(India)
        //ms    | Malay
        //ms-BN | Malay(Brunei Darussalam)
        //ms-MY | Malay(Malaysia)
        //mt    | Maltese
        //mt-MT | Maltese(Malta)
        //nb    | Norwegian(Bokm? l)
        //nb-NO | Norwegian(Bokm? l) (Norway)
        //nl    | Dutch
        //nl-BE | Dutch(Belgium)
        //nl-NL | Dutch(Netherlands)
        //nn-NO | Norwegian(Nynorsk) (Norway)
        //ns    | Northern Sotho
        //ns-ZA | Northern Sotho(South Africa)
        //pa    | Punjabi
        //pa-IN | Punjabi(India)
        //pl    | Polish
        //pl-PL | Polish(Poland)
        //ps    | Pashto
        //ps-AR | Pashto(Afghanistan)
        //pt    | Portuguese
        //pt-BR | Portuguese(Brazil)
        //pt-PT | Portuguese(Portugal)
        //qu    | Quechua
        //qu-BO | Quechua(Bolivia)
        //qu-EC | Quechua(Ecuador)
        //qu-PE | Quechua(Peru)
        //ro    | Romanian
        //ro-RO | Romanian(Romania)
        //ru    | Russian
        //ru-RU | Russian(Russia)
        //sa    | Sanskrit
        //sa-IN | Sanskrit(India)
        //se    | Sami(Northern)
        //se-FI | Sami(Northern) (Finland)
        //se-FI | Sami(Skolt) (Finland)
        //se-FI | Sami(Inari) (Finland)
        //se-NO | Sami(Northern) (Norway)
        //se-NO | Sami(Lule) (Norway)
        //se-NO | Sami(Southern) (Norway)
        //se-SE | Sami(Northern) (Sweden)
        //se-SE | Sami(Lule) (Sweden)
        //se-SE | Sami(Southern) (Sweden)
        //sk    | Slovak
        //sk-SK | Slovak(Slovakia)
        //sl    | Slovenian
        //sl-SI | Slovenian(Slovenia)
        //sq    | Albanian
        //sq-AL | Albanian(Albania)
        //sr-BA | Serbian(Latin) (Bosnia and Herzegovina)
        //sr-BA | Serbian(Cyrillic) (Bosnia and Herzegovina)
        //sr-SP | Serbian(Latin) (Serbia and Montenegro)
        //sr-SP | Serbian(Cyrillic) (Serbia and Montenegro)
        //sv    | Swedish
        //sv-FI | Swedish(Finland)
        //sv-SE | Swedish(Sweden)
        //sw    | Swahili
        //sw-KE | Swahili(Kenya)
        //syr   | Syriac
        //syr-SY| Syriac(Syria)
        //ta    | Tamil
        //ta-IN | Tamil(India)
        //te    | Telugu
        //te-IN | Telugu(India)
        //th    | Thai
        //th-TH | Thai(Thailand)
        //tl    | Tagalog
        //tl-PH | Tagalog(Philippines)
        //tn    | Tswana
        //tn-ZA | Tswana(South Africa)
        //tr    | Turkish
        //tr-TR | Turkish(Turkey)
        //tt    | Tatar
        //tt-RU | Tatar(Russia)
        //ts    | Tsonga
        //uk    | Ukrainian
        //uk-UA | Ukrainian(Ukraine)
        //ur    | Urdu
        //ur-PK | Urdu(Islamic Republic of Pakistan)
        //uz    | Uzbek(Latin)
        //uz-UZ | Uzbek(Latin) (Uzbekistan)
        //uz-UZ | Uzbek(Cyrillic) (Uzbekistan)
        //vi    | Vietnamese
        //vi-VN | Vietnamese(Viet Nam)
        //xh    | Xhosa
        //xh-ZA | Xhosa(South Africa)
        //zh    | Chinese
        //zh-CN | Chinese(S)
        //zh-HK | Chinese(Hong Kong)
        //zh-MO | Chinese(Macau)
        //zh-SG | Chinese(Singapore)
        //zh-TW | Chinese(T)
        //zu    | Zulu
        //zu-ZA | Zulu(South Africa)
        #endregion
        #region Değişkenler
        public static ChromeOptions op = new ChromeOptions();
        public static ChromeDriverService srvs;
        private static string WindowsProfilePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Google\\Chrome\\User Data\\";
        private static string infobarhide = "enable-automation";
        private static string Devtoolsopenop = "--auto-open-devtools-for-tabs";
        private static string WebbrowserHeadless = "Headless";
        private static string Proxyxpth = "--proxy-server=";
        private static string CloudFlareBypassxph = "disable-blink-features=AutomationControlled";
        private static string UserAgentxpth = "--user-agent=";
        private static string İncognitoMode = "--incognito";
        private static string İsolation = "--disable-site-isolation-trials";
        public static string[] Lanquagecode =
{
"af",
"af-ZA",
"ar",
"ar-AE",
"ar-BH",
"ar-DZ",
"ar-EG",
"ar-IQ",
"ar-JO",
"ar-KW",
"ar-LB",
"ar-LY",
"ar-MA",
"ar-OM",
"ar-QA",
"ar-SA",
"ar-SY",
"ar-TN",
"ar-YE",
"az",
"az-AZ",
"az-AZ",
"be",
"be-BY",
"bg",
"bg-BG",
"bs-BA",
"ca",
"ca-ES",
"cs",
"cs-CZ",
"cy",
"cy-GB",
"da",
"da-DK",
"de",
"de-AT",
"de-CH",
"de-DE",
"de-LI",
"de-LU",
"dv",
"dv-MV",
"el",
"el-GR",
"en",
"en-AU",
"en-BZ",
"en-CA",
"en-CB",
"en-GB",
"en-IE",
"en-JM",
"en-NZ",
"en-PH",
"en-TT",
"en-US",
"en-ZA",
"en-ZW",
"eo",
"es",
"es-AR",
"es-BO",
"es-CL",
"es-CO",
"es-CR",
"es-DO",
"es-EC",
"es-ES",
"es-ES",
"es-GT",
"es-HN",
"es-MX",
"es-NI",
"es-PA",
"es-PE",
"es-PR",
"es-PY",
"es-SV",
"es-UY",
"es-VE",
"et",
"et-EE",
"eu",
"eu-ES",
"fa",
"fa-IR",
"fi",
"fi-FI",
"fo",
"fo-FO",
"fr",
"fr-BE",
"fr-CA",
"fr-CH",
"fr-FR",
"fr-LU",
"fr-MC",
"gl",
"gl-ES",
"gu",
"gu-IN",
"he",
"he-IL",
"hi",
"hi-IN",
"hr",
"hr-BA",
"hr-HR",
"hu",
"hu-HU",
"hy",
"hy-AM",
"id",
"id-ID",
"is",
"is-IS",
"it",
"it-CH",
"it-IT",
"ja",
"ja-JP",
"ka",
"ka-GE",
"kk",
"kk-KZ",
"kn",
"kn-IN",
"ko",
"ko-KR",
"kok",
"kok-IN",
"ky",
"ky-KG",
"lt",
"lt-LT",
"lv",
"lv-LV",
"mi",
"mi-NZ",
"mk",
"mk-MK",
"mn",
"mn-MN",
"mr",
"mr-IN",
"ms",
"ms-BN",
"ms-MY",
"mt",
"mt-MT",
"nb",
"nb-NO",
"nl",
"nl-BE",
"nl-NL",
"nn-NO",
"ns",
"ns-ZA",
"pa",
"pa-IN",
"pl",
"pl-PL",
"ps",
"ps-AR",
"pt",
"pt-BR",
"pt-PT",
"qu",
"qu-BO",
"qu-EC",
"qu-PE",
"ro",
"ro-RO",
"ru",
"ru-RU",
"sa",
"sa-IN",
"se",
"se-FI",
"se-FI",
"se-FI",
"se-NO",
"se-NO",
"se-NO",
"se-SE",
"se-SE",
"se-SE",
"sk",
"sk-SK",
"sl",
"sl-SI",
"sq",
"sq-AL",
"sr-BA",
"sr-BA",
"sr-SP",
"sr-SP",
"sv",
"sv-FI",
"sv-SE",
"sw",
"sw-KE",
"syr",
"syr-SY",
"ta",
"ta-IN",
"te",
"te-IN",
"th",
"th-TH",
"tl",
"tl-PH",
"tn",
"tn-ZA",
"tr",
"tr-TR",
"tt",
"tt-RU",
"ts",
"uk",
"uk-UA",
"ur",
"ur-PK",
"uz",
"uz-UZ",
"uz-UZ",
"vi",
"vi-VN",
"xh",
"xh-ZA",
"zh",
"zh-CN",
"zh-HK",
"zh-MO",
"zh-SG",
"zh-TW",
"zu",
"zu-ZA",
        };
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
            public static void EBSJavaScriptScrollDown(ChromeDriver drv, int x = 0, int y = 100)
            {
                drv.ExecuteScript("window.scrollBy('" + x + "','" + y + "')");
            }
            #endregion
            #region Javascript yeni tab açma
            /// <summary>
            /// Bu metod ile javascript ile yeni sekme açıp siteye gidebilirsiniz...
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="url"></param>
            public static void EBSJavaScriptopennewtab(ChromeDriver drv, string url)
            {
                drv.ExecuteScript("window.open('" + url + "')");
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
            #region Proxy Bağlantısı
            private static ChromeOptions EBSProxyConnect(string ipadres, string port)
            {
                op.AddArgument(Proxyxpth + ipadres + port);
                return op;
            }
            /// <summary>
            /// Bu metod ile proxy'e kullanıcı adı ve şifre girecekseniz kullanın ve eklenti yolunu belirtiniz...
            /// </summary>
            /// <param name="ipadres"></param>
            /// <param name="port"></param>
            /// <param name="ExtentionYol"></param>
            /// <returns></returns>
            public static ChromeOptions ebsExtentionProxyCoonect(string ipadres, string port, string ExtentionYol)
            {

                EBSProxyConnect(ipadres, port);
                EbsExtentionLoad(ExtentionYol);

                return op;
            }
            /// <summary>
            /// Bu metodu kullanıcı adı ve şifresi olmayan proxy lerde kullanın...
            /// </summary>
            /// <param name="ipadres"></param>
            /// <param name="port"></param>
            /// <returns></returns>
            public static ChromeOptions ebseklProxyCoonect(string ipadres, string port)
            {

                EBSProxyConnect(ipadres, port);

                return op;
            }
            #endregion
            #region CloudFlareBypass Metodu
            private static ChromeOptions EBSCloudFlareBypass()
            {
                op.AddArgument(CloudFlareBypassxph);
                return op;
            }
            /// <summary>
            /// Bu metodu kullanırsanız CloudFlare Sistemi Bypass edip siteye ulaşabilirsiniz. javascript ile yeni sekmede siteyi açmayı unutmayın yoksa gene sorun verir site drv. örnek kod    drv.ExecuteScript("window.open('https://www.ebubekirbastama.com')");
            /// </summary>
            /// <returns></returns>
            public static ChromeOptions ebsCloudFlareBypass()
            {

                EBSCloudFlareBypass();
                return op;
            }
            #endregion
            #region User-Agent Değiştirme Metodu
            private static ChromeOptions EBSUserAgentChange(string EBSUserAgentString = "Mozilla/5.0 (Linux; Android 9; LM-X220) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Mobile Safari/537.36")
            {
                op.AddArgument(UserAgentxpth + EBSUserAgentString);
                return op;
            }
            /// <summary>
            /// Bu Metod ile Tarayıcının User Agent Verilerini Değiştirebilirsiniz. Eğer user agent vermezseniz android user-agent default olarak belirlenir...
            /// </summary>
            /// <param name="EBSUserAgentString"></param>
            /// <returns></returns>
            public static ChromeOptions ebsUserAgentChange(string EBSUserAgentString = "Mozilla/5.0 (Linux; Android 9; LM-X220) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Mobile Safari/537.36")
            {

                EBSUserAgentChange(EBSUserAgentString);
                return op;
            }
            #endregion
            #region Web Tarayıcıyı Gizli Modda Açma Metodu
            private static ChromeOptions EBSincognitoMode()
            {
                op.AddArgument(İncognitoMode);
                return op;
            }
            /// <summary>
            /// Bu metodu kullanırsanız web tarayıcısı Gizli modda açılacaktır...
            /// </summary>
            /// <returns></returns>
            public static ChromeOptions ebsincognitoMode()
            {

                EBSincognitoMode();
                return op;
            }
            #endregion
            #region Chroume EBSisolation Disable Etme Kodu
            private static ChromeOptions EBSisolation()
            {
                op.AddArgument(İsolation);
                return op;
            }

            public static ChromeOptions ebsisolation()
            {

                EBSisolation();
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
            public static void EBSContextClick(ChromeDriver drv, string Xpath = "//html")
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

        internal class ExecuteCdpCommandİslemleri
        {
            #region ExecuteCdpCommand ile mobile görünüm
            /// <summary>
            /// Bu metod ile ExecuteCdpCommand yardımı ile mobile tarayıcı haline getiriyoruz...
            /// </summary>
            /// <param name="drv"></param>
            public static void EBSExecuteCdpCommandMobile(ChromeDriver drv)
            {
                var kullanicilar = new Dictionary<string, object>();

                kullanicilar.Add("width", 600);
                kullanicilar.Add("height", 1000);
                kullanicilar.Add("mobile", true);
                kullanicilar.Add("deviceScaleFactor", 50);
                drv.ExecuteCdpCommand("Emulation.setDeviceMetricsOverride", kullanicilar);
            }
            #endregion

            #region ExecuteCdpCommand ile mobile görünüm
            /// <summary>
            /// Bu metod ile  tarayıcıda useragent,dil,platform gibi verileri değiştiriyoruz.
            /// </summary>
            /// <param name="drv"></param>
            /// <param name="platform"></param>
            /// <param name="acceptLanguage"></param>
            /// <param name="UserAgent"></param>
            public static void EBSExecuteCdpUserAgent(ChromeDriver drv, string platform = "Macintosh", string acceptLanguage = "tr-TR", string UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.122 Safari/537.36")
            {

                var kullanicilar = new Dictionary<string, object>();

                kullanicilar.Add("userAgent", UserAgent);
                kullanicilar.Add("acceptLanguage", acceptLanguage);
                kullanicilar.Add("platform", platform);


                var s = drv.ExecuteCdpCommand("Emulation.setUserAgentOverride", kullanicilar);
            }
            #endregion
        }


    }
}
