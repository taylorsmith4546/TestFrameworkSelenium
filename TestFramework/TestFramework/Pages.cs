using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                return homePage;
            }
        }
    }

    public class HomePage
        {
            static string Url = "https://www.pluralsight.com";
            private static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";

            public void GoTo()
            {
                Browser.Goto(Url);
            }

        
            public bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }
    }
