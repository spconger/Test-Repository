using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment11
{
    class ReadFile
    {
        /// <summary>
        /// this class reads text files.
        /// It takes the path to the file as a parameter
        /// in the constructor
        /// </summary>
        /// 
        private StreamReader reader;
        private string filePath;

        //constructor takes in the path
        //as parameter
        public ReadFile(string path)
        {
            filePath = path;

        }

        public string GetFile()
        {
            //this method gets the file and
            //reads it, returning a string
            string line = null;
            //when dealing with things like files
            //it is a good idea to use a try set
            //It is always possible that the file
            //is not at the specified path
            //or that it is unreadable
            try
            {
                //get the file from the location
                //indicated by the path
                reader = new StreamReader(filePath);
                //read it all into a string
                //this is not very sophisticated
                //there are other ways to read the file
                line = reader.ReadToEnd();
            }
            catch (FileNotFoundException fnf)
            {
                //the FileNotFoundException is a pre built
                //exception for missing files
                //we throw the exception to the 
                //calling class for display
                throw fnf;
            }
            catch (Exception ex)
            {
                //this catch is for any other kind
                //of error
                throw ex;
            }
            return line;
        }
    }
}






