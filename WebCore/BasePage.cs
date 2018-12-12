using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCore
{
	public class BasePage
	{
		protected IWebDriver driver { get; set; }
		public WebDriverWait wait { get; set; }

		public BasePage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
		}
	}
}
