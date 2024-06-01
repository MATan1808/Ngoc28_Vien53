using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pibook_Ngoc28_Vien53
{
    [TestClass]
    public class TimKiem_Ngoc28_Vien53
    {
        // Khởi tạo ChromeDriver
        IWebDriver driver_Ngoc28_Vien53;
        [TestInitialize]
        public void TimKiemTest()
        {
           // khởi tạo
            driver_Ngoc28_Vien53 = new ChromeDriver();
            // Điều hướng đến trang web pibook.vn
            driver_Ngoc28_Vien53.Navigate().GoToUrl("https://pibook.vn/");
            // Mở rộng cửa sổ trình duyệt
            driver_Ngoc28_Vien53.Manage().Window.Maximize();
        }
        [TestMethod]
        public void TeimKiem()
        {
            // Tìm ô tìm kiếm bằng thuộc tính name
            IWebElement element = driver_Ngoc28_Vien53.FindElement(By.Name("txt_search"));
            // Chuỗi tìm kiếm
            string txtgt = "rubik";
            element.SendKeys(txtgt);
            // Tìm và nhấn nút tìm kiếm bằng CSS selector
            IWebElement searchButton = driver_Ngoc28_Vien53.FindElement(By.CssSelector(".btn.btn-search.text-white.px-sm-4.px-3.btn-mobile-size"));
            searchButton.Click();
            // Lấy URL hiện tại sau khi tìm kiếm
            string vien_Ngoc = driver_Ngoc28_Vien53.Url;
            Console.WriteLine("URL sau khi tìm kiếm: " + vien_Ngoc);
        }
        public void TearDown()
        {
            // Đóng trình duyệt sau khi hoàn thành kiểm thử
            if (driver_Ngoc28_Vien53 != null)
            {
                driver_Ngoc28_Vien53.Quit();
            }
        }
    }
}
