using KiemTraSoNguyenTo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]

    public class TestSoNguyenTo_Ngoc28_Vien53
    {
        public TestContext TestContext { get; set; }
        private SoNguyenTo_Ngoc28_Vien53 soNguyenTo;

        [TestInitialize]
        public void SetUp()
        {
            soNguyenTo = new SoNguyenTo_Ngoc28_Vien53();
        }

        [TestMethod]
        [DataRow(0, false)]
       /* [DataRow(1, false)]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(5, true)]
        [DataRow(6, false)]
        [DataRow(9, false)]
        [DataRow(10, false)]*/
        public void KiemTraNguyenTo_Ngoc28_Vien53(int number, bool expectedResult)
        {
            // Act
            bool result = soNguyenTo.NguyenTo(number);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
       
    }
}
