using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Choose how many password do you want : (-1 for infinite password)");
            string arg4 = Console.ReadLine();

            //Case of 0 argument
            if (args.Length == 0) 
            {
                Console.WriteLine("Choose password min length :");
                String arg1 = Console.ReadLine();
                Console.WriteLine("Choose password max length :");
                String arg2 = Console.ReadLine();
                Console.WriteLine("Choose the path :");
                String arg3 = Console.ReadLine();
                

                generator g = new generator(Convert.ToInt16(arg1), Convert.ToInt16(arg2));
                savepath en = new savepath(arg3);
                
                while (i < Convert.ToInt16(arg4))
                {
                    string pass = g.chaine();
                    en.enregistrer(pass);
                    Console.WriteLine(pass);
                    i++;
                }
            }
            //Case of 1 argument
            else if (args.Length == 1)
            {
                generator g = new generator(Convert.ToInt16(args[0]));
                savepath en = new savepath();
                while (i < Convert.ToInt16(arg4))
                {
                    string pass = g.chaine();
                    en.enregistrer(pass);
                    Console.WriteLine(pass);
                    i++;
                }
            }
            //Case of 2 arguments
            else if (args.Length == 2)
            {
                generator g = new generator(Convert.ToInt16(args[0]), Convert.ToInt16(args[1]));
                savepath en = new savepath();
                while (i < Convert.ToInt16(arg4))
                {
                    string pass = g.chaine();
                    en.enregistrer(pass);
                    Console.WriteLine(pass);
                    i++;
                }
            }
            //Case of 3 arguments
            else if (args.Length == 3)
            {
                generator g = new generator(Convert.ToInt16(args[0]), Convert.ToInt16(args[1]));
                savepath en = new savepath(args[2]);
                while (i < Convert.ToInt16(arg4))
                {
                    string pass = g.chaine();
                    en.enregistrer(pass);
                    Console.WriteLine(pass);
                    i++;
                }


            }
            Console.Read();
        }
    }
}
