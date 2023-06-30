namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Silent Hill Bank");
            
            BankAccount account = new BankAccount();

            Console.WriteLine("How much money do you want to deposit today?:$");
            var userinput = double.Parse(Console.ReadLine());
            account.Deposit(userinput);
            account.GetBalance();


        }
    }
}
