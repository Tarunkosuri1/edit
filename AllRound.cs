
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Appium.Interfaces;
using System.Drawing;
using SpecFlowProject2.Support;

namespace SpecFlowProject2.Pages
{
    public class AllRound : programcards//Define a class named "Outdoor" which inherits from the "programcards" class

    {
        private AppiumDriver<AndroidElement> driver;// Declare a private field named "driver" of type "AppiumDriver<AndroidElement>"

        public AllRound(AppiumDriver<AndroidElement> driver) : base(driver)// Define a constructor which has "AppiumDriver<AndroidElement>" parameter and calls the base class constructor
        {
            this.driver = driver;
        }
        By verify = By.Id("dk.resound.smart3d:id/card_title");
        By split = By.Id("dk.resound.smart3d:id/SplitImageView_bottom");
        By slide1 = By.XPath("(//android.widget.ImageView[@index='2'])[2]");
        By slide2 = By.XPath("(//android.view.ViewGroup[@index = '1'])[4]");
        By merge = By.XPath("//android.widget.ImageView[@content-desc=\"icon_split1_s\"]");
        By slider = By.Id("dk.resound.smart3d:id/seekBar_bottom");
        By speechclarity = By.XPath("//android.widget.TextView[@content-desc='SmartButtonAllAroundSpeechClarity']");
        By noisefilter = By.XPath("//android.widget.TextView[@content-desc=\'SmartButtonAllAroundNoiseFilter\']");
        By bass = By.XPath("(//android.view.View[@index='0'])[1]");
        By Middlegain = By.XPath("(//android.view.View[@index=0])[2]");
        By Treblegain = By.XPath("(//android.view.View[@index=0])[3]");
        By calmingwaves = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsCalmingWaves\"]");
        By breakingwaves = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsBreakingWaves\"]");
        By allaround = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");
        By programoverview = By.XPath("//android.widget.ImageView[@content-desc=\"ProgramOverviewDragButton\"]");
        By allaroundprogramoverview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");
        By programoverviewexit = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        By myresound = By.XPath("//android.widget.TextView[@content-desc=\"TabBarPersonalTitle\"]");
        By Learnaboutapp1 = By.XPath("//android.widget.TextView[@content-desc=\"MyResoundLearningMenuTitleApp\"]");
        By volumecontrol1 = By.XPath("//android.widget.TextView[@content-desc=\"HelpChapterTitleVolumeControls\"]");
        By volumecontrolswipe = By.XPath("(//android.widget.FrameLayout[@index='0'])[4]");
        By close = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        By volumecontrolswipe1 = By.XPath("(//android.widget.FrameLayout[@index='1'])[1]");
        By guidingtips = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        By validateguidingtips = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        By guidingtipsnoisefilter = By.XPath("(//android.widget.ImageView[@content-desc=\"icon_dot_nudge_default_s\"])[8]");
        By guidingtipsMusic = By.XPath("(//android.widget.ImageView[@content-desc=\"icon_dot_nudge_default_s\"])[4]");
        By back = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        By More = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_menu\"]");
        By Autoactivate = By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]");
        By About = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralAboutText\"]");
        By Aboutverify = By.XPath("(//android.widget.TextView[@content-desc=\"AboutHeaderTitle\"]");
        By legalinformation = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalInformationText\"]");

        public string GetTitle()//verify the title of the page
        {
            return driver.FindElement(verify).Text;
        }
        public void clicksplit()//it is used to split the volume into left and right hi
        {
            
            driver.FindElement(split).Click();
        }

        public void slider1(string value)//it is used to verify if the right hi is in 9
        {

             Actions actions = new Actions(driver);
             AndroidElement upperslide1 = driver.FindElement(slide1);
             actions.ClickAndHold(upperslide1).MoveByOffset(2, 0).Perform();
             string act_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
             Assert.AreEqual(act_value, value);
             actions.Release().Perform();
           
        }
        public void slider2(string values)//It is used to validate left hi is in 9
        {
            Actions actions = new Actions(driver);
            AndroidElement downslide2 = driver.FindElement(slide2);
            actions.ClickAndHold(downslide2).Perform();
            actions.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
            Assert.AreEqual(actual_value, values);
            actions.Release().Perform();
        }

        public void moveto3(string volume)//It is used to set right hi to 3
        {
            Actions action = new Actions(driver);
            AndroidElement slide3 = driver.FindElement(slide1);
            action.ClickAndHold(slide3).Perform();
            action.MoveByOffset(-325, 0).Release().Perform();
        }
        public void moveto10(String volume)//it is used to set left hi to 10
        {
            Actions action = new Actions(driver);
            AndroidElement slide4 = driver.FindElement(slide2);
            action.ClickAndHold(slide4).Perform();
            action.MoveByOffset(83, 0).Release().Perform();
        }

        public void validate3(string volume)//used to check if right hi is in 3
        {
            Actions action = new Actions(driver);
            AndroidElement slide3 = driver.FindElement(slide1);
            action.ClickAndHold(slide3).Perform();
            action.MoveByOffset(1, 0).Perform();
            string act_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
            Assert.AreEqual(act_value, volume);
            action.Release().Perform();
        }
        public void validate10(String volume)//used to check if left hi is in 10
        {
            Actions action = new Actions(driver);
            AndroidElement slide4 = driver.FindElement(slide2);
            action.ClickAndHold(slide4).Perform();
            action.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void merg()//used to merge the split 
        {
            driver.FindElement(merge).Click();
        }
        public void validatehi(string volume)//used to validate if the volume is 3 after merging
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).Perform();
            action.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void volume13(String volume)//used to set the volume to 13
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).MoveByOffset(670, 0).Perform();
        }
        public void validate13(String volume)//used to validate if the volume is in 13
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void Speechclarity(string p0)//used to click speech clarity
        {
            driver.FindElement(speechclarity).Click();
        }
        public void validateSpeechclarity(string p0)//used to validate if speech clarity is enabled
        {

            AndroidElement speech = driver.FindElement(speechclarity);
            bool isClicked = speech.Selected;

            Assert.IsTrue(isClicked, "speech clarity is enabled");


        }

        public void Noisefilter(string p0)//used to click noise filter
        {
            driver.FindElement(noisefilter).Click();
        }

        public void validatenoisefilter(string p0)//used to validate if noise filter is enabled
        {
            AndroidElement noise = driver.FindElement(noisefilter);

            bool isClicked = noise.Selected;

            Assert.IsTrue(isClicked, "noise filter is enabled");

        }
        public void disablespeechclarity(string p0)//used to check if speech clarity is disabled
        {
            AndroidElement speech = driver.FindElement(speechclarity);
            bool isClicked = !speech.Selected;

            Assert.IsTrue(isClicked, "speech clarity is disabled");
        }


        

        public void Bass(String p0)//used to set bass to 4
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement BASS = driver.FindElement(bass);

            touchAction.Press(90, 992)
                       .MoveTo(90, 714)
                       .Release()
                       .Perform();

        }
        public void middlegain(String p0)//used to set middle gain to -3
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement GAIN = driver.FindElement(Middlegain);
            touchAction.Press(450, 992)
                       .MoveTo(450, 1340)
                       .Release()
                       .Perform();

        }
        public void treblegain(String p0)//used to set treblegain to  5
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement TREBLE = driver.FindElement(Treblegain);
            touchAction.Press(810, 992)
                       .MoveTo(810, 684)
                       .Release()
                       .Perform();

        }
        public void validatebass(String bassgain)//used to validate if bass is 4
        {
            Actions action = new Actions(driver);
            AndroidElement BASS = driver.FindElement(bass);
            action.ClickAndHold(BASS).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, bassgain);
        }

        public void validatemiddlegain(String gain)//used to validate if middlegain is -3
        {

            Actions action = new Actions(driver);
            AndroidElement GAIN = driver.FindElement(Middlegain);
            action.ClickAndHold(GAIN).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, gain);
        }

        public void validatetreble(String treble)//to validate if treble is 5
        {
            Actions action = new Actions(driver);
            AndroidElement TREBLE = driver.FindElement(Treblegain);
            action.ClickAndHold(TREBLE).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, treble);
        }


        public void waves(string calm, string breaking)//used to click on calm and breaking wave
        {
            AndroidElement wave = driver.FindElement(calmingwaves);
            wave.Click();
            AndroidElement breakingwave = driver.FindElement(breakingwaves);
            breakingwave.Click();
        }

        public void allaroundclick(string p0)//used to click on allaround on topribbon
        {
            driver.FindElement(allaround).Click();
        }
        public void Programoverview()
        {
            driver.FindElement(programoverview).Click();
        }
        public void allroundpoclick(string p0)
        {
            driver.FindElement(allaroundprogramoverview).Click();
        }
        public void poexit(string p0)
        {
            driver.FindElement(programoverviewexit).Click();
        }
        public void Myresound(string p0)
        {
            driver.FindElement(myresound).Click();
        }
       public void learnaboutapp(string p0)
        {
            driver.FindElement(Learnaboutapp1).Click();  
        }
        public void Volumecontrol(string p0)
        {
            driver.FindElement(volumecontrol1).Click();
        }
        public void Volumecontrolswipe(string p1)
        {
            AndroidElement screenSize = driver.FindElement(volumecontrolswipe);
            int screenWidth = screenSize.Size.Width; 
            int screenHeight = screenSize.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction action = new TouchAction(driver);
            AndroidElement swipeleft = driver.FindElement(volumecontrolswipe);
            action.Press(screenWidth, y).MoveTo(endX, y).Release().Perform();
        }
        public void Volumecontrolswipe1(string p1)
        {
            AndroidElement screenSize = driver.FindElement(volumecontrolswipe1);
            int screenWidth = screenSize.Size.Width;
            int screenHeight = screenSize.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction action = new TouchAction(driver);
            AndroidElement swipeleft = driver.FindElement(volumecontrolswipe1);
            action.Press(screenWidth, y).MoveTo(endX, y).Release().Perform();
        }
        public void verifyvoicecontrolswipe(string p0)
        {
            string actualText =driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsSplitTitle\"]")).Text;
            Assert.AreEqual(actualText, p0);

        }
      
        public void verifyvoicecontrolswipe1(string p0)
        {
            string actualText = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsMuteTitle\"]")).Text;
            Assert.AreEqual(actualText, p0);

        }
        public void Close()
        {
            driver.FindElement(close).Click();
        }
        public void Back()
        {
            driver.FindElement(back).Click();
        }
      
       public void Guidingtips(string p0)
        {
            driver.FindElement(guidingtips).Click();
        }
        public void ValidateGuidingtips(string p0)
        {
            string actualText = driver.FindElement(validateguidingtips).Text;
            Assert.AreEqual(actualText, p0);
        }
        public void guidingtipsnoise(string p0)
        {
            driver.FindElement(guidingtipsnoisefilter).Click();
        }
        public void guidingtipsmusic(string p0)
        {
            driver.FindElement(guidingtipsMusic).Click();
        }
        public void more(string p0)
        {
            driver.FindElement(More).Click();
        }
        public void autoactivate(string p0)
        {
            bool actual_value = driver.FindElement(By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]")).GetAttribute("checked") == "True";
            Assert.IsTrue(actual_value, "The switch is not turned on.");
        }
        public void pressautoactivate(string p0)
        {
            driver.FindElement(Autoactivate).Click();
        }
        public void autoActivate(string p0)
        {
            bool actual_value = driver.FindElement(By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]")).GetAttribute("checked") == "false";
            Assert.IsTrue(actual_value, "The switch is  turned on.");
        }
        public void about(String p0)
        {
            driver.FindElement(About).Click();
        }
        public string validateabouttitle()
        {
           return driver.FindElement(Aboutverify).Text;
        }
        public void Back1()
        {
            driver.FindElement(back).Click();
        }
        public void Legalinformation(string p0)
        {
            driver.FindElement(legalinformation).Click();
        }
    }
}

    

