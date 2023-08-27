string path = @"C:\Users\ideva\source\repos\OrdenaNomes\OrdenaNomes\nomes.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<string> list = new List<string>();
        while (!sr.EndOfStream)
        {
            list.Add(sr.ReadLine());
        }
        list.Sort();
        foreach (string line in list)
        {
            Console.WriteLine(line);
        }
    }
} 
catch (IOException e)
{
    Console.WriteLine("An error ocurred: ");
    Console.WriteLine(e.Message);
}