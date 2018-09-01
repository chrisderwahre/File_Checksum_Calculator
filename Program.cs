using System;

namespace File_Checksum_Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(
@"===File checksum calculator===

Made By ChrisDerWahre 2018

Usage: 
file_checksum_calculator.exe 'Path to the file'

Will Return:
-MD5
-SHA1
-SHA256
-SHA384
-SHA512
Checksum's

===File checksum calculator===
");
                Console.ReadLine();
            } else {
                    Console.WriteLine("===File checksum calculator===");
                    Console.WriteLine("Calculating Checksum...");
                    Console.WriteLine("-MD5: " + Hashes.calculateMD5(args[0]));
                    Console.WriteLine("-SHA1: " + Hashes.calculateSHA1(args[0]));
                    Console.WriteLine("-SHA256: " + Hashes.calculateSHA256(args[0]));
                    Console.WriteLine("-SHA386: " + Hashes.calculateSHA384(args[0]));
                    Console.WriteLine("-SHA512: " + Hashes.calculateSHA512(args[0]));
                    Console.WriteLine("===File checksum calculator===");
            }
        }
    }
}
