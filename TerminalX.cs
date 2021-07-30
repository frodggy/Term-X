using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
	

namespace TerminalX
{
    class TerminalX
    {
    
        #region main
        
        static void Main(string[] args)
        {
         

            ConsoleSpiner spin = new ConsoleSpiner();
            void OnStart()
            {
                DateTime start = DateTime.Now;
                DateTime finish = start.AddSeconds(180);
                Console.WriteLine("Setting up");
                  while(DateTime.Now < finish)
                {
                spin.Turn();
                }
                Console.WriteLine("Done setting up");
               


            }
            

            string prefix = "cola";
            string host = "forkedOS";
            string ver = "0.0.0";
            string programname = "Forkkit-CLI-v";

            
             
           
             Console.ForegroundColor = ConsoleColor.Green;
             Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "⠀⠀⠀" + programname + ver + "⠀⠀⠀⠀";
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");
            Console.WriteLine("==========" + programname + ver + "=============");
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
                  OnStart();

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
              if (currentLine == prefix + " " + "clear")
             {
              Console.Clear();
             }
             if (currentLine == prefix + " " + "pwd")
             {
                Console.WriteLine(Directory.GetCurrentDirectory());
             }
             if (currentLine == prefix + " " + "cp")
             {
                 if (args.Length != 2)
                {
                    Console.WriteLine("The syntax of the command is incorrect.");
                }
                else
                {
                    if (File.Exists(args[0]) == false)
                    {
                        Console.WriteLine("Source file not found");
                    }
                    else if (Directory.Exists(args[1]) == false)
                    {
                        Console.WriteLine("Target Directory not found");
                    }
                    else
                    {
                        File.Copy(args[0], args[1] + "\\" + args[0]);
                    }
                }
             }
                        
        }
        #endregion
    }

        public class ConsoleSpiner
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;        
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }


    }
}

}
