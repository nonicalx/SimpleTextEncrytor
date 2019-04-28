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

        public static void CreateFile()
        {
            throw new NotImplementedException();
        }

        public static void WriteStringToFile()
        {
            throw new NotImplementedException();
        }
    }
}
