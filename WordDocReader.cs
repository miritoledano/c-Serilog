using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class WordDocReader 
    {
        private static WordDocReader instance;
        public string filePath { get; set; }
        public DateTime openedDate { get; set; }

        private WordDocReader() { }

        public static WordDocReader GetInstance()
        {
            if (instance == null)
            {
                instance = new WordDocReader();
            }
            return instance;
        }

        public void OpenFile()
        {
            // פונקציה הפותחת קובץ ומציגה אותו על המסך
            Console.WriteLine("Opening file: " + filePath);
        }

        public void BackupFile()
        {
            // פונקציית גיבוי - היוצרת עותק של הקובץ
            Console.WriteLine("Creating backup of file: " + filePath);
        }

       
    }
}