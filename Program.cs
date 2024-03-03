using Module17;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        var ordinaryAccount = new Account { Type = "Обычный", Balance = 1500 };
        var salaryAccount = new Account { Type = "Зарплатный", Balance = 2000 };

        var ordinaryAccountType = new OrdinaryAccount();
        var salaryAccountType = new SalaryAccount();

        Calculator.CalculateInterest(ordinaryAccount, ordinaryAccountType);
        Calculator.CalculateInterest(salaryAccount, salaryAccountType);

        // Выводим результаты
        Console.WriteLine($"Interest for Ordinary Account: {ordinaryAccount.Interest}");
        Console.WriteLine($"Interest for Salary Account: {salaryAccount.Interest}");
    }
}
