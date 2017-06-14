using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleGram
{
    class Command
    {


        public  void PrintInText() {

            Console.WriteLine("Simple Console VERSION 0.0 BETA");

        }

        static int[] CmdMemoryInt = new int[10000];
        
        static string [] CmdMemoryString = new string[10000];
        
        public void Parse(string[] Instring, string[] roundstring)
        {
            

            // Hello
            if (Instring[0] == "Hello" || Instring[0] == "hello")
            {

                Console.WriteLine("Hi!");

            }

            // Print
            else if (Instring[0] == "Print" || Instring[0] == "print" || Instring[0] == "Echo" || Instring[0] == "echo")
            {
                for (int i = 1; i < Instring.Length; i++)
                {

                    if (Instring[i] == "MemInt")
                    {
                        int k = i++;
                        int memspot;

                        memspot = Convert.ToInt32(roundstring[k]);
                        Console.Write(CmdMemoryInt[memspot] + " ");

                    }
                    else if (Instring[i] == "MemStr")
                    {
                        int k = i++;
                        int memspot;

                        memspot = Convert.ToInt32(roundstring[k]);
                        Console.Write(CmdMemoryString[memspot] + " ");

                    }
                    else
                    {

                        Console.Write(Instring[i] + " ");

                    }


                }
                Console.Write("\n");


            }
            // Let
            else if (Instring[0] == "Let" || Instring[0] == "let")
            {

                if (Instring[1] == "Int" || Instring[1] == "int")
                {

                    CmdMemoryInt[Convert.ToInt32(Instring[3])] = Convert.ToInt32(Instring[2]);
                    Console.WriteLine(Instring[2] + " Saved To Location " + Instring[3]);


                }
                if (Instring[1] == "String" || Instring[1] == "string")
                {

                    CmdMemoryString[Convert.ToInt32(Instring[3])] = Instring[2];
                    Console.WriteLine(Instring[2] + " Saved To Location " + Instring[3]);


                }
                else
                {

                    Console.WriteLine(Instring[1] + " is not a known variable");

                }


            }

            // Math
            else if (Instring[0] == "Math" || Instring[0] == "math")
            {

                int sm1 = Convert.ToInt32(Instring[1]);
                char chr = Convert.ToChar(Instring[2]);
                int sm2 = Convert.ToInt32(Instring[3]);



                if (chr == '+')
                {

                    Console.WriteLine(sm1 + sm2);

                }
                else if (chr == '-')
                {

                    Console.WriteLine(sm1 - sm2);

                }
                else if (chr == '*')
                {

                    Console.WriteLine(sm1 * sm2);

                }
                else if (chr == '/')
                {

                    Console.WriteLine(sm1 / sm2);

                }


            }
            // Rem
            else if (Instring[0] == "Rem" || Instring[0] == "rem")
            {

                if (Instring[1] == "Int" || Instring[1] == "int")
                {


                    Console.WriteLine(Instring[2] + " Removed At Location " + Instring[2]);
                    CmdMemoryInt[Convert.ToInt32(Instring[2])] = 0;





                }
                else if (Instring[1] == "string" || Instring[1] == "String")
                {


                    Console.WriteLine(Instring[2] + " Removed At Location " + Instring[2]);
                    CmdMemoryString[Convert.ToInt32(Instring[2])] = "";





                }
                // Read
            }
            else if (Instring[0] == "Read" || Instring[0] == "read")
            {
                try
                {
                    string[] text = System.IO.File.ReadAllLines(Instring[1]);

                    for (int i = 0; i < text.Length; i++)
                    {

                        Console.WriteLine(text[i]);
                    }

                }
                catch
                {

                    Console.WriteLine("Error Loading File.");

                }





            }
            // editor
            else if (Instring[0] == "editor" || Instring[0] == "Editor")
            {

                Text_Editor txt = new Text_Editor();
                txt.InitEditor();

            }
            // beep
            else if (Instring[0] == "beep" || Instring[0] == "Beep")
            {

                Console.Beep(Convert.ToInt32( Instring[1]), Convert.ToInt32(Instring[2]));
                

            }

            else if (Instring[0] == "help" || Instring[0] == "Help")
            {

                Console.WriteLine("_-Commands-_");
                Console.WriteLine("Let, Allows you to store ints or strings. First Arg, You can either choose Int or String to choose what array you want to write to, Secound Arg, What value you want to write, Third Arg, What space you are going to write to in the array. Example : Let string Hello! 0 \n\n");
                Console.WriteLine("Rem, Removes a space in either String or Int, First Arg You can either choose Int or String to Choose what array you want to remove from, Secound Arg, What space you want to remove, Example : Rem int 0 \n\n");
                Console.WriteLine("Math, Calculates math (+,-,*,/) , Example : Math 5 * 2 \n\n");
                Console.WriteLine("Print, Allows you to print Text or Data, Example : print hello!, To print data, there is a command called MemInt / MemStr, this requires a extra command that you put the place in the array you want to print, Example : Print MemInt (0)  \n\n");


            }
            // Unknown Command
            else
            {

                Console.WriteLine(Instring[0] + " is not a valid Command.");


            }
            

        }

    }
}
