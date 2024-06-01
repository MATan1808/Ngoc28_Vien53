using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using XetHocBong;

    [TestClass]
    public class TestHocBong_Ngoc28_Vien53
    {
        [TestMethod]
        public void DuDieuKien_Ngoc28_Vien53()
        {
            // Arrange
            double d1 = 9.0;
            double d2 = 9.0;
            double d3 = 9.5;
            double diemRl = 85;

            // Act
            bool result = HocBong.xetHocBong(d1, d2, d3, diemRl);

            // Assert
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Khongdudieukien_Ngoc28_Vien53()
        {
            // Arrange
            double d1 = 8.0;
            double d2 = 7.5;
            double d3 = 8.0;
            double diemRl = 70;

            // Act
            bool result = HocBong.xetHocBong(d1, d2, d3, diemRl);

            // Assert
            bool expected = false;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ĐiểmTrungBìnhThấpHơnYêuCầu_Ngoc28_Vien53()
        {
            // Arrange
            double d1 = 7.0;
            double d2 = 8.0;
            double d3 = 8.0;
            double diemRl = 85;

            // Act
            bool result = HocBong.xetHocBong(d1, d2, d3, diemRl);

            // Assert
            bool expected = false;
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void ĐiểmRènLuyệnThấpHơnYêuCầu_Ngoc28_Vien53()
        {
            // Arrange
            double d1 = 8.5;
            double d2 = 8.5;
            double d3 = 8.5;
            double diemRl = 79;

            // Act
            bool result = HocBong.xetHocBong(d1, d2, d3, diemRl);

            // Assert
            bool expected = false;
            Assert.AreEqual(expected, result);
        }
    }
}



