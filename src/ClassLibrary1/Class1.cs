using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Lol()
        {
            string expected = "value";

            var actual = ConfigurationManager.AppSettings["SomeValue"];
            
            Assert.AreEqual(expected, actual, "should be lol was " + actual);
        }
    }
}
