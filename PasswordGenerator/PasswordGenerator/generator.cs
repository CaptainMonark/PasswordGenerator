using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class generator
    {
        private int minL;
        private int maxL;
        private Random rnd = new Random();

        //Constructor with 2 parameters
        public generator(int min, int max)
        {
            this.minL = min;
            this.maxL = max;

        }
        //Constructor with 1 parameter
        public generator(int min)
        {
            this.minL = min;
            this.maxL = nbMax();
        }

        //Create a string which contain the password
        public string chaine()
        {
            int lg = longueur();
            string chaine = "";
            for (int i = 0; i <= lg - 1; i++)
            {
                chaine += Alea();
            }
            return chaine;
        }

        //Generate a random length
        public int longueur()
        {
            return rnd.Next(minL, maxL + 1);
        }

        //Generate a random max length
        public int nbMax()
        {
            return rnd.Next(minL+1, minL+11);
        }

        //Generate a random ASCII character
        public char Alea()
        {
            int nbAlea = 0;
            nbAlea = rnd.Next(0, 62);
            nbAlea = nbAlea + 48;
            if (nbAlea >= 58)
            {
                nbAlea = nbAlea + 7;
                if (nbAlea >= 91)
                {
                    nbAlea = nbAlea + 6;
                }

            }
            char ascii;
            return ascii = Convert.ToChar(nbAlea);
        }
    }
}
