using System;
using System.Linq;
using Xunit;
using DiningSpy;
using System.Collections;
using System.Collections.Generic;
using FakeItEasy;

namespace DiningSpyTests
{
    public class WDWDiningMenusTests
    {
        [Fact]
        public void GetAllDiningLocations_WebsiteDown_ThrowsException()
        {
            var fakeWebScraper = A.Fake<IWebScraper>();

            WDWDiningMenuSite site = new WDWDiningMenuSite(fakeWebScraper);

            Assert.Throws<DiningSpyException>(() => site.GetAllDiningLocations(string.Empty));
        }
    }
}
