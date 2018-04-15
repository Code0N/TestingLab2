using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comalies
{
    public class ReportViewer2: ReportViewer
    {
        public ReportViewer2(IFileService fileService, string pathToDelete): base(fileService, pathToDelete)
        {
            
        }

        public override void Clean()
        {
            try
            {
                this.UsedSize = base.FileService.RemoveTemporaryFiles(base.DirToClean);
            }
            catch (Exception ex)
            {
                this.UsedSize = 0;
                //System.Windows.Forms.MessageBox.Show("При обработке файлов вызвано исключение " + ex.Message + ", метод прекращает свою работу");
                throw ex; //Прокинуть ексепшн вверх для теста
            }
        }
    }
}
