using System.Text;
using System.Text.Unicode;


partial class Program
{
    static void Main(string[] args)
    {
        var fileAddress = "Accounts.txt";

        using (var fileFlow = new FileStream(fileAddress, FileMode.Open))
        {
            var reader = new StreamReader(fileFlow);

            //var line = reader.ReadLine();

            //var text = reader.ReadToEnd();

            //var number = reader.Read();

            //Console.WriteLine(line);
            //Console.WriteLine(text);
            //Console.WriteLine(number);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}