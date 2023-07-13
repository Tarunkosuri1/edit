using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Pages;
using NUnit.Framework;
using SpecFlowProject2.Support;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class steps
    {
        private AppiumDriver<AndroidElement> driver;
        private Pages.Demo1 demo;
        private popuppage popups;
        private AllRound page;
        private Hearinnoise noise;
        private Outdoor outdoor;
        private Music music;
        public steps(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        /*[Given(@"Launch the app")]
        public void GivenLaunchTheApp()
        {
            throw new PendingStepException();
        }*/

        [When(@"when app opens click on  No,take me to demo mode")]
        public void WhenWhenAppOpensClickOnNoTakeMeToDemoMode()
        {
            demo = new Pages.Demo1(driver);
            popups = demo.demomode();
        }

        [Then(@"click on ok button or else click on yes button")]
        public void ThenClickOnOkButtonOrElseClickOnYesButton()
        {
            popups = new popuppage(driver);
            popups.popup();
        }
        [Then(@"verify if you are in allround page")]
        public void ThenVerifyIfYouAreInAllroundPage()
        {
            page = new AllRound(driver);
            string expectedTitle = "All-Around";
            string actualTitle = page.GetTitle();

            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");
        }
        [Then(@"click on split screen")]
        public void ThenClickOnSplitScreen()
        {
            page.clicksplit();
        }
        [Then(@"validate Right HI volume is '([^']*)'")]
        public void ThenValidateRightHIVolumeIs(string p0)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            page.slider1(p0);
        }
        [Then(@"validate Left HI volume is '([^']*)'")]
        public void ThenValidateLeftHIVolumeIs(string p0)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            page.slider2(p0);
        }

        [When(@"I set surroundings volume to (.*) on right volume bar of All-Around program")]
        public void WhenISetSurroundingsVolumeToOnRightVolumeBarOfAll_AroundProgram(string volume)
        {
            page.moveto3(volume);
        }
        [When(@"I set surroundings volume to '([^']*)' on left volume bar of All-Around program")]
        public void WhenISetSurroundingsVolumeToOnLeftVolumeBarOfAll_AroundProgram(string volume)
        {
            page.moveto10(volume);
        }

        [When(@"validate surroundings volume is '([^']*)' on right volume bar of All-Around program")]
        public void WhenValidateSurroundingsVolumeIsOnRightVolumeBarOfAll_AroundProgram(string p0)
        {
            page.validate3(p0);
        }
        [When(@"validate surroundings volume is '([^']*)' on left volume bar of All-Around program")]
        public void WhenValidateSurroundingsVolumeIsOnLeftVolumeBarOfAll_AroundProgram(string p0)
        {
            page.validate10(p0);
        }
        [When(@"I press merge surroundings volume on '([^']*)' program")]
        public void WhenIPressMergeSurroundingsVolumeOnProgram(string p0)
        {
            page.merg();
        }
        [When(@"validate merged surroundings volume bar is '([^']*)' on '([^']*)' program")]
        public void WhenValidateMergedSurroundingsVolumeBarIsOnProgram(string p0, string p1)
        {
            page.validatehi(p0);
        }
        [When(@"I set surroundings volume to '([^']*)' on '([^']*)' program")]
        public void WhenISetSurroundingsVolumeToOnProgram(string p0, string p1)
        {
            page.volume13(p0);
        }

        [Then(@"validate HI volume is '([^']*)'")]
        public void ThenValidateHIVolumeIs(string p0)
        {
            page.validate13(p0);
        }

        [When(@"I press '([^']*)' quick button on All-Around program")]
        public void WhenIPressQuickButtonOnAll_AroundProgram(string p0)
        {
            page.Speechclarity(p0);

        }
        [Then(@"validate '([^']*)' quick button is enabled on '([^']*)' program")]
        public void ThenValidateQuickButtonIsEnabledOnProgram(string p0, string p1)
        {
            page.validateSpeechclarity(p0);

        }

        [When(@"I press '([^']*)' quick button on '([^']*)' program")]
        public void WhenIPressQuickButtonOnProgram(string p0, string p1)

        {
            page.Noisefilter(p0);
        }
        [Then(@"validate '([^']*)' quick button is enabled on All-Around program")]
        public void ThenValidateQuickButtonIsEnabledOnAll_AroundProgram(string p0)
        {
            page.validatenoisefilter(p0);
        }
        [Then(@"validate '([^']*)' quick button is disabled on '([^']*)' program")]
        public void ThenValidateQuickButtonIsDisabledOnProgram(string p0, string p1)
        {
            page.disablespeechclarity(p0);
            //page.disablenoisefilter(p1);
        }
        [When(@"validate '([^']*)' quick button is disabled on '([^']*)' program")]
        public void WhenValidateQuickButtonIsDisabledOnProgram(string p0, string p1)
        {
            page.disablespeechclarity(p0);
        }

        /*[When(@"I press Sound Enhancer button on '([^']*)' program")]
        public void WhenIPressSoundEnhancerButtonOnProgram(string p0)
        {
            page = new AllRound(driver);
            page.Soundenhancer(p0);
            noise=new Hearinnoise(driver);
            noise.Soundenhancer(p0);
            
        }*/
        [When(@"I press Sound Enhancer button on '([^']*)' program")]
        public void WhenIPressSoundEnhancerButtonOnProgram(string p0)
        {
            programcards programPage;

            if (p0 == "All-Around")
            {
                programPage = new AllRound(driver);
            }
            else if (p0 == "Hear in noise")
            {
                programPage = new Hearinnoise(driver);
            }
            else if (p0 == "Outdoor")
            {
                programPage = new Outdoor(driver);
            }
            else
            {
                throw new Exception("Unsupported program name: " + p0);
            }

            programPage.Soundenhancer(p0);

        }

        [When(@"I set Bass gain to '([^']*)' on '([^']*)' Sound Enhancer")]
        public void WhenISetBassGainToOnSoundEnhancer(string p0, string p1)
        {
            page.Bass(p0);
        }
        [When(@"I set Middle gain to '([^']*)' on '([^']*)' Sound Enhancer")]
        public void WhenISetMiddleGainToOnSoundEnhancer(string p0, string p1)
        {
            page.middlegain(p0);
        }
        [When(@"I set Treble gain to '([^']*)' on '([^']*)' Sound Enhancer")]
        public void WhenISetTrebleGainToOnSoundEnhancer(string p0, string p1)
        {
            page.treblegain(p0);
        }
        [Then(@"validate Bass gain is '([^']*)' on '([^']*)' Sound Enhancer")]
        public void ThenValidateBassGainIsOnSoundEnhancer(string p0, string p1)
        {
            page.validatebass(p0);
        }
        [Then(@"validate Middle gain is '([^']*)' on '([^']*)' Sound Enhancer")]
        public void ThenValidateMiddleGainIsOnSoundEnhancer(string p0, string p1)
        {
            page.validatemiddlegain(p0);
        }
        [Then(@"validate Treble gain is '([^']*)' on '([^']*)' Sound Enhancer")]
        public void ThenValidateTrebleGainIsOnSoundEnhancer(string p0, string p1)
        {
            page.validatetreble(p0);
        }


        [When(@"I press Tinnitus Manager on '([^']*)' Sound Enhancer")]
        public void WhenIPressTinnitusManagerOnSoundEnhancer(string p0)
        {
            programcards programPage;

            switch (p0)
            {
                case "All-Around":
                    programPage = new AllRound(driver);
                    programPage.tinnitus(p0);
                    break;
                case "Hear in noise":
                    programPage = new Hearinnoise(driver);
                    programPage.tinnitus(p0);
                    break;
                default:
                    throw new Exception("Unsupported program name: " + p0);
            }
        }





        [When(@"I press Nature sounds button '([^']*)' on '([^']*)' Tinnitus Manager")]
        public void WhenIPressNatureSoundsButtonOnTinnitusManager(string p0, string p1)
        {
            page.waves(p0, p1);
        }
        [When(@"I press the exit button on '([^']*)' Sound Enhancer")]
        public void WhenIPressTheExitButtonOnSoundEnhancer(string p0)
        {
            programcards programPage;

            switch (p0.ToUpper())
            {
                case "ALL-AROUND":
                    programPage = new AllRound(driver);
                    programPage.Exit(p0);
                    break;
                case "HEAR IN NOISE":
                    programPage = new Hearinnoise(driver);
                    programPage.Exit(p0);
                    break;
                case "OUTDOOR":
                    programPage = new Hearinnoise(driver);
                    programPage.Exit(p0);
                    break;
            }
        }
        [When(@"I swipe left to '([^']*)' program from current program")]
        public void WhenISwipeLeftToProgramFromCurrentProgram(string p0)
        {


            programcards programPage;

            switch (p0.ToUpper())
            {
                case "HEAR IN NOISE":
                    programPage = new AllRound(driver);
                    programPage.swipe(p0);
                    break;
                case "OUTDOOR":
                    programPage = new Hearinnoise(driver);
                    programPage.swipe(p0);
                    break;
                case "MUSIC":
                    programPage = new Hearinnoise(driver);
                    programPage.swipe(p0);
                    break;


            }


        }


        /* [Then(@"validate program card is '([^']*)'")]
         public void ThenValidateProgramCardIs(string p0)
         {
             noise = new Hearinnoise(driver);
             string expectedTitle = "Hear in noise";
             string actualTitle = noise.getTitle();
             Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");
         }*/

        [When(@"I press white noise button '([^']*)' on '([^']*)' Tinnitus Manager")]
        public void WhenIPressWhiteNoiseButtonOnTinnitusManager(string p0, string p1)
        {
            noise = new Hearinnoise(driver);
            noise.whitenoise(p0);
        }

        [When(@"I press '([^']*)' button on All-Around Tinnitus Manager")]
        public void WhenIPressButtonOnAll_AroundTinnitusManager(string reset)
        {
            noise.Reset(reset);
        }
        [When(@"validate program card is '([^']*)'")]
        public void WhenValidateProgramCardIs(string p0)
        {
            switch (p0.ToUpper())
            {
                case "Music":
                    music = new Music(driver);
                    string expectedMusicTitle = "Music";
                    string actualMusicTitle = music.Title();
                    Assert.AreEqual(expectedMusicTitle, actualMusicTitle, "Title does not match");
                    break;

                case "Outdoor":
                    outdoor = new Outdoor(driver);
                    string expectedOutdoorTitle = "outdoor";
                    string actualOutdoorTitle = outdoor.Title();
                    Assert.AreEqual(expectedOutdoorTitle, actualOutdoorTitle, "Title does not match");
                    break;

                case "Hear in Noise":
                    noise = new Hearinnoise(driver);
                    string expectedNoiseTitle = "Hear in Noise";
                    string actualNoiseTitle = noise.Title();
                    Assert.AreEqual(expectedNoiseTitle, actualNoiseTitle, "Title does not match");
                    break;

                case "All-Around":
                    page = new AllRound(driver);
                    string expectedallaroundTitle = "All-Around";
                    string actualallaroundTitle = page.Title();
                    Assert.AreEqual(expectedallaroundTitle, actualallaroundTitle, "Title does not match");
                    break;


            }
        }
        [When(@"I press '([^']*)' program on the top ribbon bar")]
        public void WhenIPressProgramOnTheTopRibbonBar(string p0)
        {
            switch (p0.ToUpper())
            {
                case "MUSIC":
                    music = new Music(driver);
                    music.musicclick(p0);
                    break;
                case "OUTDOOR":
                    outdoor = new Outdoor(driver);
                    outdoor.outdoorclick(p0);
                    break;
                case "HEAR IN NOISE":
                    noise = new Hearinnoise(driver);
                    noise.hearinnoiseclick(p0);
                    break;
                case "ALL-AROUND":
                    page = new AllRound(driver);
                    page.allaroundclick(p0);
                    break;

            }
        }
        [When(@"I drag Wind Noise Reduction to '(.*)' on '(.*)' Sound Enhancer")]
        public void WhenIDragWindNoiseReductionToOnSoundEnhancer(string strong0, string outdoor1)
        {
            outdoor = new Outdoor(driver);
            outdoor.movetostrong(strong0);
        }

        [Then(@"validate HI PNR value is '(.*)'")]
        public void ThenValidateHIPNRValueIs(string strong0)
        {
            outdoor.validatemovetostrong(strong0);
        }
        [When(@"I press Program overview button on topribbonbar")]
        public void WhenIPressProgramOverviewButtonOnTopribbonbar()
        {
            page.Programoverview();
        }
        [When(@"I press '([^']*)' program on Program overview")]
        public void WhenIPressProgramOnProgramOverview(string p0)
        {
            switch (p0.ToUpper())
            {
                case "HEAR IN NOISE":
                    noise = new Hearinnoise(driver);
                    noise.hearinnoisepoclick(p0);
                    break;

                case "OUTDOOR":
                    outdoor = new Outdoor(driver);
                    outdoor.outdoorpoclick(p0);
                    break;
                case "MUSIC":
                    music = new Music(driver);
                    music.musicpoclick(p0);
                    break;
                case "ALLAROUND":
                    page = new AllRound(driver);
                    page.allroundpoclick(p0);
                    break;
            }

        }
        [When(@"I press the '([^']*)' button on Program overview")]
        public void WhenIPressTheButtonOnProgramOverview(string close)
        {
            page.poexit(close);
        }
        [When(@"I press menu item '([^']*)' on bottom ribbon bar")]
        public void WhenIPressMenuItemOnBottomRibbonBar(string p0)
        {
            AllRound select;
            if (p0 == "My ReSound")
            {
                select = new AllRound(driver);
                select.Myresound(p0);
            }
            else if (p0 == "More")
            {
                select = new AllRound(driver);
                select.more(p0);
            }
            
        }

        [When(@"I press '([^']*)' on My ReSound")]
        public void WhenIPressOnMyReSound(string p0)
        {
            AllRound click;

            if (p0 == "Learn about the app")
            {
                click = new AllRound(driver);
                click.learnaboutapp(p0);
            }
            else if (p0 == "Guiding tips")
            {
                click = new AllRound(driver);
                click.Guidingtips(p0);
            }
           
         
        }
        
           
        

        [When(@"I press '([^']*)' on Learn about the app")]
        public void WhenIPressOnLearnAboutTheApp(string p0)
        {
            page.Volumecontrol(p0);
        }
        [When(@"I swipe '([^']*)' to '([^']*)' page on Learn about the app")]
        public void WhenISwipeToPageOnLearnAboutTheApp(string direction, string page)
        {
            AllRound SWIPE = new AllRound(driver);

            if (direction == "left")
            {
                if (page == "2 / 3")
                {
                    SWIPE.Volumecontrolswipe("2/3");
                }
                else if (page == "3 / 3")
                {
                    SWIPE.Volumecontrolswipe1("3/3");
                }
            }
        }
        [Then(@"validate '([^']*)' animation is shown on Volume control")]
        public void ThenValidateAnimationIsShownOnVolumeControl(string p0)
        {
            if (p0 == "Left and right volume")
            {
                page.verifyvoicecontrolswipe(p0);
            }
            else if (p0 == "Mute")
            {
                page.verifyvoicecontrolswipe1(p0);
            }
        }


        [When(@"I close on Learn about the app and back to My Resound page")]
        public void WhenICloseOnLearnAboutTheAppAndBackToMyResoundPage()
        {
            page.Close();
            page.Back();
        }
        [When(@"I press '([^']*)' on '([^']*)' dialog")]
        public void WhenIPressOnDialog(string p0, string p1)
        {
            popups.Guidingtips(p0);
        }

        [Then(@"validate title is '([^']*)' on Guiding tips page")]
        public void ThenValidateTitleIsOnGuidingTipsPage(string p0)
        {
            page.ValidateGuidingtips(p0);
        }
        [When(@"I press '([^']*)' on Guiding tips")]
        public void WhenIPressOnGuidingTips(string p0)
        {
            if (p0 == "Noise filter")
            {
                page.guidingtipsnoise(p0);
            }
            else if (p0 == "Music program")
            {
                page.guidingtipsmusic(p0);
            }
            
          
        }
        [When(@"I press Got it on '([^']*)' nudging dialog")]
        public void WhenIPressGotItOnNudgingDialog(string p0)
        {
            popups.Button(p0);
        }
        [When(@"I press '([^']*)' on bottom ribbon bar and back to '([^']*)' on My Resound")]
        public void WhenIPressOnBottomRibbonBarAndBackToOnMyResound(string p0, string p1)
        {
            page.Myresound(p0);
        }
        [Then(@"validate '([^']*)' button enabled on '([^']*)' nudging dialog")]
        public void ThenValidateButtonEnabledOnNudgingDialog(string p0, string p1)
        {
            popups.validategotit(p0);
            popups.validateBacktotips(p0);
        }

        [Then(@"validate '([^']*)' switch is '([^']*)'")]
        public void ThenValidateSwitchIs(string p0, string p1)
        {
            if (p0 == "on")
            {
                page.autoactivate(p1);
            }
            else if (p0 == "off")
            {
                page.autoActivate(p1);
            }
        }
        



            [When(@"I press '([^']*)' switch on More menu")]
        public void WhenIPressSwitchOnMoreMenu(string p0)
        {
            page.pressautoactivate(p0);
        }
       
           
       

        [When(@"I press more menu item '([^']*)'")]
        public void WhenIPressMoreMenuItem(string p0)
        {
            if (p0 == "About")
            {
                page.about(p0);
            }
            else if (p0 == "Legal information")
            {
                page.Legalinformation(p0);
            }
           
        }
        [Then(@"validate page title is displayed on About page")]
        public void ThenValidatePageTitleIsDisplayedOnAboutPage()
        {
            string expectedTitle = "About";
            string actualTitle = page.validateabouttitle();

            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");
        }
        [When(@"I press back from '([^']*)' page")]
        public void WhenIPressBackFromPage(string about)
        {
            page.Back1();
        }

    }
}      
            

       
    

 

