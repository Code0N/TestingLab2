﻿using Comalies;
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
        public void TestZeroFilesSize() //Тест, что при передаче несуществующего пути метод Clean() корректно завершает свою работу
        { //Стаб возвращает эксепшн при pathToDelete == "TestException"
            IReportViewer reportViewer = new ReportViewer(new FakeStubFileServiceReturnSize(), "TestException");
            reportViewer.Clean();
            Assert.AreEqual(0, reportViewer.UsedSize);
        }

        [Test]
        public void TestFSStubException() //Зачем незнаю, мне снятся поезда...
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
