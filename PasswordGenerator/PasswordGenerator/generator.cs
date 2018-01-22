using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class generator
    {
        private Int64 minL;
        private Int64 maxL;
        private Random rnd = new Random();

        //Constructor with 2 parameters
        public generator(Int64 min, Int64 max)
        {
            this.minL = min;
            this.maxL = max;

        }
        //Constructor with 1 parameter
        public generator(Int64 min)
        {
            this.minL = min;
            this.maxL = nbMax();
        }

        //Create a string which contain the password
        public string chaine()
        {
            Int64 lg = longueur();
            string chaine = "";
            for (Int64 i = 0; i <= lg - 1; i++)
            {
                chaine += Alea();
            }
            return chaine;
        }

        //Generate a random length
        public Int64 longueur()
        {
            return (long)((rnd.NextDouble() * (maxL + 1 - minL)) + minL);
        }

        //Generate a random max length
        public Int64 nbMax()
        {
            return (long)((rnd.NextDouble()*11+minL));
        }

        //Generate a random ASCII character
        public char Alea()
        {
            int nbAlea = 0;
            nbAlea = rnd.Next(33, 127);
            char ascii;
            return ascii = Convert.ToChar(nbAlea);
        }
    }
}
