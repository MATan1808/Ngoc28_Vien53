using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTonyFruit
{
    [TestClass]
    public class DangNhap_Ngoc28_Vien53
    {
        IWebDriver driver_Ngoc28_Vien53;
        [TestMethod]
        public void TestDangNhap_Ngoc28_Vien53()
        {
            // Khởi tạo WebDriver cho Chrome
            driver_Ngoc28_Vien53 = new ChromeDriver();
            // Điều hướng đến trang web 
            driver_Ngoc28_Vien53.Navigate().GoToUrl("https://pibook.vn/");
            // Nhấn vào biểu tượng đăng nhập                                               
            IWebElement searchButton = driver_Ngoc28_Vien53.FindElement(By.Id("Header_account_view"));
            searchButton.Click();
            //Nhập sđt
            driver_Ngoc28_Vien53.FindElement(By.Name("id")).SendKeys("0707534860");
            // Nhập mật khẩu
            driver_Ngoc28_Vien53.FindElement(By.Name("password")).SendKeys("myvien1234");
            //Nhấn nút đăng nhập
            driver_Ngoc28_Vien53.FindElement(By.CssSelector(".btnSubmit.w-100")).Click();
        }
    }
}
