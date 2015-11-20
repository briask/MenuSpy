using System;
using System.Collections.Generic;

namespace DiningSpy
{
    internal class WDWDiningMenuSite
    {
        private IWebScraper webScraper;

        public WDWDiningMenuSite(IWebScraper webScraper)
        {
            if (webScraper == null)
            {
                throw new ArgumentNullException("webScraper");
            }

            this.webScraper = webScraper;
        }

        internal IEnumerable<DiningLocation> GetAllDiningLocations(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new DiningSpyException();
            }

            return new List<DiningLocation>();
        }
    }
}