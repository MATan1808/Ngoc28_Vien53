using KiemTraDauVaoEmail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestDauVaoEmail_Ngoc28_Vien53
    {
        [TestClass]
        public class ValidatorTests
        {
            [TestMethod]
            public void EmailHopLe()
            {
                // Arrange
                string[] validEmails = { "example@example.com", "example123@example.co.uk", "user.name@example.domain.com" };

                // Act & Assert
                foreach (string email in validEmails)
                {
                    bool result = DauVaoEmail_Ngoc28_Vien53.Email(email);
                    bool expected = true;
                    Assert.AreEqual(expected, result);
                }
               
            }

            [TestMethod]
            public void EmailKhongHopLe()
            {
                // Arrange
                string[] invalidEmails = { "example.com", "example@example", "@example.com", "user@.com", "user.name@" };

                // Act & Assert
                foreach (string email in invalidEmails)
                {
                    bool result = DauVaoEmail_Ngoc28_Vien53.Email(email);
                    bool expected = false;
                    Assert.AreEqual(expected, result);
                }
            
            }
        }
    }
}
