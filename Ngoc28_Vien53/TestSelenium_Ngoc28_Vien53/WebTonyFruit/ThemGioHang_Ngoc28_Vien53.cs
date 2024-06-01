using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pibook_Ngoc28_Vien53
{
    [TestClass]
    public class ThemGioHang_Ngoc28_Vien53
    {
        IWebDriver driver_Ngoc28_Vien53;
        [TestMethod]
        public void TestThemGioHang_Ngoc28_Vien53()
        {
            driver_Ngoc28_Vien53 = new ChromeDriver(); // Khởi tạo trình duyệt
            driver_Ngoc28_Vien53.Navigate().GoToUrl("https://pibook.vn/"); // Đi đến trang web
            // Nhấn vào hình ảnh sản phẩm để chuyển đến trang chi tiết
            driver_Ngoc28_Vien53.FindElement(By.CssSelector("img[alt='Chitose Trong Chai Ramune - Tập 6']")).Click();
            // Nhấn vào nút thêm vào giỏ hàng
            driver_Ngoc28_Vien53.FindElement(By.CssSelector(".btn.btn-add-to-cart.w-48")).Click();

        }
    }
}
