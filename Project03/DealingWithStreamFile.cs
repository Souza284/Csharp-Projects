using System.Text;
using System.Text.Unicode;

partial class Program
{
    static void DealingWithStreamFile()
    {
        var fileAddress = "Accounts.txt";

        using (var fileFlow = new FileStream(fileAddress, FileMode.Open))
        {
            var byteNumber = -1;

            var buffer = new byte[1024]; //1 Kbyte (KB)

            while (byteNumber != 0)
            {
                byteNumber = fileFlow.Read(buffer, 0, 1024);

                //Console.WriteLine("Read bytes: " + byteNumber);

                WriteBuffer(buffer, byteNumber);

            }

            fileFlow.Close();

            Console.ReadLine();

            //fileFlow.Read(buffer, 0, 1024); //Buffer[array temporario] - posicao inicial - posicao final a ser preenchida
        }
    }

    static void WriteBuffer(byte[] buffer, int byteNumber)
    {
        var utf8 = new UTF8Encoding();

        var text = utf8.GetString(buffer, 0, byteNumber);

        Console.Write(text);

        /*foreach (byte _byte in buffer)
        {
            Console.Write(_byte);
            Console.Write(" ");
        }*/
    }
}