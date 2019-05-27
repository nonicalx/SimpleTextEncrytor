using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEcryptorApp
{
    enum Mode
    {
        encrypt = 0,
        decrypt = 1
    }
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

        private static void CreateFolder(Mode mode)
        {
            string folderPath = "";
            switch (mode)
            {
                
                case Mode.encrypt:
                    folderPath = @"C:\EncryptedFiles";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    break;
                case Mode.decrypt:
                    folderPath = @"C:\DecryptedFiles";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    break;
                default:
                    break;
            }

            
        }

        public static string CreateFileName()
        {
            string nameOfOrignalFile = Console.ReadLine();
            string fileName = "Encrytped" + nameOfOrignalFile;
            string file = @"C:\EncryptedFiles\" + fileName;

            return file;
        }

        public static string CreateFileName(string pathOfOriginalFile, Mode mode)
        {
            string fileName = "";
            string file = "";
            switch (mode)
            {
                case Mode.encrypt:
                    fileName = "Encrypted" + Path.GetFileName(pathOfOriginalFile);
                    file = @"C:\EncryptedFiles\" + fileName;
                    break;
                case Mode.decrypt:
                    fileName = Path.GetFileName(pathOfOriginalFile).Replace("En", "De");
                    file = @"C:\DecryptedFiles\" + fileName;
                    break;
                default:
                    break;
            }
            return file;
            
        }


        public static string WriteStringToFile(string path, string text, Mode mode)
        {
            CreateFolder(mode);
            string fileName = CreateFileName(path, mode);
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
