using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace TestProject1.Features.Support
{
    [Binding]
    public class UI
    {
        public static IE Browser
        {
            get { return IEStaticInstanceHelper.IE; }
        }
        [BeforeFeature("web")]
        public static void BeforeFeature()
        {
            IEStaticInstanceHelper.Initialize();
        }
        [AfterFeature("web")]
        public static void AfterFeature()
        {
            IEStaticInstanceHelper.ReleaseBrowser();
        }
    }
}
