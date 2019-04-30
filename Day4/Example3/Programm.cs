
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Csharp_tuto.Day4.Example3
{
    class Programm
    {
        public static void Main1()
        {
            DirectoryInfo curantDir = new DirectoryInfo(".");

            DirectoryInfo curantDirAb = new DirectoryInfo(@"C:\Users\youssef\DATA_YO");
            curantDirAb.Create();
            Console.WriteLine(curantDirAb.FullName); //fullname
            Console.WriteLine(curantDirAb.Name);   //name
            Console.WriteLine(curantDirAb.Parent);                                              //Parent
            Console.WriteLine(curantDirAb.Attributes);                                                                                         // attributs
            Console.WriteLine(curantDirAb.CreationTime);                                                                                                                                    // creationTime
        

        //
        string[] students =
        {
            "aymen aymen",
            "adil adil",
            "youssef youssef"
        };

            // write to file
        string textFilePath = @"C:\Users\youssef\DATA_YO\testFile.txt";
            ;
            Console.WriteLine(textFilePath);

            File.WriteAllLines(textFilePath, students);

            // read from file
            foreach(string line in File.ReadLines(textFilePath))
            {
                Console.WriteLine($"student : {line}");
            }

            // get all folder files
            curantDirAb = new DirectoryInfo(@"C:\Users\youssef\DATA_YO");
            FileInfo[] textfiles = curantDirAb.GetFiles("*.txt",
                SearchOption.AllDirectories);
            foreach (FileInfo file in textfiles)
            {
                Console.WriteLine($"file : {file.FullName} with size : {file.Length}");
            }


            // File stream

            string streamPath = @"C:\Users\youssef\DATA_YO\streamTextFile.txt";

            FileStream fileStream = File.Open(streamPath, FileMode.Create);
            string str = "this is a stream string";
            string str2 = "this is an other \n stream string";

            byte[] strbyte = Encoding.Default.GetBytes(str);
            byte[] strbyte2 = Encoding.Default.GetBytes(str2);

            fileStream.Write(strbyte, 0, strbyte.Length);
            //fileStream.Position = 0;
            fileStream.Write(strbyte2, 0, strbyte.Length);

            fileStream.Close();

            // Serialisation

            // save a serialisable object
            Owner o = new Owner("ahmed",1);

            string json = JsonConvert.SerializeObject(o);

            File.WriteAllText(@"C:\Users\youssef\DATA_YO\serialTextFile.txt", json);

            using (StreamWriter file = File.CreateText(@"C:\Users\youssef\DATA_YO\serialTextFile2.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(file, o);
            }

            // quick test of serialisable
            Owner o1 = new Owner("name 1", 1);
            streamPath = @"C:\Users\youssef\DATA_YO\streamTextFile_1.txt";
            Stream stream = File.Open(streamPath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, o1);
            stream.Close();

            // deserialisable


            Console.ReadLine();
        }
    }
}