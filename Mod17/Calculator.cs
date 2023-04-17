using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mod17
{
    public class Calculator
    {

        public void ShowTarif(IBankProfile bankProfile, Account acc)
        {

            bankProfile.CalculateInterest(acc);
        }

    }
}
