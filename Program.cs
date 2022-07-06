using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        string pathClient = "C:\\Users\\Simone\\source\\repos\\csharp-developer-simulator\\client_activity.txt";
        string pathDeveloper = "C:\\Users\\Simone\\source\\repos\\csharp-developer-simulator\\developer_activity.txt";

        Random rnd = new Random();

        if (File.Exists(pathClient))
        {
            StreamReader reader = File.OpenText(pathClient);

            while (!reader.EndOfStream)
            {
                try
                {
                    StreamWriter writer = File.AppendText(pathDeveloper);

                    string line = reader.ReadLine();

                    writer.WriteLine(line);
                    writer.Close();
                }
                catch(Exception e)
                {   
                    Console.WriteLine(e.Message);
                }

                Thread.Sleep(rnd.Next(1000, 2000));
            }

            reader.Close();
        }
    }
}
