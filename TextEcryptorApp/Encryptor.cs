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

        /// <summary>
        /// Encrypts the text using a simple encryption formula
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string Encrypt(string path)
        {
            
            string wordToEncrypt = FileHandler.GetStringFromFile(path);
            int value = 0;
            int hashValue = 0;
            string encrytedValue = "";

            for (int i = 0; i < wordToEncrypt.Length; i++)
            {
                for (int j = 0; j < Characters.characters.Length; j++)
                {
                    if (wordToEncrypt.ToLower()[i] == Characters.characters[j])
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
    }
}
