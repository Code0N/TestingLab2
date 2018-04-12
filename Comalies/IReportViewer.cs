using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comalies
{
    public interface IReportViewer
    {
        int UsedSize { get; set; }
        //string Directory { get; set; }
        //============================
        void Clean();
    }
}
