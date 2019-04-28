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

        public static void CreateFolder()
        {
            throw new NotImplementedException();
        }

        private static string CreateFileName(string pathOfOriginalFile)
        {
            string fileName = "Encrytped" + Path.GetFileName(pathOfOriginalFile);
            string file = @"C:\EncryptedFiles\" + fileName;

            return file;
        }

        public static string WriteStringToFile(string path, string text)
        {
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
