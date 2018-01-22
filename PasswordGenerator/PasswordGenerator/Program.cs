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

            Boolean b = true;
            Console.WriteLine("Choose how many password do you want : (-1 for infinite password)");
            string arg4 = Console.ReadLine();

            //Case of 0 argument
            if (args.Length == 0) 
            {
                Console.WriteLine("Choose password min length :");
                String arg1 = Console.ReadLine();
                while (b)
                {
                    //if the min lenght is negative then we ask for a positive number
                    if(Convert.ToInt64(arg1) <= 0)
                    {
                        Console.WriteLine("Choose a positive number :");
                        arg1 = Console.ReadLine();
                    }
                    else
                    {
                        b = false;
                    }
                }
                b = true;
                Console.WriteLine("Choose password max length :");
                String arg2 = Console.ReadLine();
                while (b)
                {
                    //if the max lenght is inferior then we ask for a superior number
                    if (Convert.ToInt64(arg2) <= Convert.ToInt64(arg1))
                    {
                        Console.WriteLine("Choose a number superior than the minimum:");
                        arg2 = Console.ReadLine();
                    }
                    else
                    {
                        b = false;
                    }
                }
                Console.WriteLine("Choose the path :");
                String arg3 = Console.ReadLine();

                //We create two object on which return a string which is the password and one which is the path where the file is
                generator g = new generator(Convert.ToInt64(arg1), Convert.ToInt64(arg2));
                savepath en = new savepath(arg3);
                //We create a last object to store the password inside the file
                storage st = new storage();
                st.store(arg4, en, g);
            }
            //Case of 1 argument
            else if (args.Length == 1)
            {
                generator g = new generator(Convert.ToInt64(args[0]));
                savepath en = new savepath();
                storage st = new storage();
                st.store(arg4, en, g);
            }
            //Case of 2 arguments
            else if (args.Length == 2)
            {
                generator g = new generator(Convert.ToInt64(args[0]), Convert.ToInt64(args[1]));
                savepath en = new savepath();
                storage st = new storage();
                st.store(arg4, en, g);
            }
            //Case of 3 arguments
            else if (args.Length == 3)
            {
                generator g = new generator(Convert.ToInt64(args[0]), Convert.ToInt64(args[1]));
                savepath en = new savepath(args[2]);
                storage st = new storage();
                st.store(arg4, en,g);
            }
            Console.Read();
        }
       
    }
}
