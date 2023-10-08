using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Pages;
using SpecFlowProject1.Utilites;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"user logs into TurnUp Portal")]
        public void GivenUserLogsIntoTurnUpPortal()
        {
            //Open chrome browser
            driver = new ChromeDriver();
            //Loginpage page object initialization and definition
            loginPageObj.LoginActions(driver);

            //Homepage page object initialization and definition
            homePageObj.VerifySucssesLogin(driver);
        }

        [Given(@"user navigates to time and material page")]
        public void GivenUserNavigatesToTimeAndMaterialPage()
        {
            //Homepage page object initialization and definition

            homePageObj.GoToTMPage(driver);

        }

        [When(@"user creates a new time and material racord")]
        public void WhenUserCreatesANewTimeAndMaterialRacord()
        {
            //Create new time record
            tmPageObj.CreateTimeRecord(driver);

        }

        [Then(@"turnup portal should save the time and material record")]
        public void ThenTurnupPortalShouldSaveTheTimeAndMaterialRecord()
        {
            
            tmPageObj.AssertCreateTmRecord(driver);
        }

        [When(@"user edit an existing time and material racord")]
        public void WhenUserEditAnExistingTimeAndMaterialRacord()
        {
            //Edit time record
            tmPageObj.EditTimeRecord(driver);
        }

        [Then(@"turnup portal should save the existing time and material record")]
        public void ThenTurnupPortalShouldSaveTheExistingTimeAndMaterialRecord()
        {
            tmPageObj.AsserteEditTMRecord(driver);
        }

        [When(@"user delete an existing time and material racord")]
        public void WhenUserDeleteAnExistingTimeAndMaterialRacord()
        {
            //Delete time record
            tmPageObj.DeleteTimeRecord(driver);
        }

        [Then(@"The time and material record should delete from turnup portal")]
        public void ThenTheTimeAndMaterialRecordShouldDeleteFromTurnupPortal()
        {
            tmPageObj.AsserteDeleteTmRecord(driver);
        }

    }
}
