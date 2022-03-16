using SeleniumTask;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void SetUp()
        {
            Setup.Initialize();
        }

        [AfterScenario]
        public static void TearDown()
        {
            Setup.CleanUp();
        }
    }
}