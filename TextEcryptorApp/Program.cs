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
            string report = encryptor.Encrypt(@"C:\Users\Nerd Stark\Desktop\test2.txt");
            Console.WriteLine(report);

            Decryptor decryptor = new Decryptor();
            report = decryptor.Decrypt(@"C:\EncryptedFiles\Encryptedtest2.txt");
            Console.WriteLine(report);
            Console.ReadLine();

        }


    }
}
