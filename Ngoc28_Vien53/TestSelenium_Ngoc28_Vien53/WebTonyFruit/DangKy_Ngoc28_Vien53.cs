using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pibook_Ngoc28_Vien53 { 

[TestClass]
public class DangKy_Ngoc28_Vien53
{
    IWebDriver driver_Ngoc28_Vien53;

    [TestMethod]
    public void TestDangKy_Ngoc28_Vien53()
    {
        // Khởi tạo WebDriver cho Chrome
        driver_Ngoc28_Vien53 = new ChromeDriver();
        // Điều hướng đến trang web 
        driver_Ngoc28_Vien53.Navigate().GoToUrl("https://pibook.vn/");
        // Nhấn vào biểu tượng đăng nhập
        IWebElement searchButton = driver_Ngoc28_Vien53.FindElement(By.Id("Header_account_view"));
        searchButton.Click();
        // Điền họ tên
        driver_Ngoc28_Vien53.FindElement(By.Name("fullname")).SendKeys("Mỹ Viên");
        //điền email
        driver_Ngoc28_Vien53.FindElement(By.Name("email")).SendKeys("ltmvien03@gmail.com");
        //điền sđt
        driver_Ngoc28_Vien53.FindElement(By.Name("phone")).SendKeys("0707534860");
        //điền mật khẩu
        driver_Ngoc28_Vien53.FindElement(By.CssSelector("#form-reg > div:nth-child(4) > div > input")).SendKeys("vien@123");
        //điền lại mật khẩu
        driver_Ngoc28_Vien53.FindElement(By.CssSelector("input.form-control[name='re_password']")).SendKeys("vien@123");
        //nhấn nút đăng ký
        driver_Ngoc28_Vien53.FindElement(By.CssSelector("#form-reg > div.form-group.text-right > button")).Click();

    }

}
}
