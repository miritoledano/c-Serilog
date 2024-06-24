using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordDocReader reader = WordDocReader.GetInstance();
            reader.filePath = "\"D:\\users\\user1\\Downloads\\1.docx\"";
            reader.openedDate = DateTime.Now;

            reader.OpenFile();
            reader.BackupFile();
            
        }
    }
}
