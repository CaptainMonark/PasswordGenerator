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

        //Constructor with 1 parameter
        public savepath(string path)
        {
            this.path = path;
        }
        
        //Constructor without parameter
        public savepath()
        {
            this.path = ("");
        }

        //Getter and setter of the path
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }
        
        //Create a file where the passwords will be written
        //If the file already exist, the passwords will be written at the beginning of it
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
