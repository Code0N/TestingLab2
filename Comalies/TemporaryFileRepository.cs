using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comalies
{
    class TemporaryFileRepository
    {
        private List<string> FileNamesList;
        private IStringFormatter StringFormatter { get; set; }

        public TemporaryFileRepository()
        {
            FileNamesList = new List<string>();
        }

        public string GetLastElement()
        {
            return FileNamesList.Last();
        }

        public void Add(string FileName)
        {
            try
            {
                FileNamesList.Add(StringFormatter.ShortFileString(FileName));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ты зачем null передал, нехороший человек?" + Environment.NewLine + ex.Message, "Ошыбка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
        }
    }
}
