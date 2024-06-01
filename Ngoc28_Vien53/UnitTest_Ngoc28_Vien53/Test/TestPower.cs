
using Bai_2_28_KimNgoc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TestPower_Ngoc28_Vien53
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
          @".\Data\TestPower.csv", "TestPower#csv", DataAccessMethod.Sequential)]

        [TestMethod]


        public void testPower()
        {
            int n;
            double actual;
            double x, expected;
            n = int.Parse(TestContext.DataRow[1].ToString());
            x = double.Parse(TestContext.DataRow[0].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());
            actual = Power_Ngoc28_Vien53.Power(x, n);
            Assert.AreEqual(expected, actual);
        }


    }
}
