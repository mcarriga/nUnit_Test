using NUnit.Framework;
using System;
using NUnit.Framework.Interfaces;

namespace nUnit_Example
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Assembly, AllowMultiple = true)]
    public class ZephyrTestAttribute : Attribute, ITestAction
    {
        private string _ZypherTestId;

        public ZephyrTestAttribute(string ZypherTestId) {
            _ZypherTestId = ZypherTestId;
        }
        public ActionTargets Targets
        {
            get
            {
                return ActionTargets.Test;
            }
        }

        public void AfterTest(ITest test)
        {
            ZephyrFixtureAttribute obj = test.Fixture as ZephyrFixtureAttribute;
            if (test.IsSuite == false)
            {
                Console.WriteLine(_ZypherTestId);
                System.Diagnostics.Debug.WriteLine(_ZypherTestId);
            }
            
            //System.Diagnostics.Debug.WriteLine(TestContext.CurrentContext.Result.Outcome);
            switch (TestContext.CurrentContext.Result.Outcome.Status) {
                case TestStatus.Failed :
                    System.Diagnostics.Debug.WriteLine(_ZypherTestId + " Failed "+obj.getJiraUrl());
                    break;
                case TestStatus.Passed:
                    System.Diagnostics.Debug.WriteLine(_ZypherTestId + " Passed " + obj.getJiraUrl());
                    break;
                default:

                    break;
            }
        }

        public void BeforeTest(ITest test)
        {
            if (test.IsSuite == false) {
                Console.WriteLine(_ZypherTestId);
                System.Diagnostics.Debug.WriteLine(_ZypherTestId);
            }
            
        }
    }
}