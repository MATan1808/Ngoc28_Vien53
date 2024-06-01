using GiaiPhuongTrinhBac1va2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TestGiaiPhuongwTrinhBac2_Ngoc28_Vien53

    {
        [TestMethod]
        public void TestDeltaLonHon0_Ngoc28_Vien53()
        {
            // Arrange
            double a = 1.0;
            double b = -3.0;
            double c = 2.0;
            double expected1 = 1.0;
            double expected2 = 2.0;

            // Act
            var result = PTB2_Ngoc28_Vien53.GiaiPhuongTrinhBac2(a, b, c);

            // Assert
            Assert.IsTrue(result.Item1 == expected1 && result.Item2 == expected2 || result.Item1 == expected2 && result.Item2 == expected1);
        }

        [TestMethod]
        public void TestDeltaBang0_Ngoc28_Vien53()
        {
            // Arrange
            double a = 1.0;
            double b = -4.0;
            double c = 4.0;
            double expected = 2.0;

            // Act
            var result = PTB2_Ngoc28_Vien53.GiaiPhuongTrinhBac2(a, b, c);

            // Assert
            Assert.AreEqual(expected, result.Item1);
            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void TestDeltaNhoHon0_Ngoc28_Vien53()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => PTB2_Ngoc28_Vien53.GiaiPhuongTrinhBac2(a, b, c));
        }
    }
}
