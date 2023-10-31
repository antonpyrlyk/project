using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write("Error, no parameters");
                return;
            }
            switch (args[0])
            {
                case "sum":
                    Console.Write(sum(args));

                    if (args.Length < 3)
                    {
                        Console.Write("Error, sum called with too few parameters");
                        return;
                    }
                    break;
                case "dump":
                    if (args.Length < 2)
                    {
                        Console.Write("Error, enter the filename");
                        return;
                    }
                    else if (args.Length > 2)
                    {
                        Console.Write("Error, dump called with too many parameters");
                        return;
                    }
                    else
                    {

                    }
                    break;
                case "concat":
                    Console.Write(concat(args));
                    if (args.Length < 3)
                    {
                        Console.Write("Error, concat called with too few parameters");
                        return;
                    }
                    break;
                case "list":

                    break;
                case "remove":
                    if (args.Length > 3)
                    {
                        Console.Write("Error, remove called with too many parameters");
                        return;
                    }
                    else if (args.Length < 3)
                    {
                        Console.Write("Error, remove called with too few parameters");
                        return;
                    }
                    else
                    {
                        Console.Write(remove(args));
                    }
                    break;
                case "insert":
                    if (args.Length > 4)
                    {
                        Console.Write("Error, insert called with too many parameters");
                        return;
                    }
                    else if (args.Length < 4)
                    {
                        Console.Write("Error, insert called with too few parameters");
                        return;
                    }
                    else
                    {
                    	string result=	insert(args[1],args[2],args[3]);
                    }
                    break;
                case "split":
                    if (args.Length > 3)
                    {
                        Console.Write("Error, split called with too many parameters");
                        return;
                    }
                    else if (args.Length < 3)
                    {
                        Console.Write("Error, split called with too few parameters");
                        return;
                    }
                    else
                    {
                        Console.Write(split(args));
                    }
                    break;
                default:
                    Console.Write("Error, wrong command");
                    break;
            }
        }

        static double sum(string[] args)
        {
            double res = 0.0;
            for (int i = 1; i < args.Length; i++)
            {
                res += double.Parse(args[i]);
            }
            return res;
        }

        static string insert(string str,string cons,string newcons){
            return str.Substring(0, str.IndexOf(cons)+cons.Length) + newcons + str.Substring(str.IndexOf(cons) + cons.Length);
        }

        static string concat(string[] args)
        {
            string res = "";
            for (int i = 1; i < args.Length; i++)
            {
                res += args[i];
            }
            return res;
        }

        static string remove(string[] args)
        {
            string res = "";
            Char c = args[2][0];
            for (int i = 0; i < args[1].Length; i++)
            {
                if (args[1][i] != c)
                {
                    res += args[1][i];
                }
            }
            return res;
        }

        static string split(string[] args)
        {
            return args[1].Replace(args[2], " ");
        }

        static void dump(string[] args) {
            var path = args[1];

            string[] lines = System.IO.File.ReadAllLines(path);

            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty");
            }
            else
            {
                System.Console.WriteLine("Contents of file= ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }
            }
         }
    }
}
