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
    public class QuenMatKhau_Ngoc28_Vien53
    {
        IWebDriver driver_Ngoc28_Vien53;
        [TestMethod]
        public void TestQuenMatKhau_Ngoc28_Vien53()
        {
            // Khởi tạo WebDriver cho Chrome
            driver_Ngoc28_Vien53 = new ChromeDriver();
            // Điều hướng đến trang web 
            driver_Ngoc28_Vien53.Navigate().GoToUrl("https://pibook.vn/");
            // Nhấn vào biểu tượng đăng nhập                                                
            IWebElement searchButton = driver_Ngoc28_Vien53.FindElement(By.Id("Header_account_view"));
            searchButton.Click();
            //Nhấn nút quên mật khẩu
            driver_Ngoc28_Vien53.FindElement(By.CssSelector("a.ForgetPwd")).Click();
            //điền email
            driver_Ngoc28_Vien53.FindElement(By.CssSelector("input.form-control[name='id']")).SendKeys("ltmvien@gmail.com");
            //Nhấn nút lấy lại mật khẩu
            driver_Ngoc28_Vien53.FindElement(By.CssSelector("button.btnSubmit.w-100")).Click();

        }
    }
}
