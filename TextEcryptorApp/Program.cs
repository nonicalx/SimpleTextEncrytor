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
            Encryptor encryptor = new Encryptor();
            string path = @"C:\Users\USER\Desktop\testSubject.txt";
            string encrytedResult = encryptor.Encrypt(path);
            Console.WriteLine(encrytedResult);

            Console.ReadLine();
        }


        
    }
}
