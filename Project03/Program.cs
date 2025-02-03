using System.Text;
using System.Text.Unicode;
using Project03.Models;


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
                var currentAccount = ConvertStringToCurrentAccount(line!);
                var message = $"Number: {currentAccount.Number} Agency: {currentAccount.Agency} Balance: {currentAccount.Balance} Client: {currentAccount.Holder.Name}"; 

                Console.WriteLine(message);
                //Console.WriteLine(line);
            }
        }
        Console.ReadLine();
    }

    static CurrentAccount ConvertStringToCurrentAccount(string line)
    {

        //375 4644 2483.13 Jonatan

        var fields = line.Split(',');

        var agency = fields[0];
        var number = fields[1];
        var balance = fields[2];
        var holder = fields[3];

        //the fields above are strings

        var agencyInt = int.Parse(agency);
        var numberInt = int.Parse(number);
        var balanceDouble = double.Parse(balance);
        var client = new Client();
        client.Name = holder;

        var result = new CurrentAccount(agencyInt, numberInt);
        result.Deposit(balanceDouble);
        result.Holder = client;

        return result;
    }
}