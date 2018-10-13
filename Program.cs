using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            /*List<Account> accountList = new List<Account>();
            */
        

        Controller control=new Controller();
             control.ShowAccount(p);
            foreach (List p in List.AccountList)
            {
                Console.WriteLine(p);
            }
        }}
    }
}