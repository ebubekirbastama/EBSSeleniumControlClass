![ebubekirbastama](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEh8ymdTpUeS7G-HTyk4IDI-K14BTbG2yPFRMtmerLZXlj3klF4hORy-YvJEuJfKlAvqS9U0slrfyMpc8yobWD9KWr2u8TPVqYFNnYzOoyKxzh_mU8heekajb0iBCvGdxrcN2i4uTe11niLY6Xext8gc6-xhVvmQ8Q4AFDJHnMFQFcvse2TWtjklLSXy/s4000/rm371-a08.webp)

# EBSSeleniumControlClass
With this class, you will be able to do many operations by typing the method name without searching.

EbsElemntCretedControl() method use:
<hr>
<h3>Example Code:</h3>

<ul class="container float">
<h4>JavascriptİSlemleri<h4/>
<li>EBSSeleniumControl.JavascriptİSlemleri.EBSJavaScriptScrollDown(drv,0,9999); </li>

<h4>Kontrolİslemleri<h4/>
<li>EBSSeleniumControl.Kontrolİslemleri.EbsElemntCretedControl(3000, "//*[@class='post-title entry-title']", drv);</li>

<h4>Optionsİslemleri<h4/>
<li>EBSSeleniumControl.Optionsİslemleri.EbsProfileFolderLoad("");</li>
<li>EBSSeleniumControl.Optionsİslemleri.EbsPageLoadStrategy("None");</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsİnfoBarHide();</li>
<li>EBSSeleniumControl.Optionsİslemleri.EbsExtentionLoad(Application.StartupPath + "//ebs.crx");</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsDevtoolsOpen();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsChroumeConsoleHide();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsWebbrowserHide();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsExtentionProxyCoonect("192.168.1.1","8080", Application.StartupPath + "//EBSProxy.crx");</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebseklProxyCoonect("192.168.1.1","8080");</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsincognitoMode();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsisolation();</li>

<h4>Mouse İslemleri<h4/>
<li>EBSSeleniumControl.Mouseİslemleri.EBSDoubleClick(drv, "/*[@name='estiyakclass']"); </li>
<li>EBSSeleniumControl.Mouseİslemleri.EBSDragAndDrop(drv, "//div[@id='dargıd']", "//button[@id='droputbtn']"); </li>
<li>EBSSeleniumControl.Mouseİslemleri.EBSClickAndHold(drv, "//*[@id='ebubekirclass']"); </li>
<li>EBSSeleniumControl.Mouseİslemleri.EBSMouseClick(drv,"//*[@class='ebs']"); </li>
<li>EBSSeleniumControl.Mouseİslemleri.EBSContextClick(drv); </li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsCloudFlareBypass();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsUserAgentChange();</li>
<li>EBSSeleniumControl.Optionsİslemleri.ebsGoogleMailLogin();</li>
</ul>
  
  <h4>ExecuteCdpCommand İslemleri<h4/>
<li>EBSSeleniumControl.ExecuteCdpCommandİslemleri.EBSExecuteCdpUserAgent(drv,"", "uk-UA");</li>
<li>EBSSeleniumControl.ExecuteCdpCommandİslemleri.EBSExecuteCdpCommandMobile(drv);</li>

</ul>
  
<hr>
<h2> With this code you will avoid being stuck in "no such item" you will be saved </h2>

Not:
<ul class="container float">
  <li> More methods will be added in the future</li>
  <li> This class is prepared for Selenium 4 and above versions</li>
  <li> In order to use this class, you need to Install Selenium in your Project</li>
  <li> Don't forget to add EBS Selenium Control.srvs and EBSSelenium Control.op to the "ChromeDriver" you defined while using Options, or you will get an error.</li>
</ul>

