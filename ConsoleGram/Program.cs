using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Command cmd = new Command();
            cmd.PrintInText();
            while (true)
            {
                
                
                Console.Write(">");
                string COMMAND;
                COMMAND = Console.ReadLine();
                string[] spacecmdarray = COMMAND.Split(' ');
                string[] lparcmdarray = COMMAND.Split('(', ')');
                
                
                
                cmd.Parse(spacecmdarray,lparcmdarray);
            }
            

        }
    }
}
