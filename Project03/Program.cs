using System.Text;
using System.Text.Unicode;

var fileAddress = "Accounts.txt";

var byteNumber = -1;

var fileFlow = new FileStream(fileAddress, FileMode.Open);

var buffer = new byte[1024]; //1 Kbyte (KB)

while (byteNumber != 0)
{
    byteNumber = fileFlow.Read(buffer, 0 , 1024);

    WriteBuffer(buffer);

}

//fileFlow.Read(buffer, 0, 1024); //Buffer[array temporario] - posicao inicial - posicao final a ser preenchida

static void WriteBuffer(byte[] buffer)
{
    var utf8 = new UTF8Encoding();

    var text = utf8.GetString(buffer);
    Console.Write(text);

    /*foreach (byte _byte in buffer)
    {
        Console.Write(_byte);
        Console.Write(" ");
    }*/
}
