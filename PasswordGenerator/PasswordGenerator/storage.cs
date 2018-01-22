using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    //Class wich store the passwords
    class storage
    {
        public storage() {}

        //Function which store the passwords in pass.txt and print it on console
        public void store(string arg4, savepath en, generator g)
        {
            Int64 i = 0;
            string pass = string.Empty;
            //We write the number of passwords that the user enter before, if he is negative then it's infinite
            while (i != Convert.ToInt64(arg4))
            {
                //If a key is pressed
                if (Console.KeyAvailable)
                {
                    //Read the key and if it's escape then it close the application
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
                pass = g.chaine();
                en.enregistrer(pass);
                Console.WriteLine(pass);
                i++;
            }
        }
    }
}
