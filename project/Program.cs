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
                    if (args.Length > 3)
                    {
                        Console.Write("Error, sum called with too few parameters");
                        return;
                    }
                    sum(args);
                    break;
                case "dump":
                    if (args.Length > 2)
                    {
                        Console.Write("Error, enter the filename");
                        return;
                    }
                    break;
                case "concat":
                    Console.Write(concat(args));
                    if (args.Length > 3)
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

                    }
                    break;
                default:
                    Console.Write("Error, wrong command");
                    break;
            }
        }

        static double sum(string[] args)
        {
            // TODO
            return 0.0;
        }

        static string concat(string[] args)
        {
            string res = "";
            // TODO
            return res;
        }

        static string remove(string[] args)
        {
            string res = "";
            // TODO
            return res;
        }
    }
}
