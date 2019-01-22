using System.Configuration;

namespace PFW.SchrodersCom.TA.Setup
{
    public class TestConfiguration
    {

        public string SelectedEnvironment()
        {  
            return ConfigurationManager.AppSettings["Environment"];
        }

        public string SelectedBrowser()
        {
            return ConfigurationManager.AppSettings["Browser"];
        }

        public string SelectedHeadlessMode()
        {
            return ConfigurationManager.AppSettings["HeadlessMode"];
        }


    }
}
