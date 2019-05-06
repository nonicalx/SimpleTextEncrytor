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
            //Encryptor encryptor = new Encryptor();
            //string path = @"C:\Users\Nerd Stark\Desktop\test.txt";
            //string encrytedResult = encryptor.Encrypt(path);

            //Console.WriteLine(FileHandler.WriteStringToFile(path, encrytedResult));
            //Console.WriteLine(encrytedResult);

            //Console.ReadLine();
            string text = "10e12e23e24e33o22e15o";
            string[] separators = text.Split('e', 'o');
            foreach (var item in separators) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


    }
}
