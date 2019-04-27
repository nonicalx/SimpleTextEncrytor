using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEcryptorApp
{

    class Encryptor
    {
        readonly char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '=', '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '[', ']', '\\', '{', '}', '|', ';', '\'', ':', '"', '\n', ',', '.', '/', '<', '>', '?','\t',' ' };

        /// <summary>
        /// Gets the string from the text file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string GetString(string path)
        {
            string wordToEncrypt = "";
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                wordToEncrypt = streamReader.ReadToEnd();
            }
            return wordToEncrypt;
        }

        /// <summary>
        /// Encrypts the text using a simple encryption formula
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string Encrypt(string path)
        {
            string wordToEncrypt = GetString(path);
            int value = 0;
            int hashValue = 0;
            string encrytedValue = "";

            for (int i = 0; i < wordToEncrypt.Length; i++)
            {
                for (int j = 0; j < alphabets.Length; j++)
                {
                    if (wordToEncrypt.ToLower()[i] == alphabets[j])
                    {
                        value = j + 1;
                        if (value % 2 == 0)
                        {
                            hashValue = value / 2;
                            encrytedValue += "e" + hashValue.ToString();
                        }
                        else
                        {
                            hashValue = (value * 3) + 1;
                            encrytedValue += "o" + hashValue.ToString();
                        }
                    }
                }
            }

            return encrytedValue;
        }


        public void WriteToFile()
        {
            ///Under Construction Good Night
            string folderPath = @"c:\EncrytedFiles";
            if (Directory.Exists(folderPath))
            {
                string fileName = folderPath+@"\encrypted";
                try
                {
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine("File Already Exist!!!");
                    }
                    else
                    {
                        using (FileStream fs = File.Create(fileName))
                        {

                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }
    }
}
