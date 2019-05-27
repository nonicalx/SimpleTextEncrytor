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
            int intHashValue = 0;
            string hashValueNum = "";
            string textToDecrypt = FileHandler.GetStringFromFile(path).Trim().TrimStart();
            string[] seperatedString = textToDecrypt.Split(' ');
            string wordsToSaveToFile = "";

            foreach (var hashValue in seperatedString)
            {
                if (hashValue!="")
                {
                    int lastIndex = hashValue.Length - 1;
                    
                    
                    if (hashValue[lastIndex]== 'e')
                    {
                        hashValueNum = hashValue.Remove(lastIndex);
                        intHashValue = int.Parse(hashValueNum);
                        value = (intHashValue * 2)-1;
                        wordsToSaveToFile += Characters.characters[value].ToString();
                    }
                    else
                    {
                        hashValueNum = hashValue.Remove(lastIndex);
                        intHashValue = int.Parse(hashValueNum);
                        value = ((intHashValue - 1) / 3)-1;
                        wordsToSaveToFile += Characters.characters[value].ToString();
                    }
                }   
            }
            string result ="DECRYPTED and "+FileHandler.WriteStringToFile(path, wordsToSaveToFile, Mode.decrypt);
            return result;
        }
    }
}
