using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DebugAssertFailure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Debug.Assert(false);
            
        }

        [TestMethod]
        public void PassingTest()
        {

        }
    }
}
