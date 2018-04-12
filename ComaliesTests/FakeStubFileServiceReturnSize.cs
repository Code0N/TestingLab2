using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comalies;
using System.IO;

namespace ComaliesTests
{
    class FakeStubFileServiceReturnSize: IFileService
    {
        public int RemoveTemporaryFiles(string dir)
        {
            if (dir == "TestReturnValue")
            {
                return 2048;
            }
            else if (dir == "TestException")
            {
                throw new FileNotFoundException("Test File/Folder not exist exception");
            }
            return 0;
        }
    }
}
