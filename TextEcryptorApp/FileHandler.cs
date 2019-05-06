using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEcryptorApp
{
    class FileHandler
    {

        public static string GetStringFromFile(string path)
        {
            string wordToEncrypt = "";
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                wordToEncrypt = streamReader.ReadToEnd();
            }
            return wordToEncrypt;
        }

        private static void CreateFolder()
        {
            string folderPath = @"C:\EncryptedFiles";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            
        }

        public static string CreateFileName()
        {
            string nameOfOrignalFile = Console.ReadLine();
            string fileName = "Encrytped" + nameOfOrignalFile;
            string file = @"C:\EncryptedFiles\" + fileName;

            return file;
        }

        private static string CreateFileName(string pathOfOriginalFile)
        {
            string fileName = "Encrytped" + Path.GetFileName(pathOfOriginalFile);
            string file = @"C:\EncryptedFiles\" + fileName;

            return file;
        }


        public static string WriteStringToFile(string path, string text)
        {
            CreateFolder();
            string fileName = CreateFileName(path);
            string jobComplete = "String successfully written in " + fileName;
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return jobComplete;
        }
    }
}
