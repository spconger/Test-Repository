using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment11
{
    class WriteFiles
    {
        /// <summary>
        /// This class writes a text file
        /// the constructor takes the path
        /// --the complete file name--
        /// and instantiates the StreamWriter
        /// object that writes the files
        /// </summary>
        private StreamWriter writer;
        public WriteFiles(string path)
        {
            //instantiate the SteamWriteObject
            //its constructor takes the path
            //the true means set the file to append
            //if it exists. If it doesn't exist it
            //will create the file
            //false would mean to write over
            //the file if it exists
            writer = new StreamWriter(path, false);
        }

        public void AddToFile(string line)
        {
            //this uses a method of the StreamWriter
            //that writes a line to the file
            writer.WriteLine(line);
        }

        public void CloseFile()
        {
            //this closes the file
            //if you don't close it
            //you will be unable to access
            //the file
            writer.Close();
        }
    }

}
