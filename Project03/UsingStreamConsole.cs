partial class Program
{
    static void UsingStreamConsole()
    {
        using (var fileFlow = Console.OpenStandardInput())
        using(var ff = new FileStream("ConsoleStream.txt", FileMode.Create))
        {
            var buffer = new byte[1024];


            while (true)
            {
                var readBytes = fileFlow.Read(buffer, 0, 1024);
                ff.Write(buffer, 0, readBytes);
                ff.Flush();
                Console.WriteLine("Read bytes: " + readBytes);
            }

        }
    }
}