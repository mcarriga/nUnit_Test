using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nUnit_Example
{
    [TestFixture, ZephyrFixture("url to be")]
    public class Class1
    {
        [TestCase, ZephyrTest("123456")]
        public void test1() {
            Console.WriteLine("Test1");
            System.Diagnostics.Debug.WriteLine("Test1");
            Assert.IsTrue(true);
        }

        [TestCase, ZephyrTest("789999")]
        public void test2() {
            Console.WriteLine("Test2");
            System.Diagnostics.Debug.WriteLine("Test2");
            Assert.IsFalse(false);
        }
    }
}
