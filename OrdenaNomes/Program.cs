using OrdenaNomes.Entities;

string path = @"C:\Users\ideva\source\repos\OrdenaNomes\OrdenaNomes\nomesSalario.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
} 
catch (IOException e)
{
    Console.WriteLine("An error ocurred ");
    Console.WriteLine(e.Message);
}