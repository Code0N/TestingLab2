using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comalies;
using System.IO;

namespace ComaliesTests
{
    class FileServiceStubForLogTest: FileService
    {
        List<String> logForTestList = new List<string>();
        public int RemoveTemporaryFiles(string dir, List<String> filesList)
        {
            //int FilesSize = 0;
            //if (!(Directory.Exists(dir)) || !(File.Exists(Path.Combine(dir, "ToRemove.txt"))))
            //{
            //    throw new FileNotFoundException("Папка не существует либо в ней не существует список файлов к удалению");
            //}
            //string[] fileNamesList = File.ReadAllLines(Path.Combine(dir, "ToRemove.txt"));
            //if (fileNamesList.Length == 0)
            //{
            //    throw new FileLoadException("Файл пуст");
            //}
            //StreamWriter logWriter = new StreamWriter(Path.Combine(dir, "error.log"));
            logForTestList.Clear(); //На всякий
            foreach (string _file in filesList)
            {
                if (!File.Exists(Path.Combine(dir, _file)))
                {
                    logForTestList.Add("Файл " + _file + "не найден");
                }
            }

            //try
            //{
            //    foreach (string _file in fileNamesList)
            //    {
            //        if (File.Exists(Path.Combine(dir, _file)))
            //        {
            //            FileInfo fi = new FileInfo(Path.Combine(dir, _file));
            //            FilesSize += (int)fi.Length; //В ТЗ сказано INT
            //            File.Delete(Path.Combine(dir, _file)); //Во славу Альянсу
            //        }
            //        else
            //        {
            //            logWriter.WriteLine("Файл " + _file + "не найден");
            //        }

            //    }
            //}
            //finally
            //{
            //    logWriter.Close();
            //}

            return 2048;
        }
    }
}
