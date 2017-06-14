using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    class Text_Editor
    {
        int CurrentLine = 0;
        Dictionary<int, string> textlist = new Dictionary<int, string>();
        bool EXITING;
        void exit()
        {
            EXITING = true;

        }

        public void InitEditor() {

            
            Console.WriteLine("--------------------------");
            Console.WriteLine("       Text Editor        ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Text Editor 0.0 BETA");
            Console.WriteLine("\n\n");
            while(true)
            {
                if (EXITING==true)
                {

                    break;
                }
                Parse();
                

            }

       
        }

        void Parse()
        {

            Console.Write("Line " + CurrentLine + ":");
            // prints text
            string text = Console.ReadLine();
            if (text == ".,print")
            {

                for (int i = 0; i < CurrentLine; i++)
                {

                    Console.WriteLine(textlist[i]);


                }
                return;
            }
            // saves file
            else if (text == ".,save")
            {

                Console.Write(">");
                string tosave = Console.ReadLine();
                try
                {
                    TextWriter write = new StreamWriter(tosave, true);
                    for (int i = 0; i < CurrentLine; i++)
                    {

                        write.WriteLine(textlist[i]);


                    }

                    Console.WriteLine("Wrote");
                    write.Close();
                }
                catch
                {
                    Console.WriteLine("ERROR - was not able to write file");
                }
                return;
            }
            // exits program
            else if (text == ".,exit")
            {
                
                exit();
            


            }




                textlist.Add(CurrentLine, text);
            CurrentLine++;
        }

    }
}
