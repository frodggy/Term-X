using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Net;
using System.IO;
	

namespace TerminalX
{
    class TerminalX
    {
    
        #region main
        
        static void Main(string[] args)
        {
            

            string prefix = "cola";
            string host = "LocalHost";
            string ver = "0.0.1";

            
             
           
             Console.ForegroundColor = ConsoleColor.Green;
             Console.Clear();
            Console.Title = "⠀⠀⠀⠀⠀phoenix-terminal-v" + ver + "⠀⠀⠀⠀";
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========phoenix-terminal-v" + ver + "=========");
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
            Console.Write(userName + "@" + host + ":" + "⠀" ); // Prompt
            string currentLine = Console.ReadLine(); // Get string from user
            if (currentLine == prefix + " " + "exit") // Check string
            {
                Environment.Exit(0);
                break;
            }https://github.com/frodggy/Term-X/blob/Terminal-v1.0.0/TerminalX.cs
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


             if (currentLine == prefix + " " + "pers" + " " + "passwrd" + " " + "--show")
             {
              Console.WriteLine(password);   
             }

             if (currentLine == prefix + " " + "pers" + " " + "passwrd" + " " + "-s")
             {
              Console.WriteLine(password);   
             }

                if (currentLine == prefix + " " +  "pers" + " " + "passwrd" + " " + "--change")
             {
              password = Console.ReadLine();
             }

             if (currentLine == prefix + " " + "pers" + " " + "passwrd" + " " + "-c")
             {
              password = Console.ReadLine();   
             }
                 
        #endregion
             

   }
 }
}
}
