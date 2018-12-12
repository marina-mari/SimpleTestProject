using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCore;

namespace SimpleTestProject
{
	[Binding]
	class SimpleTestSteps 
	{
		IWebDriver driver = new ChromeDriver();
		public BlaBlaPage blaBlaPage;

		public SimpleTestSteps()
		{
			blaBlaPage = new BlaBlaPage(driver);
		}

		[Given(@"I navigate to BlaBla page")]
		public void GivenINavigateToBlaBlaPage()
		{
			blaBlaPage.GoTo();
		}


	}
}
