using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Schroders.com_UI_TA.Steps
{

    [Binding]
    class UserFormSteps
    {


        [When(@"I start entering user form details like")]
        public void WhenIStartEnteringUserFormDetailsLike(Table table)
        {
            Console.WriteLine("I enter user details");
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            Console.WriteLine("I click submit button");
        }




    }
}
