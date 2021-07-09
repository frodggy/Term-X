using System;
using System.IO;

namespace ItemMakerADD
{
    class TerminalX
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo input = Console.ReadKey(true);
            
            string prefix = "brew";



             Console.ForegroundColor = ConsoleColor.Green;
             Console.Clear();
            Console.Title = "⠀⠀⠀⠀⠀phoenix-terminal-v0.0.1⠀⠀⠀";
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========phoenix-terminal-v0.0.1=========");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("⠀");
            Console.WriteLine("⠀");
            Console.WriteLine("⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀PLEASE⠀LOGIN⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
           
                        Console.WriteLine("What is your username");
            string userName = Console.ReadLine();
             Console.WriteLine("What is the password");
             string password = Console.ReadLine();

             if(password == "root")
             {
                 Console.WriteLine("Logged in" + "⠀Welcome⠀" + userName);
                 
             }
             else
             {
                 return;
             }


                

         while (true) // Loop indefinitely
        {
            Console.Write(userName + "@phenix:" + "⠀" ); // Prompt
            string currentLine = Console.ReadLine(); // Get string from user
            if (currentLine == prefix + " " + "exit") // Check string
            {
                Environment.Exit(0);
                break;
            }
            if (currentLine == prefix + " " + "ls") // Check string
            {
                
                DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    Console.WriteLine("{0, -30}\t directory", d.Name);
                }

                foreach (FileInfo f in dir.GetFiles())
                {
                    Console.WriteLine("{0, -30}\t File", f.Name);
                }
               
             

        }
        
    }
        
   }
 }
}    