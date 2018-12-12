using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCore;

namespace SimpleTestProject
{
	public class BlaBlaPage : BasePage
	{
		public BlaBlaPage(IWebDriver driver) : base(driver)
		{ }

		private IWebElement simpleElement => wait.Until< IWebElement>(driver => driver.FindElement(By.XPath("")));

		public void GoTo()
		{
			driver.Url = "https://www.blablacar.com.ua/";
		}

	}
}
