using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    class Controller

    {
        public void CreateAccount()
        {
            Account objAccount = new Account();

            Console.WriteLine("Add Details ");
            Console.WriteLine("Enter Your Name ");
            objAccount.Name = Console.ReadLine();
            Console.WriteLine("Enter CNIC ");
            objAccount.CNIC = Console.ReadLine();
            Console.WriteLine("Enter Father's Name ");
            objAccount.FatherName = Console.ReadLine();
            Console.WriteLine("Enter Balance ");
            string Balancia = Console.ReadLine();
            objAccount.Balance = Convert.ToDouble(Balancia);
            List.AccountList.Add(objAccount);

            Account objAccount2 = new Account();

            Console.WriteLine("Add Details ");
            Console.WriteLine("Enter Your Name ");
            objAccount.Name = Console.ReadLine();
            Console.WriteLine("Enter CNIC ");
            objAccount.CNIC = Console.ReadLine();
            Console.WriteLine("Enter Father's Name ");
            objAccount.FatherName = Console.ReadLine();
            Console.WriteLine("Enter Balance ");
            string Balancia2 = Console.ReadLine();
            objAccount.Balance = Convert.ToDouble(Balancia2);
            List.AccountList.Add(objAccount2);
           
        }
        public void ShowAccount(Account obj)
        {

        }
    }
}
