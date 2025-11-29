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
        }
    }
}
