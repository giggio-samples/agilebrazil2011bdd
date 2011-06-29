using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1.Tests.Support
{
    [TestClass]
    public abstract class AAA
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Arrange();
            Act();
        }

        public virtual void Arrange()  {  }

        public abstract void Act();
        
    }
}
