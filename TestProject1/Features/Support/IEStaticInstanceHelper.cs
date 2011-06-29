using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using System.Threading;

namespace TestProject1.Features.Support
{
    public static class IEStaticInstanceHelper
    {
        private static IE _ie;
        private static int _previouslyKnownIeThreadHashCode;
        private static string _ieHwnd;

        public static void Initialize()
        {
            IE = new IE();
        }

        public static IE IE
        {
            get
            {
                if (GetCurrentThreadHashCode() != _previouslyKnownIeThreadHashCode)
                {
                    _ie = WatiN.Core.Browser.AttachTo<IE>(Find.By("hwnd", _ieHwnd));
                    _previouslyKnownIeThreadHashCode = GetCurrentThreadHashCode();
                }
                return _ie;
            }
            private set
            {
                _ie = value;
                _ieHwnd = _ie.hWnd.ToString();
                _previouslyKnownIeThreadHashCode = GetCurrentThreadHashCode();
            }
        }

        private static int GetCurrentThreadHashCode()
        {
            return Thread.CurrentThread.GetHashCode();
        }

        public static void ReleaseBrowser()
        {
            var thread = new Thread(() =>
            {
                if (IEStaticInstanceHelper.IE != null)
                {
                    IEStaticInstanceHelper.IE.Close();
                    IEStaticInstanceHelper.IE.Dispose();
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
