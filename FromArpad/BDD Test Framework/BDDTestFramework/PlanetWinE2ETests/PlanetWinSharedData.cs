using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using PlanetWinE2ETests.PageObjects;
using TechTalk.SpecFlow;
using TestCommon;


namespace PlanetWinE2ETests
{
    public partial class PlanetWinSharedTestSteps : CommonStepMethods
    {
        // default Planet365 user credentials
        public static string Planet365DefaultUsername = "EPAM_QA_BUD_21";
        public static string Planet365DefaultPassword = "Arpito";

        // languages
        public static string EnglishLanguage = "English";
        public static string DutchLanguage = "Deutsch";
        public static string ItalianLanguage = "Italiano";
        public static string FrenchLanguage = "Français";
        public static string ArgentineLanguage = "Argentina";
        public static string BalcanLanguage = "Balkans";
        public static string RussianLanguage = "Български";
        public static string PolishLanguage = "Polski";
        public static string RomanianLanguage = "Română";
        public static string ShquipLanguage = "Shqip";
        public static string GermanLanguage = "Österreich";
        public static string ChineseLanguage = "Chinese";
        public static string TurkishLanguage = "Turkish";

        /* other user accounts on PlanetWin365 bookmaker, created with ISBETSADMIN tool
        "EPAM_QA_BUD_22", "Arpito"
        "EPAM_QA_BUD_24", "Arpito"
        */
    }
}
