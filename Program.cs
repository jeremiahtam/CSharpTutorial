using System;
using System.Text;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* File I/O */
            //DirectoryInfo currentDir = new(Directory.GetCurrentDirectory());
            //DirectoryInfo userDir = new(@"C:\Users\jerry");

            //Console.WriteLine(currentDir);
            //Console.WriteLine(userDir.Name);
            //Console.WriteLine(userDir.FullName);
            //Console.WriteLine(userDir.Parent);
            //Console.WriteLine(userDir.CreationTime);
            //Console.WriteLine(currentDir.Root);
            //DirectoryInfo toCreate = new(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            //toCreate.Create();
            ////Directory.Delete(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            //string[] customers = { "Tom Smith", "Bob Smith", "Alice Smith" };
            //string textFilePath = @"C:\CSharpProjects\CSharpTutorial\FileStorage\textFile1.txt";
            //File.WriteAllLines(textFilePath, customers);
            //foreach (string customer in File.ReadAllLines(textFilePath))
            //{
            //    Console.WriteLine($"customer: {customer}");
            //}
            //DirectoryInfo myDataDir = new(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            //FileInfo[] textfiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            //Console.WriteLine("Matches {0}:", textfiles.Length);
            //foreach (FileInfo f in textfiles)
            //{
            //    Console.WriteLine(f.Name);
            //    Console.WriteLine(f.Length);
            //}
            /* End File I/O */

            /* File Streams */

            //string textFilePath2 = @"C:\CSharpProjects\CSharpTutorial\FileStorage\textFile2.txt";
            //FileStream fs = File.Open(textFilePath2, FileMode.Create);
            //string randString = "This is a random string";
            //byte[] rsByteString = Encoding.Default.GetBytes(randString);
            //fs.Write(rsByteString, 0, rsByteString.Length);
            //fs.Position = 0;
            //byte[] fileByteArray = new byte[rsByteString.Length];

            //for (int i = 0; i < fileByteArray.Length; i++)
            //{
            //    fileByteArray[i] = (byte)fs.ReadByte();
            //}
            //Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            //fs.Close();

            /* File Streams End */

            /** Stream Writers/Readers **/
            string textFilePath3 = @"C:\CSharpProjects\CSharpTutorial\FileStorage\textFile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath3);
            sw.Write("This is a new text.");
            sw.WriteLine("Testing streamwriter");
            sw.Close();
            StreamReader sr = new StreamReader(textFilePath3);
            Console.WriteLine("Stuff: {0}", Convert.ToChar(sr.Peek()));
            /** Stream Writer **/

        }
    }
}
