using NUnit.Framework;
using System;
using NUnit.Framework.Interfaces;

namespace nUnit_Example
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Assembly, AllowMultiple = true)] 
    public class ZephyrFixtureAttribute : Attribute, ITestAction
    {
        private string _JiraUrl;
        public string getJiraUrl() {
            return _JiraUrl;
        }

        public ZephyrFixtureAttribute(string JiraUrl) {
            _JiraUrl = JiraUrl;
        }
        ActionTargets ITestAction.Targets
        {
            get
            {
                return ActionTargets.Suite;
            }
        }

        void ITestAction.AfterTest(ITest test)
        {
            Console.WriteLine(_JiraUrl);
            System.Diagnostics.Debug.WriteLine(_JiraUrl);

        }

        void ITestAction.BeforeTest(ITest test)
        {
            Console.WriteLine(_JiraUrl);
            System.Diagnostics.Debug.WriteLine(_JiraUrl);
        }
    }
}