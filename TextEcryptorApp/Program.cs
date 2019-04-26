using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEcryptorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = GetString(@"C:\Users\USER\Desktop\testSubject.txt");

            string encrytedResult = Encrypt(text);
            Console.WriteLine(encrytedResult);

            Console.ReadLine();
        }

        static string GetString(string path)
        {
            string wordToEncryt = "";
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                 wordToEncryt = streamReader.ReadToEnd();
            }
            return wordToEncryt;
        }

        static string Encrypt(string wordToEncrypt)
        {

            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', ',',' ','#','\'','@'};
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
    }
}
