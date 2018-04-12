using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comalies;

namespace ComaliesTests
{
    class FakeStubFileServiceReturnSize: IFileService
    {
        public int RemoveTemporaryFiles(string dir)
        {
            return 2048;
        }
    }
}
