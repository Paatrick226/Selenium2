using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // rmt test durchführen, test explorer öffnen
        [Test]
        public void LaunchChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.skyscanner.de/fluge");
            WebElement dateBox = (WebElement)driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[1]/div[2]/div/div/div/div/form/div[2]/div[2]/div/div[1]/button/span"));
            Thread.Sleep(2000);
            DateTime y = DateTime.Today;
            dateBox.SendKeys(y.ToString());

            //dateBox.SendKeys("09");
            //Thread.Sleep(2000);

            // dropdown
            // https://stackoverflow.com/questions/5278281/how-to-select-an-option-from-drop-down-using-selenium-webdriver-c

            IWebElement textBox = driver.FindElement(By.XPath(""));
            textBox.SendKeys("bla");

        }
    }
}