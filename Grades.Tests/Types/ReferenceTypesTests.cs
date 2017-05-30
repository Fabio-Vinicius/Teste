using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]

    public class ReferenceTypesTests
    {
        [TestMethod]
        public void MyTestMethod()
        {

        }

        [TestMethod]

        public void GradeBookVariablesHoldReference()
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scots Book";

            Assert.AreNotEqual(g1.Name, g2.Name);

        }
    }
}
