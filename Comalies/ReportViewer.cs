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
        protected string DirToClean { get; set; }
        //public string Directory { get; set; }
        protected IFileService FileService;
        //=============

        public ReportViewer(IFileService fileService, string pathToDelete)
        {
            this.FileService = fileService;
            this.DirToClean = pathToDelete;
            this.UsedSize = 0;
        }
        
        public virtual void Clean()
        {
            try
            {
                this.UsedSize = FileService.RemoveTemporaryFiles(DirToClean);
            }
            catch (Exception ex)
            {
                this.UsedSize = 0;
                System.Windows.Forms.MessageBox.Show("При обработке файлов вызвано исключение " + ex.Message + ", метод прекращает свою работу");
                return;
            }
            
        }
    }
}
