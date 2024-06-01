using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTonyFruit
{
    [TestClass]
    public class chonsanpham
    {

        IWebDriver driver;
        [TestInitialize]
        [TestMethod]
        public void Chonsanpham()
        {
            // Khởi tạo ChromeDriver
            driver = new ChromeDriver();
            // Đi đến trang web
            driver.Navigate().GoToUrl("https://pibook.vn");
            // Nhấn vào liên kết thứ hai trong menu điều hướng
            driver.FindElement(By.XPath("//*[@id=\"nav_home\"]/div/nav/ul/li[2]/a")).Click();
            // Nhấn vào liên kết trong phần tử div cụ thể
            driver.FindElement(By.XPath(" //*[@id=\"container\"]/div/div[2]/div/div/div/div[1]/div/div/div[1]/div[  // Nhấn vào liên kết của một sách cụ thể (hoặc phần tử khác) được xác định bằng XPath]/div[4]/a")).Click();
            // Nhấn vào liên kết của một sách cụ thể (hoặc phần tử khác) được xác định bằng XPath
            driver.FindElement(By.XPath("   //*[@id=\"container\"]/div/div[2]/div/div/div/div[3]/div/div[4]/div/div[1]/div[1]/div/div[2]/h3/a")).Click();
            // Đóng trình duyệt sau khi hoàn thành
            driver.Quit();


        }

    }
}
