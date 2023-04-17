using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17
{
  public class SalaryProfile : IBankProfile
    { // Метод для расчета процентной ставки
        public void CalculateInterest(Account account) 
        {
            if (account.Type == "Зарплатный")
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
                Console.WriteLine(account.Interest);
            }
           
        }
    }
}
