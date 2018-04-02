using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comalies
{
    class ReportViewer: IReportViewer
    {
        public int UsedSize { get; set; }
        //public string Directory { get; set; }
        private IFileService FileService;
        //=============
        public void Clean(IFileService fileService, string dirToClean)
        {
            FileService = fileService;
            this.UsedSize = FileService.RemoveTemporaryFiles(dirToClean);
        }
    }
}
