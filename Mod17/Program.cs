namespace Mod17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Balance = 35000;
            account.Interest = 5;
            account.Type = "Обычный";

            Calculator calculator = new Calculator();
            calculator.ShowTarif(new OrdinaryProfile(), account);
            calculator.ShowTarif(new SalaryProfile(), account);
        }
    }
}