using System;
using System.Collections.Generic;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comalies
{
    public class ReportViewer: IReportViewer
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
            this.UsedSize = 0;
        }
        
        public void Clean()
        {
            try
            {
                this.UsedSize = FileService.RemoveTemporaryFiles(DirToClean);
            }
            catch (Exception ex)
            {
                this.UsedSize = -1;
                System.Windows.Forms.MessageBox.Show("При обработке файлов вызвано исключение " + ex.Message + ", метод прекращает свою работу");
                return;
            }
            
        }
    }
}
