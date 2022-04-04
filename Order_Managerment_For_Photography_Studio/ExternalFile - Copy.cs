using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Managerment_For_Photography_Studio
{
    public class ExternalFile
    {
        private int a;
        // Use for Read from File
        FileInfo fileRead;
        //Use for write to FIle
        FileInfo fileWrite;
        StreamReader sr;
        StreamWriter sw;
        String path = @"C:\Users\Dell\Documents\OrderManagerment\data.txt";
        /// <summary>
        /// pathRead is a link of File to read out
        /// pathWrite is a linke of File to write in
        /// </summary>
        /// <param name="pathRead"></param>
        /// <param name="pathWrite"></param>
        public ExternalFile()
        {
            DirectoryInfo di = Directory.CreateDirectory(@"C:\Users\Dell\Documents\OrderManagerment");
            if(!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Close();
            }
            try
            {
                fileRead = new FileInfo(path);
                fileWrite = new FileInfo(path);
                //sw = new StreamWriter(path, append: true);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot load file!");
            }
            
        }

        /// <summary>
        /// Method Read data from file and return List of String
        /// </summary>
        /// <returns> List </returns>
        public List<String> readAllTextFromFile()
        {
            sr = fileRead.OpenText();
            List<String> listStr = new List<string>();
            String stringReaded="";
            string temp;
            while ((temp = sr.ReadLine() ) != null)
            {
                listStr.Add(temp);
            }
            sr.Close();
            return listStr;
          
            
        }

        /// <summary>
        /// Write String in List to file
        /// </summary>
        /// <param name="str"></param>
        public void writeAllToFile(List<String> str)
        {
            sw = fileWrite.CreateText();
            foreach (String x in str)
            {
                sw.WriteLine(x);
            
            }
            sw.Close();
        }


        public void writeLineToFile(String str)
        {
            sw = fileWrite.AppendText();
            sw.WriteLine(str);
            sw.Close();
        }


        public Boolean isEmpty()
        {
            return (readAllTextFromFile().Count <= 0) ? true : false; 
        }

    }
}
