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
            if (test.IsSuite == false)
            {
                Console.WriteLine(_ZypherTestId);
                System.Diagnostics.Debug.WriteLine(_ZypherTestId);
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