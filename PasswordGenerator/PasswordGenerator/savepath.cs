using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PasswordGenerator
{
    class savepath
    {
        private string path;

        public savepath(string path)
        {
            this.path = path;
        }

        public savepath()
        {
            this.path = ("");
        }

        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        public void enregistrer(string chaine)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path + "pass.txt", true, System.Text.Encoding.ASCII);
                sw.WriteLine(chaine);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
