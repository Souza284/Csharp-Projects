partial class Program
{
    static void BinaryWriter()
    {
        var fileAddressPath = "CurrentAccount.txt";

        using(var fileFlow = new FileStream(fileAddressPath, FileMode.Create))
        using(var writer = new BinaryWriter(fileFlow))
        {
            writer.Write(456);
            writer.Write(546544);
            writer.Write(4000.50);
            writer.Write("Gustavo Braga");
        }
    }

    static void BinaryReader()
    {
        var fileAddressPath = "CurrentAccount.txt";

        using(var fileFlow = new FileStream(fileAddressPath, FileMode.Open))
        using(var reader = new BinaryReader(fileFlow))
        {
            var agency = reader.ReadInt32();
            var number = reader.ReadInt32();
            var balance = reader.ReadDouble();
            var client = reader.ReadString();

            Console.WriteLine($"{agency}/{number}/{balance}/{client}");
        }
    }
}