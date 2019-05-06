using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEcryptorApp
{
    class Decryptor
    {
        public string Decrypt(string path)
        {
            int value = 0;
            string textToDecrypt = FileHandler.GetStringFromFile(path);
            string[] seperatedString = textToDecrypt.Split('e', 'o');
            string wordsToSaveToFile = "";

            foreach (var hashValue in seperatedString)
            {
                int intHashValue = int.Parse(hashValue);
                if (intHashValue % 2 == 0)
                {
                    value = intHashValue * 2;
                    wordsToSaveToFile += Characters.characters[value].ToString();
                }
                else
                {
                    value = (intHashValue - 1) / 3;
                    wordsToSaveToFile += Characters.characters[value].ToString();
                }
            }
            return wordsToSaveToFile;
        }
    }
}
