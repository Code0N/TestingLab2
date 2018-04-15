using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comalies;
using System.IO;

namespace ComaliesTests
{
    class FakeMockFileService : IFileService
    {
        public string ReceivedPath = String.Empty;
        public int RemoveTemporaryFiles(string dir)
        {
            ReceivedPath = dir;
            return 0;
        }
    }
}
