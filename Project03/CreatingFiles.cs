using System.Text;

partial class Program
{
    static void CreateFile()
    {
        var fileAddressPath = "ExportedAccounts.csv";

        using (var fileFlow = new FileStream(fileAddressPath, FileMode.Create))
        {
            var stringAccount = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(stringAccount);

            fileFlow.Write(bytes, 0, bytes.Length);
        }
    }

    static void CreateFileWithWriter()
    {
        var fileAddressPath = " ExportedAccounts.csv";

        using(var fileFlow = new FileStream(fileAddressPath, FileMode.Create))
        using(var writer = new StreamWriter(fileFlow))
        {
            writer.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestWrite()
    {
        var fileAddressPath = "test.txt";

        using(var fileFlow = new FileStream(fileAddressPath, FileMode.Create))
        using(var writer = new StreamWriter(fileFlow))
        {
            for (var i = 0; i < 1000000; i++)
            {
                writer.WriteLine("Line " + i);
                writer.Flush();
                Console.ReadLine();
            }
        }
    }
}