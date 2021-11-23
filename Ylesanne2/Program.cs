using System;
using System.IO;
namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\titpe21";
            string userFile = "toyota";
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";          

            if (!File.Exists(fullFilePath))
            {
                File.Create(fullFilePath);
                Console.WriteLine("Fail toyota on loodud");
            }
            else
            {
                Console.WriteLine("Fail toyota juba eksisteerib");
            }
          
            string rootDirectory2 = @"C:\Users\opilane\Samples\titpe21";
            string userFile2 = "BMW";
            string fullfile2path = @$"{rootDirectory2}\{userFile2}.txt";

            if (!File.Exists(fullfile2path))
            {
                File.Create(fullfile2path);
                Console.WriteLine("Fail BMW on loodud");
            }
            else
            {
                Console.WriteLine("Fail BMW juba eksisteerib");
            }

            string rootDirectory3 = @"C:\Users\opilane\Samples\titpe21";
            string userfile3 = "tesla";
            string fullfile3path = $@"{rootDirectory3}\{userfile3}.txt";

            if (!File.Exists(fullfile3path))
            {
                File.Create(fullfile3path);
                Console.WriteLine("Fail Tesla on loodud");
            }
            else
            {
                Console.WriteLine("Fail Tesla juba eksisteerib");
            }




        }
    }
}
