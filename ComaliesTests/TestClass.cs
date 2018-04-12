using Comalies;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComaliesTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCleanFilesSize()
        {
            IReportViewer reportViewer = new ReportViewer(new FakeStubFileServiceReturnSize(), "TestReturnValue");
            reportViewer.Clean();
            Assert.AreEqual(2048, reportViewer.UsedSize);
        }

        [Test]
        public void TestFSStubException()
        {
            //IReportViewer reportViewer = new ReportViewer(new FakeStubFileServiceReturnSize(), "TestException");
            ////reportViewer.Clean();
            //Assert.Throws<FileNotFoundException>(() => reportViewer.Clean());
            IFileService fileService = new FakeStubFileServiceReturnSize();
            Assert.Throws<FileNotFoundException>(() => fileService.RemoveTemporaryFiles("TestException"));
        }

        [Test]
        public void TestFSRealException()
        {
            IFileService fileService = new FileService();
            Assert.Throws<FileNotFoundException>(() => fileService.RemoveTemporaryFiles(@"C:\notExist\"));
        }
    }
}
