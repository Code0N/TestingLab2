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
        private string DirToClean { get; set; }
        //public string Directory { get; set; }
        private IFileService FileService;
        //=============

        public ReportViewer(IFileService fileService, string pathToDelete)
        {
            this.FileService = fileService;
            this.DirToClean = pathToDelete;
        }
        
        public void Clean()
        {
            this.UsedSize = FileService.RemoveTemporaryFiles(DirToClean);
        }
    }
}
