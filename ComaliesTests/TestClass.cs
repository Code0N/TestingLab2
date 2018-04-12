using Comalies;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaliesTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCleanFilesSize()
        {
            IReportViewer reportViewer = new ReportViewer(new FakeStubFileServiceReturnSize(), "FakePath");
            reportViewer.Clean();
            Assert.AreEqual(2048, reportViewer.UsedSize);
        }
    }
}
