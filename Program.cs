namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currentDir = new(Directory.GetCurrentDirectory());
            DirectoryInfo userDir = new(@"C:\Users\jerry");

            Console.WriteLine(currentDir);
            Console.WriteLine(userDir.Name);
            Console.WriteLine(userDir.FullName);
            Console.WriteLine(userDir.Parent);
            Console.WriteLine(userDir.CreationTime);
            Console.WriteLine(currentDir.Root);
            DirectoryInfo toCreate = new(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            toCreate.Create();
            //Directory.Delete(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            string[] customers = { "Tom Smith", "Bob Smith", "Alice Smith" };
            string textFilePath = @"C:\CSharpProjects\CSharpTutorial\FileStorage\textFile1.txt";
            File.WriteAllLines(textFilePath, customers);
            foreach (string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"customer: {customer}");
            }
            DirectoryInfo myDataDir = new(@"C:\CSharpProjects\CSharpTutorial\FileStorage");
            FileInfo[] files = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

        }
    }
}
