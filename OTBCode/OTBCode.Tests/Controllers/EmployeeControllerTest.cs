using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTBCode.Tests.Controllers
{
    // evaluate the context
    [TestClass]
    public class EmplouyeeContorllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var controller = new OTBCode.Controllers.EmployeeController();
            var res = controller.Index() as ViewResult;
        }
    }
}
